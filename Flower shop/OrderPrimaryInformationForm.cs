using System;
using System.Linq;
using System.Windows.Forms;
using Flower_shop.ЗаказыDataSetTableAdapters;
using OrderRow = Flower_shop.ЗаказыDataSet.ЗаказRow;

namespace Flower_shop
{
	public partial class OrderPrimaryInformationForm : Form
	{
		private readonly OrderRow _currentOrder;

		public OrderPrimaryInformationForm(ЗаказыDataSet.ЗаказRow currentOrder = null)
		{
			_currentOrder = currentOrder;
			InitializeComponent();
		}

		private bool IsNewOrder => _currentOrder is null;

		// ReSharper disable once ConvertToAutoProperty - another part is in auto-generated file
		private ЗаказTableAdapter OrderTableAdapter => заказTableAdapter;

		private void OrderAddingForm_Load(object sender, EventArgs e)
		{
			OrderTableAdapter.Fill(заказыDataSet.Заказ);

			receiptDateTimePicker.Value = _currentOrder.Дата_приема;
			customerPhoneTextBox.Text = _currentOrder.Телефон_заказчика;
			completionDateTimePicker.Value = _currentOrder.Дата_время_выполнения;
			cutomerNameTextBox.Text = _currentOrder.Имя_заказчика;
			customerAddressTextBox.Text = _currentOrder.Адрес_доставки;
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			if (TextBoxesIsFilled() == false)
			{
				return;
			}

			var currentOrder = IsNewOrder ? InsertOrder() : UpdateOrder();

			var form = new OrderFillingForm(currentOrder.ID_заказа);
			Close();
			form.ShowDialog();
		}

		private OrderRow InsertOrder()
		{
			OrderTableAdapter.InsertQuery
			(
				Дата_приема: receiptDateTimePicker.Value,
				Имя_заказчика: cutomerNameTextBox.Text,
				Телефон_заказчика: customerPhoneTextBox.Text,
				Дата_время_выполнения: completionDateTimePicker.Value,
				Адрес_доставки: customerAddressTextBox.Text
			);
			var currentOrder = OrderTableAdapter.GetData().Last();
			return currentOrder;
		}

		private OrderRow UpdateOrder()
		{
			_currentOrder.Дата_приема = receiptDateTimePicker.Value;
			_currentOrder.Телефон_заказчика = customerPhoneTextBox.Text;
			_currentOrder.Дата_время_выполнения = completionDateTimePicker.Value;
			_currentOrder.Имя_заказчика = cutomerNameTextBox.Text;
			_currentOrder.Адрес_доставки = customerAddressTextBox.Text;

			OrderTableAdapter.Update(_currentOrder);
			return _currentOrder;
		}

		private bool TextBoxesIsFilled()
		{
			if (string.IsNullOrEmpty(cutomerNameTextBox.Text))
			{
				MessageBoxUtils.ShowError("Вы не ввели Имя заказчика");
				return false;
			}

			if (string.IsNullOrEmpty(customerPhoneTextBox.Text))
			{
				MessageBoxUtils.ShowError("Вы не ввели Телефон заказчика");
				return false;
			}

			return true;
		}

		private void customerPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			var number = e.KeyChar;

			if (!char.IsDigit(number)
			    && number != 8
			    && number != 43)
			{
				e.Handled = true;
			}
		}

		private void CustomerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != '\b')
			{
				AllowOnlyLetters(e);
			}
		}

		private static void AllowOnlyLetters(KeyPressEventArgs e) => e.Handled = !char.IsLetter(e.KeyChar);

		private void CancelButton_Click(object sender, EventArgs e) => Close();
	}
}