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
    public partial class Изменение_заказа : Form
    {
        public Изменение_заказа()
        {
            InitializeComponent();
        }

        private void Изменение_заказа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Цветы_в_заказе". При необходимости она может быть перемещена или удалена.
            this.цветы_в_заказеTableAdapter.Fill(this.заказыDataSet.Цветы_в_заказе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Аксессуары_в_заказе". При необходимости она может быть перемещена или удалена.
            this.аксессуары_в_заказеTableAdapter.Fill(this.заказыDataSet.Аксессуары_в_заказе);

        }
    }
}
