
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.NextButton = new System.Windows.Forms.PictureBox();
			this.AccessoriesInOrderDataGrid = new System.Windows.Forms.DataGridView();
			this.ID_аксессуаров_в_заказе = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.каталогаксессуаровBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.заказыDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.заказыDataSet = new Flower_shop.ЗаказыDataSet();
			this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ID_аксессуара = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.аксессуарывзаказеBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.FlowersInOrderDataGrid = new System.Windows.Forms.DataGridView();
			this.iDцветоввзаказеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.каталогцветовBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.количествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDцветовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDзаказаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.цветывзаказеBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.CompletionDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.ReceiptDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.AddressTextBox = new System.Windows.Forms.TextBox();
			this.CustomerPhoneTextBox = new System.Windows.Forms.TextBox();
			this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
			this.SumTextBox = new System.Windows.Forms.TextBox();
			this.аксессуары_в_заказеTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Аксессуары_в_заказеTableAdapter();
			this.цветы_в_заказеTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Цветы_в_заказеTableAdapter();
			this.каталог_аксессуаровTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Каталог_аксессуаровTableAdapter();
			this.каталог_цветовTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Каталог_цветовTableAdapter();
			this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.заказTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.ЗаказTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.NextButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AccessoriesInOrderDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.каталогаксессуаровBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.аксессуарывзаказеBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FlowersInOrderDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.каталогцветовBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.цветывзаказеBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// NextButton
			// 
			this.NextButton.BackColor = System.Drawing.Color.Transparent;
			this.NextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextButton.BackgroundImage")));
			this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NextButton.Location = new System.Drawing.Point(1144, 730);
			this.NextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(125, 34);
			this.NextButton.TabIndex = 7;
			this.NextButton.TabStop = false;
			this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// AccessoriesInOrderDataGrid
			// 
			this.AccessoriesInOrderDataGrid.AllowUserToAddRows = false;
			this.AccessoriesInOrderDataGrid.AllowUserToDeleteRows = false;
			this.AccessoriesInOrderDataGrid.AutoGenerateColumns = false;
			this.AccessoriesInOrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.AccessoriesInOrderDataGrid.BackgroundColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.AccessoriesInOrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.AccessoriesInOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AccessoriesInOrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_аксессуаров_в_заказе,
            this.Column2,
            this.Column3,
            this.Количество,
            this.ID_аксессуара,
            this.iDзаказаDataGridViewTextBoxColumn});
			this.AccessoriesInOrderDataGrid.DataSource = this.аксессуарывзаказеBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.AccessoriesInOrderDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.AccessoriesInOrderDataGrid.Location = new System.Drawing.Point(711, 124);
			this.AccessoriesInOrderDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.AccessoriesInOrderDataGrid.Name = "AccessoriesInOrderDataGrid";
			this.AccessoriesInOrderDataGrid.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.AccessoriesInOrderDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.AccessoriesInOrderDataGrid.RowHeadersVisible = false;
			this.AccessoriesInOrderDataGrid.RowHeadersWidth = 51;
			this.AccessoriesInOrderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.AccessoriesInOrderDataGrid.Size = new System.Drawing.Size(559, 256);
			this.AccessoriesInOrderDataGrid.TabIndex = 8;
			// 
			// ID_аксессуаров_в_заказе
			// 
			this.ID_аксессуаров_в_заказе.DataPropertyName = "ID_аксессуаров_в_заказе";
			this.ID_аксессуаров_в_заказе.HeaderText = "ID_аксессуаров_в_заказе";
			this.ID_аксессуаров_в_заказе.MinimumWidth = 6;
			this.ID_аксессуаров_в_заказе.Name = "ID_аксессуаров_в_заказе";
			this.ID_аксессуаров_в_заказе.ReadOnly = true;
			this.ID_аксессуаров_в_заказе.Visible = false;
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
			this.Column2.ReadOnly = true;
			this.Column2.ValueMember = "ID_аксессуара";
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
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.ValueMember = "ID_аксессуара";
			// 
			// Количество
			// 
			this.Количество.DataPropertyName = "Количество";
			this.Количество.HeaderText = "Количество";
			this.Количество.MinimumWidth = 6;
			this.Количество.Name = "Количество";
			this.Количество.ReadOnly = true;
			// 
			// ID_аксессуара
			// 
			this.ID_аксессуара.DataPropertyName = "ID_аксессуара";
			this.ID_аксессуара.HeaderText = "ID_аксессуара";
			this.ID_аксессуара.MinimumWidth = 6;
			this.ID_аксессуара.Name = "ID_аксессуара";
			this.ID_аксессуара.ReadOnly = true;
			this.ID_аксессуара.Visible = false;
			// 
			// iDзаказаDataGridViewTextBoxColumn
			// 
			this.iDзаказаDataGridViewTextBoxColumn.DataPropertyName = "ID_заказа";
			this.iDзаказаDataGridViewTextBoxColumn.HeaderText = "ID_заказа";
			this.iDзаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.iDзаказаDataGridViewTextBoxColumn.Name = "iDзаказаDataGridViewTextBoxColumn";
			this.iDзаказаDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDзаказаDataGridViewTextBoxColumn.Visible = false;
			// 
			// аксессуарывзаказеBindingSource
			// 
			this.аксессуарывзаказеBindingSource.DataMember = "Аксессуары_в_заказе";
			this.аксессуарывзаказеBindingSource.DataSource = this.заказыDataSet;
			// 
			// FlowersInOrderDataGrid
			// 
			this.FlowersInOrderDataGrid.AllowUserToAddRows = false;
			this.FlowersInOrderDataGrid.AllowUserToDeleteRows = false;
			this.FlowersInOrderDataGrid.AutoGenerateColumns = false;
			this.FlowersInOrderDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.FlowersInOrderDataGrid.BackgroundColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.FlowersInOrderDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.FlowersInOrderDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.FlowersInOrderDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDцветоввзаказеDataGridViewTextBoxColumn,
            this.Column1,
            this.количествоDataGridViewTextBoxColumn1,
            this.iDцветовDataGridViewTextBoxColumn,
            this.iDзаказаDataGridViewTextBoxColumn1});
			this.FlowersInOrderDataGrid.DataSource = this.цветывзаказеBindingSource;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.FlowersInOrderDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
			this.FlowersInOrderDataGrid.Location = new System.Drawing.Point(711, 441);
			this.FlowersInOrderDataGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.FlowersInOrderDataGrid.Name = "FlowersInOrderDataGrid";
			this.FlowersInOrderDataGrid.ReadOnly = true;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SaddleBrown;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSalmon;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.FlowersInOrderDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.FlowersInOrderDataGrid.RowHeadersVisible = false;
			this.FlowersInOrderDataGrid.RowHeadersWidth = 51;
			this.FlowersInOrderDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.FlowersInOrderDataGrid.Size = new System.Drawing.Size(559, 257);
			this.FlowersInOrderDataGrid.TabIndex = 9;
			// 
			// iDцветоввзаказеDataGridViewTextBoxColumn
			// 
			this.iDцветоввзаказеDataGridViewTextBoxColumn.DataPropertyName = "ID_цветов_в_заказе";
			this.iDцветоввзаказеDataGridViewTextBoxColumn.HeaderText = "ID_цветов_в_заказе";
			this.iDцветоввзаказеDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.iDцветоввзаказеDataGridViewTextBoxColumn.Name = "iDцветоввзаказеDataGridViewTextBoxColumn";
			this.iDцветоввзаказеDataGridViewTextBoxColumn.ReadOnly = true;
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
			this.Column1.ReadOnly = true;
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
			this.количествоDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// iDцветовDataGridViewTextBoxColumn
			// 
			this.iDцветовDataGridViewTextBoxColumn.DataPropertyName = "ID_цветов";
			this.iDцветовDataGridViewTextBoxColumn.HeaderText = "ID_цветов";
			this.iDцветовDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.iDцветовDataGridViewTextBoxColumn.Name = "iDцветовDataGridViewTextBoxColumn";
			this.iDцветовDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDцветовDataGridViewTextBoxColumn.Visible = false;
			// 
			// iDзаказаDataGridViewTextBoxColumn1
			// 
			this.iDзаказаDataGridViewTextBoxColumn1.DataPropertyName = "ID_заказа";
			this.iDзаказаDataGridViewTextBoxColumn1.HeaderText = "ID_заказа";
			this.iDзаказаDataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.iDзаказаDataGridViewTextBoxColumn1.Name = "iDзаказаDataGridViewTextBoxColumn1";
			this.iDзаказаDataGridViewTextBoxColumn1.ReadOnly = true;
			this.iDзаказаDataGridViewTextBoxColumn1.Visible = false;
			// 
			// цветывзаказеBindingSource
			// 
			this.цветывзаказеBindingSource.DataMember = "Цветы_в_заказе";
			this.цветывзаказеBindingSource.DataSource = this.заказыDataSet;
			// 
			// CompletionDateTimePicker
			// 
			this.CompletionDateTimePicker.CalendarForeColor = System.Drawing.Color.SaddleBrown;
			this.CompletionDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.DarkSalmon;
			this.CompletionDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
			this.CompletionDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CompletionDateTimePicker.Location = new System.Drawing.Point(397, 496);
			this.CompletionDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CompletionDateTimePicker.Name = "CompletionDateTimePicker";
			this.CompletionDateTimePicker.Size = new System.Drawing.Size(203, 26);
			this.CompletionDateTimePicker.TabIndex = 14;
			// 
			// ReceiptDateTimePicker
			// 
			this.ReceiptDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.DarkSalmon;
			this.ReceiptDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.SaddleBrown;
			this.ReceiptDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ReceiptDateTimePicker.Location = new System.Drawing.Point(397, 418);
			this.ReceiptDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReceiptDateTimePicker.Name = "ReceiptDateTimePicker";
			this.ReceiptDateTimePicker.Size = new System.Drawing.Size(203, 26);
			this.ReceiptDateTimePicker.TabIndex = 13;
			// 
			// AddressTextBox
			// 
			this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddressTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.AddressTextBox.Location = new System.Drawing.Point(397, 340);
			this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.Size = new System.Drawing.Size(203, 26);
			this.AddressTextBox.TabIndex = 12;
			// 
			// CustomerPhoneTextBox
			// 
			this.CustomerPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CustomerPhoneTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.CustomerPhoneTextBox.Location = new System.Drawing.Point(397, 265);
			this.CustomerPhoneTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox";
			this.CustomerPhoneTextBox.Size = new System.Drawing.Size(203, 26);
			this.CustomerPhoneTextBox.TabIndex = 11;
			// 
			// CustomerNameTextBox
			// 
			this.CustomerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CustomerNameTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.CustomerNameTextBox.Location = new System.Drawing.Point(397, 190);
			this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.CustomerNameTextBox.Name = "CustomerNameTextBox";
			this.CustomerNameTextBox.Size = new System.Drawing.Size(203, 26);
			this.CustomerNameTextBox.TabIndex = 10;
			// 
			// SumTextBox
			// 
			this.SumTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SumTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.SumTextBox.Location = new System.Drawing.Point(397, 567);
			this.SumTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.SumTextBox.Name = "SumTextBox";
			this.SumTextBox.ReadOnly = true;
			this.SumTextBox.Size = new System.Drawing.Size(203, 26);
			this.SumTextBox.TabIndex = 15;
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
			this.ClientSize = new System.Drawing.Size(1319, 780);
			this.Controls.Add(this.SumTextBox);
			this.Controls.Add(this.CompletionDateTimePicker);
			this.Controls.Add(this.ReceiptDateTimePicker);
			this.Controls.Add(this.AddressTextBox);
			this.Controls.Add(this.CustomerPhoneTextBox);
			this.Controls.Add(this.CustomerNameTextBox);
			this.Controls.Add(this.FlowersInOrderDataGrid);
			this.Controls.Add(this.AccessoriesInOrderDataGrid);
			this.Controls.Add(this.NextButton);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "DataSummaryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DataSummaryForm";
			this.Load += new System.EventHandler(this.DataSummaryForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.NextButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AccessoriesInOrderDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.каталогаксессуаровBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.аксессуарывзаказеBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FlowersInOrderDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.каталогцветовBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.цветывзаказеBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NextButton;
        private System.Windows.Forms.DataGridView AccessoriesInOrderDataGrid;
        private System.Windows.Forms.DataGridView FlowersInOrderDataGrid;
        private System.Windows.Forms.DateTimePicker CompletionDateTimePicker;
        private System.Windows.Forms.DateTimePicker ReceiptDateTimePicker;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox CustomerPhoneTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox SumTextBox;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_аксессуаров_в_заказе;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_аксессуара;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDзаказаDataGridViewTextBoxColumn;
    }
}