using System;
using System.ComponentModel;
using System.Windows.Forms;
using AccessoriesInOrderRow = Flower_shop.ЗаказыDataSet.Аксессуары_в_заказеRow;
using FlowersInOrderRow = Flower_shop.ЗаказыDataSet.Цветы_в_заказеRow;

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
			var flower = заказыDataSet.Цветы_в_заказе.NewЦветы_в_заказеRow();
			flower.Количество = 1;
			flower.Каталог_цветовRow = заказыDataSet.Каталог_цветов[FlowersDataGrid.IndexOfSelectedRow()];

			_flowersInOrder.Add(flower);
		}

		private void RemoveAccessoryButton_Click(object sender, EventArgs e) { }

		private void RemoveFlowerButton_Click(object sender, EventArgs e) { }

		private void SaveToDataBase()
		{
			foreach (var accessory in _accessoriesInOrder)
			{
				InsertAccessoryInOrder(accessory);
			}
		}

		private void InsertAccessoryInOrder(AccessoriesInOrderRow accessory)
			=> аксессуары_в_заказеTableAdapter.Insert
			(
				accessory.Количество,
				_orderId,
				accessory.Каталог_аксессуаровRow.ID_аксессуара
			);
	}
}