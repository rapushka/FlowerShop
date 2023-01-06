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
			if (string.IsNullOrEmpty(cutomerNameTextBox.Text))
            {
				MessageBox.Show("Вы не ввели Имя заказчика",
				  "Сообщение",
				  MessageBoxButtons.OK,
				  MessageBoxIcon.Information,
				  MessageBoxDefaultButton.Button1);
				return;
            }

			if (string.IsNullOrEmpty(customerPhoneTextBox.Text))
			{
				
					MessageBox.Show("Вы не ввели Телефон заказчика",
					  "Сообщение",
					  MessageBoxButtons.OK,
					  MessageBoxIcon.Information,
					  MessageBoxDefaultButton.Button1);
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

        private void customerPhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

           char number = e.KeyChar;

			if (!Char.IsDigit(number) && number != 8 && number!=43)
			{
				e.Handled = true;
			}
		}

        private void cutomerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (e.KeyChar.Equals('\b')) return;
			//Разрешаем только буквы
			e.Handled = !char.IsLetter(e.KeyChar);
		}

        private void CancelButton_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}