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
            var form = new OrderForm();
            Close();
            form.ShowDialog();
            Show();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            var receiptDate = Convert.ToDateTime(receiptDateTimePicker.Value.ToString("d"));
            var completionDate = Convert.ToDateTime(completionDateTimePicker.Value.ToString("d"));
            заказTableAdapter.InsertQuery(receiptDate, tb_name_zak.Text, tb_number_zak.Text, completionDate, tb_address.Text);
            var form = new OrderFillingForm();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void Add_Zakaz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "заказыDataSet.OrderForm". При необходимости она может быть перемещена или удалена.
            заказTableAdapter.Fill(this.заказыDataSet.Заказ);

        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            заказBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.заказыDataSet);

        }
    }
}
