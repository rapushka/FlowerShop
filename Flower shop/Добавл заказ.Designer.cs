
namespace Flower_shop
{
    partial class Add_Zakaz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Zakaz));
            this.ButtonNext = new System.Windows.Forms.PictureBox();
            this.tb_name_zak = new System.Windows.Forms.TextBox();
            this.tb_number_zak = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.receiptDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.completionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.заказыDataSet = new Flower_shop.ЗаказыDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new Flower_shop.ЗаказыDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonNext.BackgroundImage")));
            this.ButtonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNext.Location = new System.Drawing.Point(468, 324);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(94, 28);
            this.ButtonNext.TabIndex = 1;
            this.ButtonNext.TabStop = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // tb_name_zak
            // 
            this.tb_name_zak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name_zak.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_name_zak.Location = new System.Drawing.Point(344, 87);
            this.tb_name_zak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name_zak.Name = "tb_name_zak";
            this.tb_name_zak.Size = new System.Drawing.Size(192, 26);
            this.tb_name_zak.TabIndex = 2;
            // 
            // tb_number_zak
            // 
            this.tb_number_zak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_number_zak.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_number_zak.Location = new System.Drawing.Point(344, 128);
            this.tb_number_zak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_number_zak.Name = "tb_number_zak";
            this.tb_number_zak.Size = new System.Drawing.Size(192, 26);
            this.tb_number_zak.TabIndex = 3;
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_address.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_address.Location = new System.Drawing.Point(344, 170);
            this.tb_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(192, 26);
            this.tb_address.TabIndex = 4;
            // 
            // receiptDateTimePicker
            // 
            this.receiptDateTimePicker.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.receiptDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.receiptDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptDateTimePicker.Location = new System.Drawing.Point(344, 230);
            this.receiptDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receiptDateTimePicker.Name = "receiptDateTimePicker";
            this.receiptDateTimePicker.Size = new System.Drawing.Size(192, 26);
            this.receiptDateTimePicker.TabIndex = 6;
            // 
            // completionDateTimePicker
            // 
            this.completionDateTimePicker.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.completionDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.completionDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completionDateTimePicker.Location = new System.Drawing.Point(344, 273);
            this.completionDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.completionDateTimePicker.Name = "completionDateTimePicker";
            this.completionDateTimePicker.Size = new System.Drawing.Size(192, 26);
            this.completionDateTimePicker.TabIndex = 7;
            // 
            // заказыDataSet
            // 
            this.заказыDataSet.DataSetName = "ЗаказыDataSet";
            this.заказыDataSet.Namespace = "http://tempuri.org/ЗаказыDataSet.xsd";
            this.заказыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.заказыDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Flower_shop.ЗаказыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аксессуары_в_заказеTableAdapter = null;
            this.tableAdapterManager.Вид_цветовTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.Каталог_аксессуаровTableAdapter = null;
            this.tableAdapterManager.Каталог_цветовTableAdapter = null;
            this.tableAdapterManager.Страна_производительTableAdapter = null;
            this.tableAdapterManager.Цветы_в_заказеTableAdapter = null;
            // 
            // Add_Zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 373);
            this.Controls.Add(this.completionDateTimePicker);
            this.Controls.Add(this.receiptDateTimePicker);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_number_zak);
            this.Controls.Add(this.tb_name_zak);
            this.Controls.Add(this.ButtonNext);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Add_Zakaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Zakaz";
            this.Load += new System.EventHandler(this.Add_Zakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox ButtonNext;
        private System.Windows.Forms.TextBox tb_name_zak;
        private System.Windows.Forms.TextBox tb_number_zak;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.DateTimePicker receiptDateTimePicker;
        private System.Windows.Forms.DateTimePicker completionDateTimePicker;
        private ЗаказыDataSet заказыDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private ЗаказыDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private ЗаказыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}