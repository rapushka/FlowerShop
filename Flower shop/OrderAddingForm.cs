using System;
using System.Linq;
using System.Windows.Forms;

namespace Flower_shop
{
	public partial class OrderAddingForm : Form
	{
		public OrderAddingForm() => InitializeComponent();

		private void OrderAddingForm_Load(object sender, EventArgs e) => заказTableAdapter.Fill(заказыDataSet.Заказ);

		private void NextButton_Click(object sender, EventArgs e)
		{
			if (TextBoxesIsFilled() == false)
			{
				return;
			}

			заказTableAdapter.InsertQuery
			(
				Дата_приема: receiptDateTimePicker.Value,
				Имя_заказчика: cutomerNameTextBox.Text,
				Телефон_заказчика: customerPhoneTextBox.Text,
				Дата_время_выполнения: completionDateTimePicker.Value,
				Адрес_доставки: customerAddressTextBox.Text
			);
			var newOrder = заказTableAdapter.GetData().Last();

			var form = new OrderFillingForm(newOrder.ID_заказа);
			Close();
			form.ShowDialog();
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