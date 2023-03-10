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
    public partial class Изменение_вида : Form
    {
       string old_vid;
        public Изменение_вида(string vid)
        {
            InitializeComponent();

            наименованиеTextBox.Text = vid;
            old_vid = vid;
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
            OleDbCommand oleDbCommand = new OleDbCommand($"Select Вид_цветов.[ID_вида_цветов] from Вид_цветов where (((Вид_цветов.[Наименование]) Like '{old_vid}'))", cnn);

            var reader = oleDbCommand.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();

            oleDbCommand.Dispose();
            cnn.Close();

            if (наименованиеTextBox.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            вид_цветовTableAdapter.UpdateQuery(наименованиеTextBox.Text, id);
            Справочник f = new Справочник();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Справочник f = new Справочник();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void вид_цветовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вид_цветовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.заказыDataSet);

        }

        private void Изменение_вида_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Вид_цветов". При необходимости она может быть перемещена или удалена.
            this.вид_цветовTableAdapter.Fill(this.заказыDataSet.Вид_цветов);

        }

        private void наименованиеTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b')) return;
            //Разрешаем только буквы
            e.Handled = !char.IsLetter(e.KeyChar);
        }
    }
}
