using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AccessoriesInOrderRow = Flower_shop.ЗаказыDataSet.Аксессуары_в_заказеRow;

namespace Flower_shop
{
	public partial class OrderFillingForm : Form
	{
		private readonly int _orderId;
		private readonly BindingList<AccessoriesInOrderRow> _accessoriesInOrder;

		public OrderFillingForm(int orderId)
		{
			_orderId = orderId;
			_accessoriesInOrder = new BindingList<AccessoriesInOrderRow>();

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
		}

		private void InsertAccessoryInOrder(AccessoriesInOrderRow accessory)
			=> аксессуары_в_заказеTableAdapter.Insert
			(
				accessory.Количество,
				_orderId,
				accessory.Каталог_аксессуаровRow.ID_аксессуара
			);

		private void RemoveAccessoryButton_Click(object sender, EventArgs e) { }

		private void AddAccessoryButton_Click(object sender, EventArgs e) => AddAccessory();

		private void AddAccessory()
		{
			var indexOfSelectedRow = dataGrid_Kat_Aks.Rows.IndexOf(dataGrid_Kat_Aks.SelectedRows[0]);

			var accessory = заказыDataSet.Аксессуары_в_заказе.NewАксессуары_в_заказеRow();
			accessory.Количество = 1;
			accessory.Каталог_аксессуаровRow = заказыDataSet.Каталог_аксессуаров[indexOfSelectedRow];

			_accessoriesInOrder.Add(accessory);
		}

		private void SaveToDataBase()
		{
			foreach (var a in _accessoriesInOrder)
			{
				InsertAccessoryInOrder(a);
			}
		}
	}
}