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
    public partial class Добавление_цветов : Form
    {
        public Добавление_цветов()
        {
            InitializeComponent();
        }

        private void Добавление_цветов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_цветов". При необходимости она может быть перемещена или удалена.
            this.каталог_цветовTableAdapter.Fill(this.заказыDataSet.Каталог_цветов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Вид_цветов". При необходимости она может быть перемещена или удалена.
            this.вид_цветовTableAdapter.Fill(this.заказыDataSet.Вид_цветов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Страна_производитель". При необходимости она может быть перемещена или удалена.
            this.страна_производительTableAdapter.Fill(this.заказыDataSet.Страна_производитель);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string country = comboBox1.Text;
            string type = comboBox2.Text;
            string price = textBox4.Text;

            if (name == string.Empty)
            {
                MessageBox.Show("Вы не ввели Наименование",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                return;
            }


            if (country == string.Empty)
            {
                MessageBox.Show("Вы не выбрали страну",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                return;
            }


            if (type == string.Empty)
            {
                MessageBox.Show("Вы не выбрали Вид цветов",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                return;
            }

            if (price == string.Empty)
            {
                MessageBox.Show("Вы не ввели Цену",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                return;
            }

            каталог_цветовTableAdapter.InsertQuery(textBox1.Text, Convert.ToDecimal(textBox4.Text), Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));

            Katalog_Cvetov f = new Katalog_Cvetov();

            f.DataGrid_Katalog_Cvetov.DataSource = каталог_цветовTableAdapter.GetData();

            this.Close();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Добавление_страны f = new Добавление_страны();
            this.Close();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Добавление_вида f = new Добавление_вида();
            this.Close();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Katalog_Cvetov f = new Katalog_Cvetov();
            this.Close();
            f.ShowDialog();
            this.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            //Разрешаем только буквы
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var tb = (TextBox)sender;
            if (e.KeyChar.Equals(','))
            {
                e.Handled = tb.SelectionStart == 0 || tb.Text.IndexOf(",") != -1;
                if (!e.Handled)
                {
                    return;
                }
            }

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }
    }
}
