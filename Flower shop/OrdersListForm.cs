using System;
using System.Windows.Forms;
using OrderRow = Flower_shop.ЗаказыDataSet.ЗаказRow;

namespace Flower_shop
{
	public partial class OrdersListForm : Form
	{
		public OrdersListForm() => InitializeComponent();

		private void pictureBox2_Click(object sender, EventArgs e) => Close();

		private void OrderListForm_Load(object sender, EventArgs e) => FillTables();

		private void FillTables()
		{
			вид_цветовTableAdapter.Fill(заказыDataSet.Вид_цветов);
			каталог_цветовTableAdapter.Fill(заказыDataSet.Каталог_цветов);
			каталог_аксессуаровTableAdapter.Fill(заказыDataSet.Каталог_аксессуаров);
			цветы_в_заказеTableAdapter.Fill(заказыDataSet.Цветы_в_заказе);
			аксессуары_в_заказеTableAdapter.Fill(заказыDataSet.Аксессуары_в_заказе);
			заказTableAdapter.Fill(заказыDataSet.Заказ);
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Katalog_Cvetov f = new Katalog_Cvetov();
			Hide();
			f.Show();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Каталог_аксессуаров f = new Каталог_аксессуаров();
			Hide();
			f.ShowDialog();
			Show();
		}

		private void AddOrderButton_Click(object sender, EventArgs e) => EditOrder();

		private void EditOrderButton_Click(object sender, EventArgs e)
		{
			var orderRow = OrdersDataGrid.SelectedOrder(заказTableAdapter);
			EditOrder(orderRow);
		}

		private void EditOrder(OrderRow order = null)
		{
			var form = new OrderPrimaryInformationForm(order);
			Hide();
			form.ShowDialog();

			FillTables();
			Show();
		}

		private void pb_Udal_Zakaz_Click(object sender, EventArgs e)
		{
			var dialogResult = MessageBox.Show
				("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				заказTableAdapter.DeleteQuery
					(Convert.ToInt32(OrdersDataGrid[0, OrdersDataGrid.CurrentRow.Index].Value));
				OrdersDataGrid.DataSource = заказTableAdapter.GetData();
			}
			else
			{
				Hide();
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			var data = Convert.ToDateTime(dateTimePicker1.Value.ToString("d"));
			var data1 = Convert.ToDateTime(dateTimePicker2.Value.ToString("d"));

			if (!checkBox1.Checked)
			{
				OrdersDataGrid.DataSource = заказTableAdapter.GetData();
				return;
			}

			if (dateTimePicker1.Value > dateTimePicker2.Value)
			{
				MessageBoxUtils.ShowError("Начало периода не может быть позже его конца");
				checkBox1.Checked = false;
				return;
			}

			OrdersDataGrid.DataSource = заказTableAdapter.GetDataBy4(data, data1);
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			var data = Convert.ToDateTime(dateTimePicker4.Value.ToString("d"));
			var data1 = Convert.ToDateTime(dateTimePicker3.Value.ToString("d"));

			if (checkBox2.Checked == false)
			{
				OrdersDataGrid.DataSource = заказTableAdapter.GetData();
				return;
			}

			if (dateTimePicker4.Value > dateTimePicker3.Value)
			{
				MessageBoxUtils.ShowError("Начало периода не может быть позже его конца");
				checkBox2.Checked = false;
				return;
			}

			OrdersDataGrid.DataSource = заказTableAdapter.GetDataBy2(data, data1);
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
			=> OrdersDataGrid.DataSource = checkBox3.Checked
				? заказTableAdapter.GetDataBy_Done()
				: заказTableAdapter.GetData();

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
			=> OrdersDataGrid.DataSource = checkBox4.Checked
				? заказTableAdapter.GetDataBy__Not_ready()
				: заказTableAdapter.GetData();
	}
}