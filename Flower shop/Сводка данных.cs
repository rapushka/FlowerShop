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
	public partial class DataSummaryForm : Form
	{
		private int _orderId;

		public DataSummaryForm(int orderId)
		{
			_orderId = orderId;

			InitializeComponent();
		}

		private void pb_Dalee_Click(object sender, EventArgs e)
		{
			Close();
			return;

			var form = new Заказ();
			Hide();
			form.ShowDialog();
			Show();
		}

		private void Svodka_dan_Load(object sender, EventArgs e)
		{
			каталог_цветовTableAdapter.Fill(заказыDataSet.Каталог_цветов);
			каталог_аксессуаровTableAdapter.Fill(заказыDataSet.Каталог_аксессуаров);
			цветы_в_заказеTableAdapter.Fill(заказыDataSet.Цветы_в_заказе);
			аксессуары_в_заказеTableAdapter.Fill(заказыDataSet.Аксессуары_в_заказе);
		}
	}
}