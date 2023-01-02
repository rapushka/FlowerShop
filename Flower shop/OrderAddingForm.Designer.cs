
namespace Flower_shop
{
    partial class OrderAddingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderAddingForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cutomerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.receiptDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.completionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.заказыDataSet = new Flower_shop.ЗаказыDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new Flower_shop.ЗаказыDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(468, 324);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 28);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cutomerNameTextBox
            // 
            this.cutomerNameTextBox.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cutomerNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cutomerNameTextBox.Location = new System.Drawing.Point(344, 87);
            this.cutomerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cutomerNameTextBox.Name = "cutomerNameTextBox";
            this.cutomerNameTextBox.Size = new System.Drawing.Size(192, 24);
            this.cutomerNameTextBox.TabIndex = 2;
            // 
            // customerPhoneTextBox
            // 
            this.customerPhoneTextBox.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerPhoneTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customerPhoneTextBox.Location = new System.Drawing.Point(344, 128);
            this.customerPhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerPhoneTextBox.Name = "customerPhoneTextBox";
            this.customerPhoneTextBox.Size = new System.Drawing.Size(192, 24);
            this.customerPhoneTextBox.TabIndex = 3;
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerAddressTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customerAddressTextBox.Location = new System.Drawing.Point(344, 170);
            this.customerAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(192, 24);
            this.customerAddressTextBox.TabIndex = 4;
            // 
            // receiptDateTimePicker
            // 
            this.receiptDateTimePicker.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.receiptDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.receiptDateTimePicker.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receiptDateTimePicker.Location = new System.Drawing.Point(344, 230);
            this.receiptDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receiptDateTimePicker.Name = "receiptDateTimePicker";
            this.receiptDateTimePicker.Size = new System.Drawing.Size(192, 24);
            this.receiptDateTimePicker.TabIndex = 6;
            // 
            // completionDateTimePicker
            // 
            this.completionDateTimePicker.CalendarForeColor = System.Drawing.Color.SaddleBrown;
            this.completionDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
            this.completionDateTimePicker.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completionDateTimePicker.Location = new System.Drawing.Point(344, 273);
            this.completionDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.completionDateTimePicker.Name = "completionDateTimePicker";
            this.completionDateTimePicker.Size = new System.Drawing.Size(192, 24);
            this.completionDateTimePicker.TabIndex = 7;
            // 
            // заказыDataSet
            // 
            this.заказыDataSet.DataSetName = "ЗаказыDataSet";
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
            // OrderAddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 373);
            this.Controls.Add(this.completionDateTimePicker);
            this.Controls.Add(this.receiptDateTimePicker);
            this.Controls.Add(this.customerAddressTextBox);
            this.Controls.Add(this.customerPhoneTextBox);
            this.Controls.Add(this.cutomerNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderAddingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderAddingForm";
            this.Load += new System.EventHandler(this.Add_Zakaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cutomerNameTextBox;
        private System.Windows.Forms.TextBox customerPhoneTextBox;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.DateTimePicker receiptDateTimePicker;
        private System.Windows.Forms.DateTimePicker completionDateTimePicker;
        private ЗаказыDataSet заказыDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private ЗаказыDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private ЗаказыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}