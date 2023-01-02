using System;
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

		private void NextButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void DataSummaryForm_Load(object sender, EventArgs e)
		{
			каталог_цветовTableAdapter.Fill(заказыDataSet.Каталог_цветов);
			каталог_аксессуаровTableAdapter.Fill(заказыDataSet.Каталог_аксессуаров);
			цветы_в_заказеTableAdapter.Fill(заказыDataSet.Цветы_в_заказе);
			аксессуары_в_заказеTableAdapter.Fill(заказыDataSet.Аксессуары_в_заказе);
		}
	}
}