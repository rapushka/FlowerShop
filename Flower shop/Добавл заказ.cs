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
    public partial class Add_Zakaz : Form
    {
        public Add_Zakaz()
        {
            InitializeComponent();
        }

        private void pb_Vernyt_Click(object sender, EventArgs e)
        {
            Заказ f = new Заказ();
            this.Close();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime(dateTimePicker1.Value.ToString("d"));
            DateTime data2 = Convert.ToDateTime(dateTimePicker2.Value.ToString("d"));
            заказTableAdapter.InsertQuery(data, tb_name_zak.Text, tb_number_zak.Text, data2, tb_address.Text);
            Napoln_Zakaz f = new Napoln_Zakaz();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Add_Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.заказыDataSet.Заказ);

        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.заказыDataSet);

        }
    }
}
