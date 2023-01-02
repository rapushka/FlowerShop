using System;
using System.Linq;
using System.Windows.Forms;
using OrderRow = Flower_shop.ЗаказыDataSet.ЗаказRow;

namespace Flower_shop
{
	public partial class DataSummaryForm : Form
	{
		private readonly int _orderId;
		private readonly decimal _sum;
		
		private OrderRow _currentOrder;

		public DataSummaryForm(int orderId, decimal sum)
		{
			_orderId = orderId;
			_sum = sum;

			InitializeComponent();
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void DataSummaryForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'заказыDataSet.Заказ' table. You can move, or remove it, as needed.
			this.заказTableAdapter.Fill(this.заказыDataSet.Заказ);
			// TODO: This line of code loads data into the 'заказыDataSet.Заказ' table. You can move, or remove it, as needed.
			this.заказTableAdapter.Fill(this.заказыDataSet.Заказ);
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

			MessageBox.Show(_currentOrder.Имя_заказчика);
		}
	}
}