using System;
using System.ComponentModel;
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

		private void AddAccessoryButton_DoubleClick(object sender, EventArgs e) => AddAccessory();
		private void AddAccessoryButton_Click(object sender, EventArgs e) => AddAccessory();

		private void AddFlowerButton_Click(object sender, EventArgs e) => AddFlower();
		private void AddFlowerButton_DoubleClick(object sender, EventArgs e) => AddFlower();

		private void RemoveAccessoryButton_Click(object sender, EventArgs e) => RemoveAccessory();
		private void RemoveAccessoryButton_DoubleClick(object sender, EventArgs e) => RemoveAccessory();

		private void RemoveFlowerButton_Click(object sender, EventArgs e) => RemoveFlower();
		private void RemoveFlowerButton_DoubleClick(object sender, EventArgs e) => RemoveFlower();

		private void AddAccessory()
		{
			var accessoryInOrder = _accessoriesInOrder.SingleOrDefault(IsSame);

			if (accessoryInOrder is null)
			{
				AddNewAccessory(SelectedAccessoryFromCatalog());
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
				AddNewFlower(SelectedFlowerFromCatalog());
			}
			else
			{
				flowerInOrder.Количество++;
				_flowersInOrder.ResetBindings();
			}
		}

		private void RemoveAccessory()
		{
			var accessoryInOrder = _accessoriesInOrder.SingleOrDefault(IsSame);

			if (accessoryInOrder is null)
			{
				return;
			}

			accessoryInOrder.Количество--;

			if (accessoryInOrder.Количество <= 0)
			{
				_accessoriesInOrder.Remove(accessoryInOrder);
			}

			_accessoriesInOrder.ResetBindings();
		}

		private void RemoveFlower()
		{
			var flowerInOrder = _flowersInOrder.SingleOrDefault(IsSame);

			if (flowerInOrder is null)
			{
				return;
			}

			flowerInOrder.Количество--;

			if (flowerInOrder.Количество <= 0)
			{
				_flowersInOrder.Remove(flowerInOrder);
			}

			_flowersInOrder.ResetBindings();
		}

		private bool IsSame(AccessoriesInOrderRow accessoryInOrder)
			=> accessoryInOrder.Каталог_аксессуаровRow.ID_аксессуара == SelectedAccessoryFromCatalog().ID_аксессуара;

		private bool IsSame(FlowersInOrderRow flowerInOrder)
			=> flowerInOrder.Каталог_цветовRow.ID_цветов == SelectedFlowerFromCatalog().ID_цветов;

		private void AddNewAccessory(AccessoriesRow accessoryFromCatalog)
		{
			var newAccessory = заказыDataSet.Аксессуары_в_заказе.NewАксессуары_в_заказеRow();
			newAccessory.Количество = 1;
			newAccessory.Каталог_аксессуаровRow = accessoryFromCatalog;

			_accessoriesInOrder.Add(newAccessory);
		}

		private void AddNewFlower(FlowerRow flowerFromCatalog)
		{
			var newFlower = заказыDataSet.Цветы_в_заказе.NewЦветы_в_заказеRow();
			newFlower.Количество = 1;
			newFlower.Каталог_цветовRow = flowerFromCatalog;

			_flowersInOrder.Add(newFlower);
		}

		private AccessoriesRow SelectedAccessoryFromCatalog()
			=> заказыDataSet.Каталог_аксессуаров[AccessoriesDataGrid.IndexOfSelectedRow()];

		private FlowerRow SelectedFlowerFromCatalog()
			=> заказыDataSet.Каталог_цветов[FlowersDataGrid.IndexOfSelectedRow()];

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
	}
}