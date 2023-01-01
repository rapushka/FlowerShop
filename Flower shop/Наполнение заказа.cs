using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_shop
{
    public partial class Napoln_Zakaz : Form
    {
        private SqlConnection sqlConnection = null;

        SqlDataAdapter adapter = null;

        private DataTable table = null;
        int sum = 0;
        public Napoln_Zakaz()
        {
            InitializeComponent();
        }

        private void pb_Dalee_Click(object sender, EventArgs e)
        {
            Svodka_dan f = new Svodka_dan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pb_Vernyt_Click(object sender, EventArgs e)
        {
            Add_Zakaz f = new Add_Zakaz();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Napoln_Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Вид_цветов". При необходимости она может быть перемещена или удалена.
            this.вид_цветовTableAdapter.Fill(this.заказыDataSet.Вид_цветов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Цветы_в_заказе". При необходимости она может быть перемещена или удалена.


            this.цветы_в_заказеTableAdapter.Fill(this.заказыDataSet.Цветы_в_заказе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Аксессуары_в_заказе". При необходимости она может быть перемещена или удалена.



           
                // Необходио загружаtь данные иz таблицы запросом select * from [имя_талицы] where ID_Заказа = [ID_ткещего заказа]


            this.аксессуары_в_заказеTableAdapter.Fill(this.заказыDataSet.Аксессуары_в_заказе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_цветов". При необходимости она может быть перемещена или удалена.
            this.каталог_цветовTableAdapter.Fill(this.заказыDataSet.Каталог_цветов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Каталог_аксессуаров". При необходимости она может быть перемещена или удалена.
            this.каталог_аксессуаровTableAdapter.Fill(this.заказыDataSet.Каталог_аксессуаров);

        }

        private void pb_Udal_Aks_Click(object sender, EventArgs e)
        {
            
        }

        private void pb_Dob_Kat_Aks_Click(object sender, EventArgs e)
        {
            int price = 0;





            sum += price;
        }
    }
}
