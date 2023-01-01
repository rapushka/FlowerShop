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
    public partial class Добавление_страны : Form
    {
        public Добавление_страны()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            страна_производительTableAdapter1.InsertQuery(textBox1.Text);

            Справочник f = new Справочник();

            f.dataGridView2.DataSource = страна_производительTableAdapter1.GetData();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            //Разрешаем только буквы
            e.Handled = !char.IsLetter(e.KeyChar);
        }
    }
}
