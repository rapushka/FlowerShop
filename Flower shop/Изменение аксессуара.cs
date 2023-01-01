using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_shop
{
    public partial class Изменение_аксессуара : Form
    {
        string old_name;

        public Изменение_аксессуара(string name, string color, string price)
        {
            InitializeComponent();

            наименованиеTextBox.Text = name;
            цветtextBox.Text = color;
            ценаtextBox.Text = price;

            old_name = name;
                   
        }

        private void Изменение_аксессуара_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_аксессуаров". При необходимости она может быть перемещена или удалена.
            this.каталог_аксессуаровTableAdapter.Fill(this.заказыDataSet.Каталог_аксессуаров);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           string name = наименованиеTextBox.Text;
           string price = цветtextBox.Text;

            if (name == string.Empty)
            {
                MessageBox.Show("Вы не ввели Наименование",
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

            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Заказы.accdb");
                cnn.Open();
                OleDbCommand oleDbCommand = new OleDbCommand($"Select Каталог_аксессуаров.[ID_аксессуара] from Каталог_аксессуаров where (((Каталог_аксессуаров.[Наименование]) Like '{old_name}' ))", cnn);

                var reader = oleDbCommand.ExecuteReader();
                int id = 0;
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();

                oleDbCommand.Dispose();
                cnn.Close();
                каталог_аксессуаровTableAdapter.UpdateQuery(наименованиеTextBox.Text, Convert.ToDecimal(цветtextBox.Text), ценаtextBox.Text, id);

            Каталог_аксессуаров f = new Каталог_аксессуаров();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void каталог_аксессуаровBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_аксессуаровBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.заказыDataSet);

        }

        private void цветtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Справочник f = new Справочник();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void цветtextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ценаtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            //Разрешаем только буквы
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Каталог_аксессуаров f = new Каталог_аксессуаров();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
