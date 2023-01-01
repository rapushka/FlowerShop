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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void pb_Dod_Zakaz_Click(object sender, EventArgs e)
        {
            Add_Zakaz f = new Add_Zakaz();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

      

        private void pb_Kat_Cvetov_Click(object sender, EventArgs e)
        {
            Katalog_Cvetov f = new Katalog_Cvetov();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

     
        private void pb_Kat_Aks_Click(object sender, EventArgs e)
        {
            Каталог_аксессуаров f = new Каталог_аксессуаров();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Заказ_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Вид_цветов". При необходимости она может быть перемещена или удалена.
            this.вид_цветовTableAdapter.Fill(this.заказыDataSet.Вид_цветов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_цветов". При необходимости она может быть перемещена или удалена.
            this.каталог_цветовTableAdapter.Fill(this.заказыDataSet.Каталог_цветов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_аксессуаров". При необходимости она может быть перемещена или удалена.
            this.каталог_аксессуаровTableAdapter.Fill(this.заказыDataSet.Каталог_аксессуаров);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Цветы_в_заказе". При необходимости она может быть перемещена или удалена.
            this.цветы_в_заказеTableAdapter.Fill(this.заказыDataSet.Цветы_в_заказе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Аксессуары_в_заказе". При необходимости она может быть перемещена или удалена.
            this.аксессуары_в_заказеTableAdapter.Fill(this.заказыDataSet.Аксессуары_в_заказе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.OrderForm". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.заказыDataSet.Заказ);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Katalog_Cvetov f = new Katalog_Cvetov();
            this.Hide();
            f.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Каталог_аксессуаров f = new Каталог_аксессуаров();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pb_Dod_Cvety_Click(object sender, EventArgs e)
        {
            Add_Zakaz f = new Add_Zakaz();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pb_izm_zakaz_Click(object sender, EventArgs e)
        {
            Изменение_заказа f = new Изменение_заказа();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
