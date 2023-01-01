
namespace Flower_shop
{
    partial class Svodka_dan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Svodka_dan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pb_Dalee = new System.Windows.Forms.PictureBox();
            this.dataGrid_Aks_v_zak = new System.Windows.Forms.DataGridView();
            this.iDаксессуароввзаказеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.каталогаксессуаровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыDataSet = new Flower_shop.ЗаказыDataSet();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDаксессуараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tb_address = new System.Windows.Forms.TextBox();
            this.tb_number_zak = new System.Windows.Forms.TextBox();
            this.tb_name_zak = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.аксессуары_в_заказеTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Аксессуары_в_заказеTableAdapter();
            this.цветы_в_заказеTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Цветы_в_заказеTableAdapter();
            this.каталог_аксессуаровTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Каталог_аксессуаровTableAdapter();
            this.каталог_цветовTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Каталог_цветовTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dalee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Aks_v_zak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогаксессуаровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аксессуарывзаказеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Cvety_v_zak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогцветовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветывзаказеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Dalee
            // 
            this.pb_Dalee.BackColor = System.Drawing.Color.Transparent;
            this.pb_Dalee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_Dalee.BackgroundImage")));
            this.pb_Dalee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_Dalee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Dalee.Location = new System.Drawing.Point(728, 447);
            this.pb_Dalee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_Dalee.Name = "pb_Dalee";
            this.pb_Dalee.Size = new System.Drawing.Size(94, 28);
            this.pb_Dalee.TabIndex = 7;
            this.pb_Dalee.TabStop = false;
            this.pb_Dalee.Click += new System.EventHandler(this.pb_Dalee_Click);
            // 
            // dataGrid_Aks_v_zak
            // 
            this.dataGrid_Aks_v_zak.AllowUserToAddRows = false;
            this.dataGrid_Aks_v_zak.AutoGenerateColumns = false;
            this.dataGrid_Aks_v_zak.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Aks_v_zak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Aks_v_zak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Aks_v_zak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDаксессуароввзаказеDataGridViewTextBoxColumn,
            this.Column2,
            this.Column3,
            this.количествоDataGridViewTextBoxColumn,
            this.iDзаказаDataGridViewTextBoxColumn,
            this.iDаксессуараDataGridViewTextBoxColumn});
            this.dataGrid_Aks_v_zak.DataSource = this.аксессуарывзаказеBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Aks_v_zak.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Aks_v_zak.Location = new System.Drawing.Point(498, 87);
            this.dataGrid_Aks_v_zak.Name = "dataGrid_Aks_v_zak";
            this.dataGrid_Aks_v_zak.RowHeadersVisible = false;
            this.dataGrid_Aks_v_zak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Aks_v_zak.Size = new System.Drawing.Size(324, 145);
            this.dataGrid_Aks_v_zak.TabIndex = 8;
            // 
            // iDаксессуароввзаказеDataGridViewTextBoxColumn
            // 
            this.iDаксессуароввзаказеDataGridViewTextBoxColumn.DataPropertyName = "ID_аксессуаров_в_заказе";
            this.iDаксессуароввзаказеDataGridViewTextBoxColumn.HeaderText = "ID_аксессуаров_в_заказе";
            this.iDаксессуароввзаказеDataGridViewTextBoxColumn.Name = "iDаксессуароввзаказеDataGridViewTextBoxColumn";
            this.iDаксессуароввзаказеDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID_аксессуара";
            this.Column2.DataSource = this.каталогаксессуаровBindingSource;
            this.Column2.DisplayMember = "Наименование";
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column2.HeaderText = "Наименование";
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
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column3.HeaderText = "Цвет";
            this.Column3.Name = "Column3";
            this.Column3.ValueMember = "ID_аксессуара";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.Width = 101;
            // 
            // iDзаказаDataGridViewTextBoxColumn
            // 
            this.iDзаказаDataGridViewTextBoxColumn.DataPropertyName = "ID_заказа";
            this.iDзаказаDataGridViewTextBoxColumn.HeaderText = "ID_заказа";
            this.iDзаказаDataGridViewTextBoxColumn.Name = "iDзаказаDataGridViewTextBoxColumn";
            this.iDзаказаDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDаксессуараDataGridViewTextBoxColumn
            // 
            this.iDаксессуараDataGridViewTextBoxColumn.DataPropertyName = "ID_аксессуара";
            this.iDаксессуараDataGridViewTextBoxColumn.HeaderText = "ID_аксессуара";
            this.iDаксессуараDataGridViewTextBoxColumn.Name = "iDаксессуараDataGridViewTextBoxColumn";
            this.iDаксессуараDataGridViewTextBoxColumn.Visible = false;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Cvety_v_zak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Cvety_v_zak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Cvety_v_zak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDцветоввзаказеDataGridViewTextBoxColumn,
            this.Column1,
            this.количествоDataGridViewTextBoxColumn1,
            this.iDцветовDataGridViewTextBoxColumn,
            this.iDзаказаDataGridViewTextBoxColumn1});
            this.dataGrid_Cvety_v_zak.DataSource = this.цветывзаказеBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Cvety_v_zak.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Cvety_v_zak.Location = new System.Drawing.Point(498, 274);
            this.dataGrid_Cvety_v_zak.Name = "dataGrid_Cvety_v_zak";
            this.dataGrid_Cvety_v_zak.RowHeadersVisible = false;
            this.dataGrid_Cvety_v_zak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Cvety_v_zak.Size = new System.Drawing.Size(324, 145);
            this.dataGrid_Cvety_v_zak.TabIndex = 9;
            // 
            // iDцветоввзаказеDataGridViewTextBoxColumn
            // 
            this.iDцветоввзаказеDataGridViewTextBoxColumn.DataPropertyName = "ID_цветов_в_заказе";
            this.iDцветоввзаказеDataGridViewTextBoxColumn.HeaderText = "ID_цветов_в_заказе";
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
            this.количествоDataGridViewTextBoxColumn1.Name = "количествоDataGridViewTextBoxColumn1";
            // 
            // iDцветовDataGridViewTextBoxColumn
            // 
            this.iDцветовDataGridViewTextBoxColumn.DataPropertyName = "ID_цветов";
            this.iDцветовDataGridViewTextBoxColumn.HeaderText = "ID_цветов";
            this.iDцветовDataGridViewTextBoxColumn.Name = "iDцветовDataGridViewTextBoxColumn";
            this.iDцветовDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDзаказаDataGridViewTextBoxColumn1
            // 
            this.iDзаказаDataGridViewTextBoxColumn1.DataPropertyName = "ID_заказа";
            this.iDзаказаDataGridViewTextBoxColumn1.HeaderText = "ID_заказа";
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
            this.dateTimePicker2.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Location = new System.Drawing.Point(281, 335);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(153, 24);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(281, 293);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 24);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_address.Location = new System.Drawing.Point(281, 188);
            this.tb_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(153, 24);
            this.tb_address.TabIndex = 12;
            // 
            // tb_number_zak
            // 
            this.tb_number_zak.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_number_zak.Location = new System.Drawing.Point(281, 147);
            this.tb_number_zak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_number_zak.Name = "tb_number_zak";
            this.tb_number_zak.Size = new System.Drawing.Size(153, 24);
            this.tb_number_zak.TabIndex = 11;
            // 
            // tb_name_zak
            // 
            this.tb_name_zak.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name_zak.Location = new System.Drawing.Point(281, 107);
            this.tb_name_zak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name_zak.Name = "tb_name_zak";
            this.tb_name_zak.Size = new System.Drawing.Size(153, 24);
            this.tb_name_zak.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(281, 375);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 24);
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
            // Svodka_dan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(859, 498);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_number_zak);
            this.Controls.Add(this.tb_name_zak);
            this.Controls.Add(this.dataGrid_Cvety_v_zak);
            this.Controls.Add(this.dataGrid_Aks_v_zak);
            this.Controls.Add(this.pb_Dalee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Svodka_dan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Svodka_dan";
            this.Load += new System.EventHandler(this.Svodka_dan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Dalee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Aks_v_zak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогаксессуаровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аксессуарывзаказеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Cvety_v_zak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогцветовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветывзаказеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Dalee;
        private System.Windows.Forms.DataGridView dataGrid_Aks_v_zak;
        private System.Windows.Forms.DataGridView dataGrid_Cvety_v_zak;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.TextBox tb_number_zak;
        private System.Windows.Forms.TextBox tb_name_zak;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDаксессуароввзаказеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDаксессуараDataGridViewTextBoxColumn;
    }
}