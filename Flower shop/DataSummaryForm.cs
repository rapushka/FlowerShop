using System;
using System.Linq;
using System.Windows.Forms;
using OrderRow = Flower_shop.ЗаказыDataSet.ЗаказRow;

namespace Flower_shop
{
	public partial class DataSummaryForm : Form
	{
		private readonly decimal _sum;

		private OrderRow _currentOrder;

		public DataSummaryForm(decimal sum)
		{
			_sum = sum;

			InitializeComponent();
		}

		private void NextButton_Click(object sender, EventArgs e) => Close();

		private void DataSummaryForm_Load(object sender, EventArgs e)
		{
			заказTableAdapter.Fill(заказыDataSet.Заказ);
			каталог_цветовTableAdapter.Fill(заказыDataSet.Каталог_цветов);
			каталог_аксессуаровTableAdapter.Fill(заказыDataSet.Каталог_аксессуаров);
			цветы_в_заказеTableAdapter.Fill(заказыDataSet.Цветы_в_заказе);
			аксессуары_в_заказеTableAdapter.Fill(заказыDataSet.Аксессуары_в_заказе);

			LoadOrder();
		}

		private void LoadOrder()
		{
			_currentOrder = заказTableAdapter.GetData().Last();
			_currentOrder.Стоимость = _sum;

			заказTableAdapter.Update(_currentOrder);
		}
	}
}