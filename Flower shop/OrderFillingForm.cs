using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AccessoriesInOrderRow = Flower_shop.ЗаказыDataSet.Аксессуары_в_заказеRow;
using AccessoriesRow = Flower_shop.ЗаказыDataSet.Каталог_аксессуаровRow;
using FlowersInOrderRow = Flower_shop.ЗаказыDataSet.Цветы_в_заказеRow;
using FlowerRow = Flower_shop.ЗаказыDataSet.Каталог_цветовRow;

namespace Flower_shop
{
	public partial class OrderFillingForm : Form
	{
		private readonly int _orderId;
		private readonly BindingList<AccessoriesInOrderRow> _accessoriesInOrder;
		private readonly BindingList<FlowersInOrderRow> _flowersInOrder;

		public OrderFillingForm(int orderId)
		{
			_orderId = orderId;
			_accessoriesInOrder = new BindingList<AccessoriesInOrderRow>();
			_flowersInOrder = new BindingList<FlowersInOrderRow>();

			InitializeComponent();
		}

		private AccessoriesRow SelectedAccessoryFromCatalog
			=> заказыDataSet.Каталог_аксессуаров[AccessoriesDataGrid.IndexOfSelectedRow()];

		private FlowerRow SelectedFlowerFromCatalog
			=> заказыDataSet.Каталог_цветов[FlowersDataGrid.IndexOfSelectedRow()];

		private void NextButton_Click(object sender, EventArgs e)
		{
			var form = new DataSummaryForm(_orderId);
			SaveToDataBase();
			Close();
			form.ShowDialog();
		}

		private void OrderFillingForm_Load(object sender, EventArgs e)
		{
			вид_цветовTableAdapter.Fill(заказыDataSet.Вид_цветов);
			цветы_в_заказеTableAdapter.Fill(заказыDataSet.Цветы_в_заказе);
			аксессуары_в_заказеTableAdapter.Fill(заказыDataSet.Аксессуары_в_заказе);
			каталог_цветовTableAdapter.Fill(заказыDataSet.Каталог_цветов);
			каталог_аксессуаровTableAdapter.Fill(заказыDataSet.Каталог_аксессуаров);

			AccessoriesInOrderDataGrid.DataSource = _accessoriesInOrder;
			FlowersInOrderDataGrid.DataSource = _flowersInOrder;
		}

		private void AddAccessoryButton_DoubleClick(object sender, EventArgs e)
		{
			AddAccessory();
			UpdateLabelValue();
		}

		private void AddAccessoryButton_Click(object sender, EventArgs e)
		{
			AddAccessory();
			UpdateLabelValue();
		}

		private void AddFlowerButton_Click(object sender, EventArgs e)
		{
			AddFlower();
			UpdateLabelValue();
		}

		private void AddFlowerButton_DoubleClick(object sender, EventArgs e)
		{
			AddFlower();
			UpdateLabelValue();
		}

		private void RemoveAccessoryButton_Click(object sender, EventArgs e)
		{
			RemoveAccessory();
			UpdateLabelValue();
		}

		private void RemoveAccessoryButton_DoubleClick(object sender, EventArgs e)
		{
			RemoveAccessory();
			UpdateLabelValue();
		}

		private void RemoveFlowerButton_Click(object sender, EventArgs e)
		{
			RemoveFlower();
			UpdateLabelValue();
		}

		private void RemoveFlowerButton_DoubleClick(object sender, EventArgs e)
		{
			RemoveFlower();
			UpdateLabelValue();
		}

		private void AddAccessory()
		{
			var accessoryInOrder = _accessoriesInOrder.SingleOrDefault(IsSame);

			if (accessoryInOrder is null)
			{
				AddNewAccessory();
			}
			else
			{
				accessoryInOrder.Количество++;
				_accessoriesInOrder.ResetBindings();
			}
		}

		private void AddFlower()
		{
			var flowerInOrder = _flowersInOrder.SingleOrDefault(IsSame);

			if (flowerInOrder is null)
			{
				AddNewFlower();
			}
			else
			{
				flowerInOrder.Количество++;
				_flowersInOrder.ResetBindings();
			}
		}

		private void RemoveAccessory()
		{
			if (_accessoriesInOrder.Any() == false)
			{
				return;
			}

			var accessoryInOrder = _accessoriesInOrder.Single(Selected);

			accessoryInOrder.Количество--;

			if (accessoryInOrder.Количество <= 0)
			{
				_accessoriesInOrder.Remove(accessoryInOrder);
			}

			_accessoriesInOrder.ResetBindings();
		}

		private void RemoveFlower()
		{
			if (_flowersInOrder.Any() == false)
			{
				return;
			}

			var flowerInOrder = _flowersInOrder.Single(Selected);

			flowerInOrder.Количество--;

			if (flowerInOrder.Количество <= 0)
			{
				_flowersInOrder.Remove(flowerInOrder);
			}

			_flowersInOrder.ResetBindings();
		}

		private bool Selected(AccessoriesInOrderRow accessory)
			=> accessory.Каталог_аксессуаровRow.ID_аксессуара == AccessoriesInOrderDataGrid.SelectedAccessoryId();

		private bool Selected(FlowersInOrderRow flower)
			=> flower.Каталог_цветовRow.ID_цветов == FlowersInOrderDataGrid.SelectedFlowerId();

		private bool IsSame(AccessoriesInOrderRow accessoryInOrder)
			=> accessoryInOrder.Каталог_аксессуаровRow.ID_аксессуара == SelectedAccessoryFromCatalog.ID_аксессуара;

		private bool IsSame(FlowersInOrderRow flowerInOrder)
			=> flowerInOrder.Каталог_цветовRow.ID_цветов == SelectedFlowerFromCatalog.ID_цветов;

		private void AddNewAccessory()
		{
			var newAccessory = заказыDataSet.Аксессуары_в_заказе.NewАксессуары_в_заказеRow();
			newAccessory.Количество = 1;
			newAccessory.Каталог_аксессуаровRow = SelectedAccessoryFromCatalog;

			_accessoriesInOrder.Add(newAccessory);
		}

		private void AddNewFlower()
		{
			var newFlower = заказыDataSet.Цветы_в_заказе.NewЦветы_в_заказеRow();
			newFlower.Количество = 1;
			newFlower.Каталог_цветовRow = SelectedFlowerFromCatalog;

			_flowersInOrder.Add(newFlower);
		}

		private void SaveToDataBase()
		{
			_accessoriesInOrder.ForEach(InsertAccessory);
			_flowersInOrder.ForEach(InsertFlower);
		}

		private void InsertAccessory(AccessoriesInOrderRow accessory)
			=> аксессуары_в_заказеTableAdapter.Insert
			(
				Количество: accessory.Количество,
				ID_заказа: _orderId,
				ID_аксессуара: accessory.Каталог_аксессуаровRow.ID_аксессуара
			);

		private void InsertFlower(FlowersInOrderRow flower)
			=> цветы_в_заказеTableAdapter.Insert
			(
				Количество: flower.Количество,
				ID_заказа: _orderId,
				ID_цветов: flower.Каталог_цветовRow.ID_цветов
			);

		private void UpdateLabelValue()
		{
			TotalAmountLabel.Text = (_accessoriesInOrder.Sum((a) => a.Количество * a.Каталог_аксессуаровRow.Цена)
			                         + _flowersInOrder.Sum((a) => a.Количество * a.Каталог_цветовRow.Цена))
				.ToString(CultureInfo.InvariantCulture);
		}
	}
}