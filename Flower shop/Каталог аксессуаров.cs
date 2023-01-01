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
    public partial class Каталог_аксессуаров : Form
    {
        public Каталог_аксессуаров()
        {
            InitializeComponent();
        }

        private void pb_Kat_Aks_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Каталог_аксессуаров_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_аксессуаров". При необходимости она может быть перемещена или удалена.
            this.каталог_аксессуаровTableAdapter.Fill(this.заказыDataSet.Каталог_аксессуаров);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Заказ f = new Заказ();
            this.Close();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Katalog_Cvetov f = new Katalog_Cvetov();
            this.Close();
            f.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            каталогаксессуаровBindingSource.Filter = string.Format("Цвет LIKE '{0}%'", textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            каталогаксессуаровBindingSource.Filter = string.Format("Наименование LIKE '{0}%'", textBox1.Text);
        }

        private void pb_dob_strany_Click(object sender, EventArgs e)
        {
            Добавл_аксессуар f = new Добавл_аксессуар();
            this.Close();
            f.ShowDialog();
        }

        private void pb_izm_strany_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell1 = dataGridView1.CurrentRow.Cells[1];
            string name = cell1.Value.ToString();

            DataGridViewCell cell2 = dataGridView1.CurrentRow.Cells[2];
            string color = cell2.Value.ToString();

            DataGridViewCell cell3 = dataGridView1.CurrentRow.Cells[3];
            string price= cell3.Value.ToString();

            Изменение_аксессуара f = new Изменение_аксессуара(name,color,price);
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void pb_udal_strany_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                каталог_аксессуаровTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
                dataGridView1.DataSource = каталог_аксессуаровTableAdapter.GetData();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
            }
        }
    }
}
