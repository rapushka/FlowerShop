using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_shop
{
	public partial class OrderFillingForm : Form
	{
		private SqlConnection _sqlConnection = null;

		private SqlDataAdapter _adapter = null;

		private DataTable _table = null;
		int sum = 0;

		public OrderFillingForm()
		{
			InitializeComponent();
		}

		private void pb_Dalee_Click(object sender, EventArgs e)
		{
			var f = new Svodka_dan();
			Hide();
			f.ShowDialog();
			Show();
		}

		private void pb_Vernyt_Click(object sender, EventArgs e)
		{
			var f = new Add_Zakaz();
			Hide();
			f.ShowDialog();
			Show();
		}

		private void Napoln_Zakaz_Load(object sender, EventArgs e)
		{
			вид_цветовTableAdapter.Fill(заказыDataSet.Вид_цветов);
			цветы_в_заказеTableAdapter.Fill(заказыDataSet.Цветы_в_заказе);
			
			// Необходио загружать данные из таблицы запросом select * from [имя_талицы] where ID_Заказа = [ID_ткещего заказа]

			аксессуары_в_заказеTableAdapter.Fill(заказыDataSet.Аксессуары_в_заказе);
			каталог_цветовTableAdapter.Fill(заказыDataSet.Каталог_цветов);
			каталог_аксессуаровTableAdapter.Fill(заказыDataSet.Каталог_аксессуаров);
		}

		private void pb_Udal_Aks_Click(object sender, EventArgs e) { }

		private void pb_Dob_Kat_Aks_Click(object sender, EventArgs e) { }
	}
}