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
    public partial class Svodka_dan : Form
    {
        public Svodka_dan()
        {
            InitializeComponent();
        }

        private void pb_Vernyt_Click(object sender, EventArgs e)
        {
            Napoln_Zakaz f = new Napoln_Zakaz();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pb_Dalee_Click(object sender, EventArgs e)
        {
            Заказ f = new Заказ();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Svodka_dan_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_цветов". При необходимости она может быть перемещена или удалена.
            this.каталог_цветовTableAdapter.Fill(this.заказыDataSet.Каталог_цветов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_аксессуаров". При необходимости она может быть перемещена или удалена.
            this.каталог_аксессуаровTableAdapter.Fill(this.заказыDataSet.Каталог_аксессуаров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Цветы_в_заказе". При необходимости она может быть перемещена или удалена.
            this.цветы_в_заказеTableAdapter.Fill(this.заказыDataSet.Цветы_в_заказе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Аксессуары_в_заказе". При необходимости она может быть перемещена или удалена.
            this.аксессуары_в_заказеTableAdapter.Fill(this.заказыDataSet.Аксессуары_в_заказе);

        }
    }
}
