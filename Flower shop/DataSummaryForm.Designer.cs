
namespace Flower_shop
{
    partial class DataSummaryForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSummaryForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pb_Dalee = new System.Windows.Forms.PictureBox();
			this.dataGrid_Aks_v_zak = new System.Windows.Forms.DataGridView();
			this.iDзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.каталогаксессуаровBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.заказыDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.заказыDataSet = new Flower_shop.ЗаказыDataSet();
			this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.аксессуарывзаказеBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGrid_Cvety_v_zak = new System.Windows.Forms.DataGridView();
			this.iDцветоввзаказеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.каталогцветовBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.количествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDцветовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDзаказаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.цветывзаказеBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.AddressTextBox = new System.Windows.Forms.TextBox();
			this.CustomerPhoneTextBox = new System.Windows.Forms.TextBox();
			this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.аксессуары_в_заказеTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Аксессуары_в_заказеTableAdapter();
			this.цветы_в_заказеTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Цветы_в_заказеTableAdapter();
			this.каталог_аксессуаровTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Каталог_аксессуаровTableAdapter();
			this.каталог_цветовTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Каталог_цветовTableAdapter();
			this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.заказTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.ЗаказTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.pb_Dalee)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Aks_v_zak)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.каталогаксессуаровBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.аксессуарывзаказеBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Cvety_v_zak)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.каталогцветовBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.цветывзаказеBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// pb_Dalee
			// 
			this.pb_Dalee.BackColor = System.Drawing.Color.Transparent;
			this.pb_Dalee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Dalee.BackgroundImage")));
			this.pb_Dalee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pb_Dalee.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb_Dalee.Location = new System.Drawing.Point(971, 550);
			this.pb_Dalee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pb_Dalee.Name = "pb_Dalee";
			this.pb_Dalee.Size = new System.Drawing.Size(125, 34);
			this.pb_Dalee.TabIndex = 7;
			this.pb_Dalee.TabStop = false;
			this.pb_Dalee.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// dataGrid_Aks_v_zak
			// 
			this.dataGrid_Aks_v_zak.AllowUserToAddRows = false;
			this.dataGrid_Aks_v_zak.AutoGenerateColumns = false;
			this.dataGrid_Aks_v_zak.BackgroundColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGrid_Aks_v_zak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGrid_Aks_v_zak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_Aks_v_zak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDзаказаDataGridViewTextBoxColumn,
            this.Column2,
            this.Column3});
			this.dataGrid_Aks_v_zak.DataSource = this.аксессуарывзаказеBindingSource;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SaddleBrown;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGrid_Aks_v_zak.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGrid_Aks_v_zak.Location = new System.Drawing.Point(664, 107);
			this.dataGrid_Aks_v_zak.Margin = new System.Windows.Forms.Padding(4);
			this.dataGrid_Aks_v_zak.Name = "dataGrid_Aks_v_zak";
			this.dataGrid_Aks_v_zak.RowHeadersVisible = false;
			this.dataGrid_Aks_v_zak.RowHeadersWidth = 51;
			this.dataGrid_Aks_v_zak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid_Aks_v_zak.Size = new System.Drawing.Size(432, 178);
			this.dataGrid_Aks_v_zak.TabIndex = 8;
			// 
			// iDзаказаDataGridViewTextBoxColumn
			// 
			this.iDзаказаDataGridViewTextBoxColumn.DataPropertyName = "ID_заказа";
			this.iDзаказаDataGridViewTextBoxColumn.HeaderText = "ID_заказа";
			this.iDзаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.iDзаказаDataGridViewTextBoxColumn.Name = "iDзаказаDataGridViewTextBoxColumn";
			this.iDзаказаDataGridViewTextBoxColumn.Visible = false;
			this.iDзаказаDataGridViewTextBoxColumn.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "ID_аксессуара";
			this.Column2.DataSource = this.каталогаксессуаровBindingSource;
			this.Column2.DisplayMember = "Наименование";
			this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.Column2.HeaderText = "Наименование";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ValueMember = "ID_аксессуара";
			this.Column2.Width = 120;
			// 
			// каталогаксессуаровBindingSource
			// 
			this.каталогаксессуаровBindingSource.DataMember = "Каталог_аксессуаров";
			this.каталогаксессуаровBindingSource.DataSource = this.заказыDataSetBindingSource;
			// 
			// заказыDataSetBindingSource
			// 
			this.заказыDataSetBindingSource.DataSource = this.заказыDataSet;
			this.заказыDataSetBindingSource.Position = 0;
			// 
			// заказыDataSet
			// 
			this.заказыDataSet.DataSetName = "ЗаказыDataSet";
			this.заказыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "ID_аксессуара";
			this.Column3.DataSource = this.каталогаксессуаровBindingSource;
			this.Column3.DisplayMember = "Цвет";
			this.Column3.HeaderText = "Цвет";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ValueMember = "ID_аксессуара";
			this.Column3.Width = 125;
			// 
			// аксессуарывзаказеBindingSource
			// 
			this.аксессуарывзаказеBindingSource.DataMember = "Аксессуары_в_заказе";
			this.аксессуарывзаказеBindingSource.DataSource = this.заказыDataSet;
			// 
			// dataGrid_Cvety_v_zak
			// 
			this.dataGrid_Cvety_v_zak.AllowUserToAddRows = false;
			this.dataGrid_Cvety_v_zak.AutoGenerateColumns = false;
			this.dataGrid_Cvety_v_zak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGrid_Cvety_v_zak.BackgroundColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SaddleBrown;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGrid_Cvety_v_zak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGrid_Cvety_v_zak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid_Cvety_v_zak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDцветоввзаказеDataGridViewTextBoxColumn,
            this.Column1,
            this.количествоDataGridViewTextBoxColumn1,
            this.iDцветовDataGridViewTextBoxColumn,
            this.iDзаказаDataGridViewTextBoxColumn1});
			this.dataGrid_Cvety_v_zak.DataSource = this.цветывзаказеBindingSource;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SaddleBrown;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGrid_Cvety_v_zak.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGrid_Cvety_v_zak.Location = new System.Drawing.Point(664, 337);
			this.dataGrid_Cvety_v_zak.Margin = new System.Windows.Forms.Padding(4);
			this.dataGrid_Cvety_v_zak.Name = "dataGrid_Cvety_v_zak";
			this.dataGrid_Cvety_v_zak.RowHeadersVisible = false;
			this.dataGrid_Cvety_v_zak.RowHeadersWidth = 51;
			this.dataGrid_Cvety_v_zak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid_Cvety_v_zak.Size = new System.Drawing.Size(432, 178);
			this.dataGrid_Cvety_v_zak.TabIndex = 9;
			// 
			// iDцветоввзаказеDataGridViewTextBoxColumn
			// 
			this.iDцветоввзаказеDataGridViewTextBoxColumn.DataPropertyName = "ID_цветов_в_заказе";
			this.iDцветоввзаказеDataGridViewTextBoxColumn.HeaderText = "ID_цветов_в_заказе";
			this.iDцветоввзаказеDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.iDцветоввзаказеDataGridViewTextBoxColumn.Name = "iDцветоввзаказеDataGridViewTextBoxColumn";
			this.iDцветоввзаказеDataGridViewTextBoxColumn.Visible = false;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ID_цветов";
			this.Column1.DataSource = this.каталогцветовBindingSource;
			this.Column1.DisplayMember = "Наименование";
			this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.Column1.HeaderText = "Наименование";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ValueMember = "ID_цветов";
			// 
			// каталогцветовBindingSource
			// 
			this.каталогцветовBindingSource.DataMember = "Каталог_цветов";
			this.каталогцветовBindingSource.DataSource = this.заказыDataSet;
			// 
			// количествоDataGridViewTextBoxColumn1
			// 
			this.количествоDataGridViewTextBoxColumn1.DataPropertyName = "Количество";
			this.количествоDataGridViewTextBoxColumn1.HeaderText = "Количество";
			this.количествоDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.количествоDataGridViewTextBoxColumn1.Name = "количествоDataGridViewTextBoxColumn1";
			// 
			// iDцветовDataGridViewTextBoxColumn
			// 
			this.iDцветовDataGridViewTextBoxColumn.DataPropertyName = "ID_цветов";
			this.iDцветовDataGridViewTextBoxColumn.HeaderText = "ID_цветов";
			this.iDцветовDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.iDцветовDataGridViewTextBoxColumn.Name = "iDцветовDataGridViewTextBoxColumn";
			this.iDцветовDataGridViewTextBoxColumn.Visible = false;
			// 
			// iDзаказаDataGridViewTextBoxColumn1
			// 
			this.iDзаказаDataGridViewTextBoxColumn1.DataPropertyName = "ID_заказа";
			this.iDзаказаDataGridViewTextBoxColumn1.HeaderText = "ID_заказа";
			this.iDзаказаDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.iDзаказаDataGridViewTextBoxColumn1.Name = "iDзаказаDataGridViewTextBoxColumn1";
			this.iDзаказаDataGridViewTextBoxColumn1.Visible = false;
			// 
			// цветывзаказеBindingSource
			// 
			this.цветывзаказеBindingSource.DataMember = "Цветы_в_заказе";
			this.цветывзаказеBindingSource.DataSource = this.заказыDataSet;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker2.Location = new System.Drawing.Point(375, 412);
			this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(203, 26);
			this.dateTimePicker2.TabIndex = 14;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePicker1.Location = new System.Drawing.Point(375, 361);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(203, 26);
			this.dateTimePicker1.TabIndex = 13;
			// 
			// AddressTextBox
			// 
			this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddressTextBox.Location = new System.Drawing.Point(375, 231);
			this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.Size = new System.Drawing.Size(203, 26);
			this.AddressTextBox.TabIndex = 12;
			// 
			// CustomerPhoneTextBox
			// 
			this.CustomerPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CustomerPhoneTextBox.Location = new System.Drawing.Point(375, 181);
			this.CustomerPhoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox";
			this.CustomerPhoneTextBox.Size = new System.Drawing.Size(203, 26);
			this.CustomerPhoneTextBox.TabIndex = 11;
			// 
			// CustomerNameTextBox
			// 
			this.CustomerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CustomerNameTextBox.Location = new System.Drawing.Point(375, 132);
			this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CustomerNameTextBox.Name = "CustomerNameTextBox";
			this.CustomerNameTextBox.Size = new System.Drawing.Size(203, 26);
			this.CustomerNameTextBox.TabIndex = 10;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(375, 462);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(203, 26);
			this.textBox2.TabIndex = 15;
			// 
			// аксессуары_в_заказеTableAdapter
			// 
			this.аксессуары_в_заказеTableAdapter.ClearBeforeFill = true;
			// 
			// цветы_в_заказеTableAdapter
			// 
			this.цветы_в_заказеTableAdapter.ClearBeforeFill = true;
			// 
			// каталог_аксессуаровTableAdapter
			// 
			this.каталог_аксессуаровTableAdapter.ClearBeforeFill = true;
			// 
			// каталог_цветовTableAdapter
			// 
			this.каталог_цветовTableAdapter.ClearBeforeFill = true;
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
			// DataSummaryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1145, 613);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.AddressTextBox);
			this.Controls.Add(this.CustomerPhoneTextBox);
			this.Controls.Add(this.CustomerNameTextBox);
			this.Controls.Add(this.dataGrid_Cvety_v_zak);
			this.Controls.Add(this.dataGrid_Aks_v_zak);
			this.Controls.Add(this.pb_Dalee);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "DataSummaryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DataSummaryForm";
			this.Load += new System.EventHandler(this.DataSummaryForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pb_Dalee)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Aks_v_zak)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.каталогаксессуаровBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.аксессуарывзаказеBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Cvety_v_zak)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.каталогцветовBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.цветывзаказеBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Dalee;
        private System.Windows.Forms.DataGridView dataGrid_Aks_v_zak;
        private System.Windows.Forms.DataGridView dataGrid_Cvety_v_zak;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox CustomerPhoneTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private ЗаказыDataSet заказыDataSet;
        private System.Windows.Forms.BindingSource аксессуарывзаказеBindingSource;
        private ЗаказыDataSetTableAdapters.Аксессуары_в_заказеTableAdapter аксессуары_в_заказеTableAdapter;
        private System.Windows.Forms.BindingSource цветывзаказеBindingSource;
        private ЗаказыDataSetTableAdapters.Цветы_в_заказеTableAdapter цветы_в_заказеTableAdapter;
        private System.Windows.Forms.BindingSource заказыDataSetBindingSource;
        private System.Windows.Forms.BindingSource каталогаксессуаровBindingSource;
        private ЗаказыDataSetTableAdapters.Каталог_аксессуаровTableAdapter каталог_аксессуаровTableAdapter;
        private System.Windows.Forms.BindingSource каталогцветовBindingSource;
        private ЗаказыDataSetTableAdapters.Каталог_цветовTableAdapter каталог_цветовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDцветоввзаказеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDцветовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзаказаDataGridViewTextBoxColumn1;
		private System.Windows.Forms.BindingSource заказBindingSource;
		private ЗаказыDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDзаказаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
		private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
	}
}