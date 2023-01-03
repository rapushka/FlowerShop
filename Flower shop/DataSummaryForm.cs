using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using OrderRow = Flower_shop.ЗаказыDataSet.ЗаказRow;
using AccessoriesInOrderRow = Flower_shop.ЗаказыDataSet.Аксессуары_в_заказеRow;
using AccessoriesRow = Flower_shop.ЗаказыDataSet.Каталог_аксессуаровRow;
using FlowersInOrderRow = Flower_shop.ЗаказыDataSet.Цветы_в_заказеRow;
using FlowerRow = Flower_shop.ЗаказыDataSet.Каталог_цветовRow;

namespace Flower_shop
{
	public partial class DataSummaryForm : Form
	{
		private readonly decimal _sum;

		private OrderRow _currentOrder;

		public DataSummaryForm(decimal sum)
		{
			_sum = sum;

			InitializeComponent();
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			Close();

			SaveChanges();
		}

		private void DataSummaryForm_Load(object sender, EventArgs e)
		{
			заказTableAdapter.Fill(заказыDataSet.Заказ);
			каталог_цветовTableAdapter.Fill(заказыDataSet.Каталог_цветов);
			каталог_аксессуаровTableAdapter.Fill(заказыDataSet.Каталог_аксессуаров);
			цветы_в_заказеTableAdapter.Fill(заказыDataSet.Цветы_в_заказе);
			аксессуары_в_заказеTableAdapter.Fill(заказыDataSet.Аксессуары_в_заказе);

			LoadOrder();
		}

		private void LoadOrder()
		{
			_currentOrder = заказTableAdapter.GetData().Last();

			UpdateSum();
			TextBoxesFilling();
			DataGridsFilling();
		}

		private void UpdateSum()
		{
			_currentOrder.Стоимость = _sum;
			UpdateCurrentOrder();
		}

		private void TextBoxesFilling()
		{
			CustomerNameTextBox.Text = _currentOrder.Имя_заказчика;
			CustomerPhoneTextBox.Text = _currentOrder.Телефон_заказчика;
			AddressTextBox.Text = _currentOrder.Адрес_доставки;

			ReceiptDateTimePicker.Value = _currentOrder.Дата_приема;
			CompletionDateTimePicker.Value = _currentOrder.Дата_время_выполнения;
			SumTextBox.Text = _currentOrder.Стоимость.ToString(CultureInfo.InvariantCulture);
		}

		private void DataGridsFilling()
		{
			AccessoriesInOrderDataGrid.DataSource = RowsToAccessories();
			FlowersInOrderDataGrid.DataSource = RowsToFlowers();
		}

		private BindingList<AccessoriesInOrderRow> RowsToAccessories()
		{
			var accessories = new BindingList<AccessoriesInOrderRow>();

			AccessoriesInOrderDataGrid.Rows.ForEach(AddToList, @if: IsCurrentOrderForAccessory);
			void AddToList(DataGridViewRow r) => accessories.Add(AsAccessory(r));

			return accessories;
		}

		private BindingList<FlowersInOrderRow> RowsToFlowers()
		{
			var flowers = new BindingList<FlowersInOrderRow>();

			FlowersInOrderDataGrid.Rows.ForEach(AddToList, @if: IsCurrentOrderForFlower);
			void AddToList(DataGridViewRow r) => flowers.Add(AsFlower(r));

			return flowers;
		}

		private bool IsCurrentOrderForAccessory(DataGridViewRow row)
			=> (int)row.Cells[5].Value == _currentOrder.ID_заказа;

		private bool IsCurrentOrderForFlower(DataGridViewRow row) => (int)row.Cells[4].Value == _currentOrder.ID_заказа;

		private AccessoriesInOrderRow AsAccessory(DataGridViewRow row)
		{
			var newAccessory = заказыDataSet.Аксессуары_в_заказе.NewАксессуары_в_заказеRow();
			newAccessory.ID_заказа = _currentOrder.ID_заказа;
			newAccessory.ID_аксессуара = (int)row.Cells[4].Value;
			newAccessory.ID_аксессуаров_в_заказе = (int)row.Cells[0].Value;
			newAccessory.Количество = (int)row.Cells[3].Value;
			return newAccessory;
		}

		private FlowersInOrderRow AsFlower(DataGridViewRow row)
		{
			var newFlower = заказыDataSet.Цветы_в_заказе.NewЦветы_в_заказеRow();
			newFlower.ID_заказа = _currentOrder.ID_заказа;
			newFlower.ID_цветов = (int)row.Cells[3].Value;
			newFlower.ID_цветов_в_заказе = (int)row.Cells[0].Value;
			newFlower.Количество = (int)row.Cells[2].Value;
			return newFlower;
		}

		private void SaveChanges()
		{
			_currentOrder.Имя_заказчика = CustomerNameTextBox.Text;
			_currentOrder.Телефон_заказчика = CustomerPhoneTextBox.Text;
			_currentOrder.Адрес_доставки = AddressTextBox.Text;

			_currentOrder.Дата_приема = ReceiptDateTimePicker.Value;
			_currentOrder.Дата_время_выполнения = CompletionDateTimePicker.Value;

			UpdateCurrentOrder();
		}

		private void UpdateCurrentOrder() => заказTableAdapter.Update(_currentOrder);
	}
}