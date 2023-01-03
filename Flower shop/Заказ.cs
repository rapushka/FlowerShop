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
			OrderAddingForm f = new OrderAddingForm();
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

		private void pb_Dod_Cvety_Click(object sender, EventArgs e)
		{
			OrderAddingForm f = new OrderAddingForm();
			Hide();
			f.ShowDialog();

			FillTables();
			Show();
		}

		private void pb_izm_zakaz_Click(object sender, EventArgs e)
		{
			Изменение_заказа f = new Изменение_заказа();
			Hide();
			f.ShowDialog();
			Show();
		}
	}
}