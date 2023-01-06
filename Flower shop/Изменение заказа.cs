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
    public partial class Изменение_заказа : Form
    {
        
        public Изменение_заказа()
        {
            InitializeComponent();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Изменение_заказа_Load(object sender, EventArgs e)
        {
           
            заказTableAdapter.Fill(заказыDataSet.Заказ);
            каталог_цветовTableAdapter.Fill(заказыDataSet.Каталог_цветов);
            каталог_аксессуаровTableAdapter.Fill(заказыDataSet.Каталог_аксессуаров);
            цветы_в_заказеTableAdapter.Fill(заказыDataSet.Цветы_в_заказе);
            аксессуары_в_заказеTableAdapter.Fill(заказыDataSet.Аксессуары_в_заказе);


        }


     
    }
}
