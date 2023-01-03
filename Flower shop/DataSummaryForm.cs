using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
		private const int IndexOfColumnAccessoryId = 4;
		private const int IndexOfColumnOrderId = 5;
		private readonly decimal _sum;

		private OrderRow _currentOrder;

		public DataSummaryForm(decimal sum)
		{
			_sum = sum;

			InitializeComponent();
		}

		private void NextButton_Click(object sender, EventArgs e) => Close();

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
			заказTableAdapter.Update(_currentOrder);
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
			return;
			var list = new BindingList<AccessoriesInOrderRow>();
			
			foreach (DataGridViewRow row in AccessoriesInOrderDataGrid.Rows)
			{
				if ((int)row.Cells[IndexOfColumnOrderId].Value == _currentOrder.ID_заказа)
				{
					continue;
				}

				var newAccessory = заказыDataSet.Аксессуары_в_заказе.NewАксессуары_в_заказеRow();
				newAccessory.ID_заказа = _currentOrder.ID_заказа;
				newAccessory.ID_аксессуара = (int)row.Cells[IndexOfColumnAccessoryId].Value;
				newAccessory.ID_аксессуаров_в_заказе = (int)row.Cells[0].Value;
				newAccessory.Количество = (int)row.Cells[3].Value;
				list.Add(newAccessory);
			}

			AccessoriesInOrderDataGrid.DataSource = list;
		}

		private bool IsCurrentOrder(AccessoriesInOrderRow a) => a.ID_заказа == _currentOrder.ID_заказа;
	}
}