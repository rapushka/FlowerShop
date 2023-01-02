using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
			var f = new OrderAddingForm();
			Hide();
			f.ShowDialog();
			Show();
		}

		private void Napoln_Zakaz_Load(object sender, EventArgs e)
		{
			вид_цветовTableAdapter.Fill(заказыDataSet.Вид_цветов);
			цветы_в_заказеTableAdapter.Fill(заказыDataSet.Цветы_в_заказе);
			аксессуары_в_заказеTableAdapter.Fill(заказыDataSet.Аксессуары_в_заказе);
			каталог_цветовTableAdapter.Fill(заказыDataSet.Каталог_цветов);
			каталог_аксессуаровTableAdapter.Fill(заказыDataSet.Каталог_аксессуаров);

			// Необходио загружать данные из таблицы запросом select * from [имя_талицы] where ID_Заказа = [ID_ткещего заказа]
			var accessories = заказыDataSet.Каталог_аксессуаров.ToList();
			var accessory = заказыDataSet.Аксессуары_в_заказе.NewАксессуары_в_заказеRow();
			accessory.Количество = 13;
			accessory.ЗаказRow = заказыDataSet.Заказ.NewЗаказRow();
			accessory.Каталог_аксессуаровRow = заказыDataSet.Каталог_аксессуаров.First();
			
			var list = new List<ЗаказыDataSet.Аксессуары_в_заказеRow>();

			var bindingList = new BindingList<ЗаказыDataSet.Аксессуары_в_заказеRow>(list);
			var source = new BindingSource(bindingList, dataMember: null);
			dataGrid_Aks_v_zak.DataSource = source;

			аксессуары_в_заказеTableAdapter.Insert(accessory.Количество, 1, accessory.Каталог_аксессуаровRow.ID_аксессуара);
		}

		private void pb_Udal_Aks_Click(object sender, EventArgs e) { }

		private void pb_Dob_Kat_Aks_Click(object sender, EventArgs e) { }
	}
}