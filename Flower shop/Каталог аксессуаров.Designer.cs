
namespace Flower_shop
{
    partial class Каталог_аксессуаров
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Каталог_аксессуаров));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDаксессуараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.каталогаксессуаровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыDataSet = new Flower_shop.ЗаказыDataSet();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.каталог_аксессуаровTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Каталог_аксессуаровTableAdapter();
            this.pb_udal_strany = new System.Windows.Forms.PictureBox();
            this.pb_izm_strany = new System.Windows.Forms.PictureBox();
            this.pb_dob_strany = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогаксессуаровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_udal_strany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_izm_strany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dob_strany)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDаксессуараDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.цветDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.каталогаксессуаровBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(29, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(521, 301);
            this.dataGridView1.TabIndex = 24;
            // 
            // iDаксессуараDataGridViewTextBoxColumn
            // 
            this.iDаксессуараDataGridViewTextBoxColumn.DataPropertyName = "ID_аксессуара";
            this.iDаксессуараDataGridViewTextBoxColumn.HeaderText = "ID_аксессуара";
            this.iDаксессуараDataGridViewTextBoxColumn.Name = "iDаксессуараDataGridViewTextBoxColumn";
            this.iDаксессуараDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена, BYN";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // цветDataGridViewTextBoxColumn
            // 
            this.цветDataGridViewTextBoxColumn.DataPropertyName = "Цвет";
            this.цветDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.цветDataGridViewTextBoxColumn.Name = "цветDataGridViewTextBoxColumn";
            // 
            // каталогаксессуаровBindingSource
            // 
            this.каталогаксессуаровBindingSource.DataMember = "Каталог_аксессуаров";
            this.каталогаксессуаровBindingSource.DataSource = this.заказыDataSet;
            // 
            // заказыDataSet
            // 
            this.заказыDataSet.DataSetName = "ЗаказыDataSet";
            this.заказыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(12, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 19);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(98, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 19);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // каталог_аксессуаровTableAdapter
            // 
            this.каталог_аксессуаровTableAdapter.ClearBeforeFill = true;
            // 
            // pb_udal_strany
            // 
            this.pb_udal_strany.BackColor = System.Drawing.Color.Transparent;
            this.pb_udal_strany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_udal_strany.BackgroundImage")));
            this.pb_udal_strany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_udal_strany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_udal_strany.Location = new System.Drawing.Point(29, 425);
            this.pb_udal_strany.Name = "pb_udal_strany";
            this.pb_udal_strany.Size = new System.Drawing.Size(70, 19);
            this.pb_udal_strany.TabIndex = 32;
            this.pb_udal_strany.TabStop = false;
            this.pb_udal_strany.Click += new System.EventHandler(this.pb_udal_strany_Click);
            // 
            // pb_izm_strany
            // 
            this.pb_izm_strany.BackColor = System.Drawing.Color.Transparent;
            this.pb_izm_strany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_izm_strany.BackgroundImage")));
            this.pb_izm_strany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_izm_strany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_izm_strany.Location = new System.Drawing.Point(29, 388);
            this.pb_izm_strany.Name = "pb_izm_strany";
            this.pb_izm_strany.Size = new System.Drawing.Size(84, 19);
            this.pb_izm_strany.TabIndex = 31;
            this.pb_izm_strany.TabStop = false;
            this.pb_izm_strany.Click += new System.EventHandler(this.pb_izm_strany_Click);
            // 
            // pb_dob_strany
            // 
            this.pb_dob_strany.BackColor = System.Drawing.Color.Transparent;
            this.pb_dob_strany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_dob_strany.Image = ((System.Drawing.Image)(resources.GetObject("pb_dob_strany.Image")));
            this.pb_dob_strany.Location = new System.Drawing.Point(372, 388);
            this.pb_dob_strany.Name = "pb_dob_strany";
            this.pb_dob_strany.Size = new System.Drawing.Size(178, 19);
            this.pb_dob_strany.TabIndex = 30;
            this.pb_dob_strany.TabStop = false;
            this.pb_dob_strany.Click += new System.EventHandler(this.pb_dob_strany_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Sienna;
            this.textBox2.Location = new System.Drawing.Point(797, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 24);
            this.textBox2.TabIndex = 37;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Sienna;
            this.textBox1.Location = new System.Drawing.Point(797, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 24);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Каталог_аксессуаров
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1013, 454);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pb_udal_strany);
            this.Controls.Add(this.pb_izm_strany);
            this.Controls.Add(this.pb_dob_strany);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Каталог_аксессуаров";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Каталог_аксессуаров";
            this.Load += new System.EventHandler(this.Каталог_аксессуаров_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогаксессуаровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_udal_strany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_izm_strany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dob_strany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ЗаказыDataSet заказыDataSet;
        private System.Windows.Forms.BindingSource каталогаксессуаровBindingSource;
        private ЗаказыDataSetTableAdapters.Каталог_аксессуаровTableAdapter каталог_аксессуаровTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_udal_strany;
        private System.Windows.Forms.PictureBox pb_izm_strany;
        private System.Windows.Forms.PictureBox pb_dob_strany;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDаксессуараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}