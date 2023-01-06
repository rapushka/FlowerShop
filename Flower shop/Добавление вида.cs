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
    public partial class Добавление_вида : Form
    {
        public Добавление_вида()
        {
            InitializeComponent();
        }

        private void Добавление_вида_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if(name==String.Empty)
            {
                MessageBox.Show("Вы не ввели Наименование",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                return;
            }

            вид_цветовTableAdapter.InsertQuery(textBox1.Text);

            Справочник f = new Справочник();
            f.dataGridView1.DataSource = вид_цветовTableAdapter.GetData();
            Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            //Разрешаем только буквы
            e.Handled = !char.IsLetter(e.KeyChar);
        }
    }
}
