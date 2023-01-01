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
    public partial class Добавл_аксессуар : Form
    {
        public Добавл_аксессуар()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            каталог_аксессуаровTableAdapter.InsertQuery(textBox1.Text, Convert.ToDecimal(textBox2.Text), textBox3.Text);
            
            Каталог_аксессуаров f = new Каталог_аксессуаров();

            f.dataGridView1.DataSource = каталог_аксессуаровTableAdapter.GetData();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Каталог_аксессуаров f = new Каталог_аксессуаров();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Добавл_аксессуар_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            //Разрешаем только буквы
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
