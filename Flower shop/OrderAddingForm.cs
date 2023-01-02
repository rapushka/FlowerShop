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
	}
}