using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_shop
{
	public partial class Add_Zakaz : Form
	{
		public Add_Zakaz() => InitializeComponent();

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
				Имя_заказчика: tb_name_zak.Text,
				Телефон_заказчика: tb_number_zak.Text,
				Дата_время_выполнения: receiptDateTimePicker.Value,
				Адрес_доставки: tb_address.Text
			);
			var f = new OrderFillingForm();
			Hide();
			f.ShowDialog();
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