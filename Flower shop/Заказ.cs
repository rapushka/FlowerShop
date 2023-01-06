using System;
using System.Windows.Forms;

namespace Flower_shop
{
	public partial class Заказ : Form
	{
		public Заказ()
		{
			InitializeComponent();
		}

		private void pb_Dod_Zakaz_Click(object sender, EventArgs e)
		{
			OrderEditForm f = new OrderEditForm();
			Hide();
			f.ShowDialog();
			Show();
		}

		private void pb_Kat_Cvetov_Click(object sender, EventArgs e)
		{
			Katalog_Cvetov f = new Katalog_Cvetov();
			Hide();
			f.ShowDialog();
			Show();
		}

		private void pb_Kat_Aks_Click(object sender, EventArgs e)
		{
			Каталог_аксессуаров f = new Каталог_аксессуаров();
			Hide();
			f.ShowDialog();
			Show();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Заказ_Load(object sender, EventArgs e)
		{
			FillTables();
		}

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

		private void EditOrderButton_Click(object sender, EventArgs e) => EditOrder(isNewOrder: false);

		private void EditOrder(bool isNewOrder = true)
		{
			var form = new OrderEditForm(isNewOrder);
			Hide();
			form.ShowDialog();

			FillTables();
			Show();
		}

		private void pb_Udal_Zakaz_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				заказTableAdapter.DeleteQuery(Convert.ToInt32(DataGrid_Zakaz[0, DataGrid_Zakaz.CurrentRow.Index].Value));
				DataGrid_Zakaz.DataSource = заказTableAdapter.GetData();
			}
			else
			{

				this.Hide();
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			DateTime data = Convert.ToDateTime(dateTimePicker1.Value.ToString("d"));
			DateTime data1 = Convert.ToDateTime(dateTimePicker2.Value.ToString("d"));

			if (checkBox1.Checked == true)
			{
				if (dateTimePicker1.Value > dateTimePicker2.Value)
				{
					MessageBox.Show("Начало периода не может быть позже его конца","Сообщение",
	                MessageBoxButtons.OK,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1);
					checkBox1.Checked = false;
					return;
				}
				DataGrid_Zakaz.DataSource = заказTableAdapter.GetDataBy4(data, data1);
			}
			else { DataGrid_Zakaz.DataSource = заказTableAdapter.GetData(); }
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			DateTime data = Convert.ToDateTime(dateTimePicker4.Value.ToString("d"));
			DateTime data1 = Convert.ToDateTime(dateTimePicker3.Value.ToString("d"));

			if (checkBox2.Checked == true)
			{
				if (dateTimePicker4.Value > dateTimePicker3.Value)
				{
					MessageBox.Show("Начало периода не может быть позже его конца", "Сообщение",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information,
					MessageBoxDefaultButton.Button1);
					checkBox2.Checked = false;
					return;
				}
				DataGrid_Zakaz.DataSource = заказTableAdapter.GetDataBy2(data, data1);
			}
			else { DataGrid_Zakaz.DataSource = заказTableAdapter.GetData(); }
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox3.Checked == true)
			{
				DataGrid_Zakaz.DataSource = заказTableAdapter.GetDataBy_Done();
			}
			else
			{
				DataGrid_Zakaz.DataSource = заказTableAdapter.GetData();
			}
		}

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox4.Checked == true)
			{
				DataGrid_Zakaz.DataSource = заказTableAdapter.GetDataBy__Not_ready();
			}
			else
			{
				DataGrid_Zakaz.DataSource = заказTableAdapter.GetData();
			}
		}
    }
}