using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using AccessoriesInOrderRow = Flower_shop.ЗаказыDataSet.Аксессуары_в_заказеRow;
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

		private void AddAccessoryButton_Click(object sender, EventArgs e)
		{
			var accessory = заказыDataSet.Аксессуары_в_заказе.NewАксессуары_в_заказеRow();
			accessory.Количество = 1;
			accessory.Каталог_аксессуаровRow
				= заказыDataSet.Каталог_аксессуаров[AccessoriesDataGrid.IndexOfSelectedRow()];

			_accessoriesInOrder.Add(accessory);
		}

		private void AddFlowerButton_Click(object sender, EventArgs e)
		{
			var flowerInOrder = _flowersInOrder.SingleOrDefault(IsSameFlower);

			if (flowerInOrder is null)
			{
				AddNewFlower(SelectedFlowerFromCatalog());
			}
			else
			{
				flowerInOrder.Количество++;
			}
		}

		private bool IsSameFlower(FlowersInOrderRow flowerInOrder)
			=> flowerInOrder.Каталог_цветовRow.ID_цветов == SelectedFlowerFromCatalog().ID_цветов;

		private void AddNewFlower(FlowerRow flowerFromCatalog)
		{
			var newFlower = заказыDataSet.Цветы_в_заказе.NewЦветы_в_заказеRow();
			newFlower.Количество = 1;
			newFlower.Каталог_цветовRow = flowerFromCatalog;

			_flowersInOrder.Add(newFlower);
		}

		private FlowerRow SelectedFlowerFromCatalog()
			=> заказыDataSet.Каталог_цветов[FlowersDataGrid.IndexOfSelectedRow()];

		private void RemoveAccessoryButton_Click(object sender, EventArgs e) { }

		private void RemoveFlowerButton_Click(object sender, EventArgs e) { }

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