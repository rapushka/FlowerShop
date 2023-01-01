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
    public partial class Изменение_цветов : Form
    {
        string old_name;
        public Изменение_цветов(string name, string type,string country, string price)
        {

            InitializeComponent();

            textBox1.Text = name;
            comboBox1.Text = country;
            comboBox2.Text = type;
            textBox4.Text = price;

            old_name = name;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string  name = textBox1.Text;
            string country =comboBox1.Text;
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

            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Заказы.accdb");
            cnn.Open();
            OleDbCommand oleDbCommand = new OleDbCommand($"SELECT Каталог_цветов.[ID_цветов] FROM Каталог_цветов WHERE (((Каталог_цветов.[Наименование]) LIKE '{old_name}' ))", cnn);

            var reader = oleDbCommand.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();

            oleDbCommand.Dispose();
            cnn.Close();
           каталог_цветовTableAdapter.UpdateQuery(textBox1.Text, Convert.ToDecimal(textBox4.Text), Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), id);
          
            Katalog_Cvetov f = new Katalog_Cvetov();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void каталог_цветовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.каталог_цветовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.заказыDataSet);

        }

        private void Изменение_цветов_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet1.Каталог_цветов". При необходимости она может быть перемещена или удалена.
            this.каталог_цветовTableAdapter.Fill(this.заказыDataSet1.Каталог_цветов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Цветы_в_заказе". При необходимости она может быть перемещена или удалена.
            this.цветы_в_заказеTableAdapter.Fill(this.заказыDataSet.Цветы_в_заказе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet1.Вид_цветов". При необходимости она может быть перемещена или удалена.
            this.вид_цветовTableAdapter.Fill(this.заказыDataSet1.Вид_цветов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet1.Страна_производитель". При необходимости она может быть перемещена или удалена.
            this.страна_производительTableAdapter.Fill(this.заказыDataSet1.Страна_производитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_цветов". При необходимости она может быть перемещена или удалена.
            this.каталог_цветовTableAdapter.Fill(this.заказыDataSet.Каталог_цветов);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            //Разрешаем только буквы
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
