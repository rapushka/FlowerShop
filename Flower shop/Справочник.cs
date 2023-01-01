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
    public partial class Справочник : Form
    {
        public Справочник()
        {
            InitializeComponent();
        }
        
        private void Справочник_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Страна_производитель". При необходимости она может быть перемещена или удалена.
            this.страна_производительTableAdapter.Fill(this.заказыDataSet.Страна_производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Вид_цветов". При необходимости она может быть перемещена или удалена.
            this.вид_цветовTableAdapter.Fill(this.заказыDataSet.Вид_цветов);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Добавление_страны f = new Добавление_страны();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pb_Dod_Cvety_Click(object sender, EventArgs e)
        {
            Добавление_вида f = new Добавление_вида();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Каталог_аксессуаров f = new Каталог_аксессуаров();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Заказ f = new Заказ();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            видцветовBindingSource.Filter = string.Format("Наименование Like '{0}%'", textBox1.Text);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          странапроизводительBindingSource.Filter = string.Format("Наименование Like '{0}%'", textBox2.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Katalog_Cvetov f = new Katalog_Cvetov();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       
        private void pb_izm_strany_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView2.CurrentRow.Cells[1];
            string country = cell.Value.ToString();
            Изменение_страны f = new Изменение_страны(country);

            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pb_izm_vid_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentRow.Cells[1];
            string vid = cell.Value.ToString();
            Изменение_вида f = new Изменение_вида(vid);

            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pb_udal_vid_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                вид_цветовTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
                dataGridView1.DataSource = вид_цветовTableAdapter.GetData();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
            }
        }

        private void pb_udal_strany_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                страна_производительTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView2[0, dataGridView2.CurrentRow.Index].Value));
                dataGridView2.DataSource = страна_производительTableAdapter.GetData();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
            }
            
        }
    }
}
