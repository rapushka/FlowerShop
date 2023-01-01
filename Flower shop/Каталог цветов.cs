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
    public partial class Katalog_Cvetov : Form
    {
        public Katalog_Cvetov()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Справочник f = new Справочник();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pb_Dod_Cvety_Click(object sender, EventArgs e)
        {
            Добавление_цветов f = new Добавление_цветов();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

 

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OrderForm f = new OrderForm();
            this.Close();
            f.ShowDialog();
            this.Show();
        }

        
        private void pb_Kat_Aks_Click(object sender, EventArgs e)
        {
            Каталог_аксессуаров f = new Каталог_аксессуаров();
            this.Close();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Katalog_Cvetov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Страна_производитель". При необходимости она может быть перемещена или удалена.
            this.страна_производительTableAdapter.Fill(this.заказыDataSet.Страна_производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Вид_цветов". При необходимости она может быть перемещена или удалена.
            this.вид_цветовTableAdapter.Fill(this.заказыDataSet.Вид_цветов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_цветов". При необходимости она может быть перемещена или удалена.
            this.каталог_цветовTableAdapter.Fill(this.заказыDataSet.Каталог_цветов);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pb_Udal_Zakaz_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                каталог_цветовTableAdapter.DeleteQuery(Convert.ToInt32(DataGrid_Katalog_Cvetov[0, DataGrid_Katalog_Cvetov.CurrentRow.Index].Value));
                DataGrid_Katalog_Cvetov.DataSource = каталог_цветовTableAdapter.GetData();
            }
            else
            {

                this.Hide();
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Каталог_аксессуаров f = new Каталог_аксессуаров();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OrderForm f = new OrderForm();
            this.Hide();
            f.ShowDialog();
        }

        private void pb_izm_zakaz_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell1 = DataGrid_Katalog_Cvetov.CurrentRow.Cells[1];
            string name = cell1.Value.ToString();

            DataGridViewCell cell2 = DataGrid_Katalog_Cvetov.CurrentRow.Cells[2];
            string type = cell2.Value.ToString();

            DataGridViewCell cell3 = DataGrid_Katalog_Cvetov.CurrentRow.Cells[3];
            string country = cell3.Value.ToString();

            DataGridViewCell cell4 = DataGrid_Katalog_Cvetov.CurrentRow.Cells[4];
            string price = cell4.Value.ToString();

            Изменение_цветов f = new Изменение_цветов(name, type, country, price);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            каталогцветовBindingSource.Filter = string.Format("Наименование Like '{0}%'", tb_name.Text);
        }


        private void tb_price_TextChanged(object sender, EventArgs e)
        {

            каталогцветовBindingSource.Filter ="Convert(Цена,'System.String') Like '" + tb_price.Text+"%'";
        }

        private void DataGrid_Katalog_Cvetov_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
