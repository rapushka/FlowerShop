using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Flower_shop
{
	public partial class OrderFillingForm : Form
	{
		private readonly int _orderId;

		public OrderFillingForm(int orderId)
		{
			_orderId = orderId;

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

			AddAccessory();
		}

		private void AddAccessory()
		{
			var accessory = заказыDataSet.Аксессуары_в_заказе.NewАксессуары_в_заказеRow();
			accessory.Количество = 13;
			accessory.Каталог_аксессуаровRow = заказыDataSet.Каталог_аксессуаров.Last();

			var list = new List<ЗаказыDataSet.Аксессуары_в_заказеRow>();

			var bindingList = new BindingList<ЗаказыDataSet.Аксессуары_в_заказеRow>(list);
			var source = new BindingSource(bindingList, dataMember: null);
			dataGrid_Aks_v_zak.DataSource = source;

			bindingList.Add(accessory);
		}

		private void InsertAccessoryInOrder(ЗаказыDataSet.Аксессуары_в_заказеRow accessory)
			=> аксессуары_в_заказеTableAdapter.Insert
			(
				accessory.Количество,
				_orderId,
				accessory.Каталог_аксессуаровRow.ID_аксессуара
			);

		private void pb_Udal_Aks_Click(object sender, EventArgs e) { }

		private void pb_Dob_Kat_Aks_Click(object sender, EventArgs e) { }
	}
}