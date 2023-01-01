using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Flower_shop
{
    public partial class Изменение_страны : Form
    {
        string old_country;
        public Изменение_страны(string country)
        {
            InitializeComponent();

            наименованиеTextBox.Text = country;
            old_country = country;
        }

        private void страна_производительBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.страна_производительBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.заказыDataSet);

        }

        private void Изменение_страны_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Страна_производитель". При необходимости она может быть перемещена или удалена.
            this.страна_производительTableAdapter.Fill(this.заказыDataSet.Страна_производитель);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Справочник f = new Справочник();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string name = наименованиеTextBox.Text;

            if (name == string.Empty)
            {
                MessageBox.Show("Вы не ввели Наименование",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                return;
            }

            OleDbConnection cnn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Заказы.accdb");
                cnn.Open();
                OleDbCommand oleDbCommand = new OleDbCommand($"Select Страна_производитель.[ID_страны_производителя] from Страна_производитель where (((Страна_производитель.[Наименование]) Like '{old_country}'))", cnn);

                //SqlDataAdapter sda = new SqlDataAdapter();

                var reader = oleDbCommand.ExecuteReader();
                int id = 0;
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();

                oleDbCommand.Dispose();
                cnn.Close();
                страна_производительTableAdapter.UpdateQuery(наименованиеTextBox.Text, id);
             

                if (наименованиеTextBox.Text == "")
                {
                    MessageBox.Show("Вы не заполнили поле", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            Справочник f = new Справочник();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void наименованиеTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            //Разрешаем только буквы
            e.Handled = !char.IsLetter(e.KeyChar);
        }
    }
}
