using System;
using System.Windows.Forms;

namespace Flower_shop
{
	public partial class OrderAddingForm : Form
	{
		public OrderAddingForm() => InitializeComponent();

		private void Add_Zakaz_Load(object sender, EventArgs e) => заказTableAdapter.Fill(заказыDataSet.Заказ);

		private void pb_Vernyt_Click(object sender, EventArgs e)
		{
			var f = new Заказ();
			Close();
			f.ShowDialog();
			Show();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			заказTableAdapter.InsertQuery
			(
				Дата_приема: receiptDateTimePicker.Value,
				Имя_заказчика: cutomerNameTextBox.Text,
				Телефон_заказчика: customerPhoneTextBox.Text,
				Дата_время_выполнения: receiptDateTimePicker.Value,
				Адрес_доставки: customerAddressTextBox.Text
			);
			
			var form = new OrderFillingForm();
			Hide();
			form.ShowDialog();
			Show();
		}

		private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			Validate();
			заказBindingSource.EndEdit();
			tableAdapterManager.UpdateAll(заказыDataSet);
		}
	}
}