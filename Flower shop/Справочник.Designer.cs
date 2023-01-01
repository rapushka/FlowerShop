
namespace Flower_shop
{
    partial class Справочник
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Справочник));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDвидацветовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видцветовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыDataSet = new Flower_shop.ЗаказыDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDстраныпроизводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странапроизводительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pb_dob_vid = new System.Windows.Forms.PictureBox();
            this.pb_dob_strany = new System.Windows.Forms.PictureBox();
            this.pb_izm_vid = new System.Windows.Forms.PictureBox();
            this.pb_izm_strany = new System.Windows.Forms.PictureBox();
            this.pb_udal_vid = new System.Windows.Forms.PictureBox();
            this.pb_udal_strany = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.вид_цветовTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Вид_цветовTableAdapter();
            this.страна_производительTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Страна_производительTableAdapter();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableAdapterManager = new Flower_shop.ЗаказыDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видцветовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.странапроизводительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dob_vid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dob_strany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_izm_vid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_izm_strany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_udal_vid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_udal_strany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gilroy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDвидацветовDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.видцветовBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(46, 76);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(310, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDвидацветовDataGridViewTextBoxColumn
            // 
            this.iDвидацветовDataGridViewTextBoxColumn.DataPropertyName = "ID_вида_цветов";
            this.iDвидацветовDataGridViewTextBoxColumn.HeaderText = "ID_вида_цветов";
            this.iDвидацветовDataGridViewTextBoxColumn.Name = "iDвидацветовDataGridViewTextBoxColumn";
            this.iDвидацветовDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // видцветовBindingSource
            // 
            this.видцветовBindingSource.DataMember = "Вид_цветов";
            this.видцветовBindingSource.DataSource = this.заказыDataSet;
            // 
            // заказыDataSet
            // 
            this.заказыDataSet.DataSetName = "ЗаказыDataSet";
            this.заказыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Gilroy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDстраныпроизводителяDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.странапроизводительBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.Location = new System.Drawing.Point(46, 268);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(310, 157);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDстраныпроизводителяDataGridViewTextBoxColumn
            // 
            this.iDстраныпроизводителяDataGridViewTextBoxColumn.DataPropertyName = "ID_страны_производителя";
            this.iDстраныпроизводителяDataGridViewTextBoxColumn.HeaderText = "ID_страны_производителя";
            this.iDстраныпроизводителяDataGridViewTextBoxColumn.Name = "iDстраныпроизводителяDataGridViewTextBoxColumn";
            this.iDстраныпроизводителяDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            // 
            // странапроизводительBindingSource
            // 
            this.странапроизводительBindingSource.DataMember = "Страна_производитель";
            this.странапроизводительBindingSource.DataSource = this.заказыDataSet;
            // 
            // pb_dob_vid
            // 
            this.pb_dob_vid.BackColor = System.Drawing.Color.Transparent;
            this.pb_dob_vid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_dob_vid.Image = ((System.Drawing.Image)(resources.GetObject("pb_dob_vid.Image")));
            this.pb_dob_vid.Location = new System.Drawing.Point(376, 111);
            this.pb_dob_vid.Name = "pb_dob_vid";
            this.pb_dob_vid.Size = new System.Drawing.Size(118, 18);
            this.pb_dob_vid.TabIndex = 11;
            this.pb_dob_vid.TabStop = false;
            this.pb_dob_vid.Click += new System.EventHandler(this.pb_Dod_Cvety_Click);
            // 
            // pb_dob_strany
            // 
            this.pb_dob_strany.BackColor = System.Drawing.Color.Transparent;
            this.pb_dob_strany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_dob_strany.Image = ((System.Drawing.Image)(resources.GetObject("pb_dob_strany.Image")));
            this.pb_dob_strany.Location = new System.Drawing.Point(376, 302);
            this.pb_dob_strany.Name = "pb_dob_strany";
            this.pb_dob_strany.Size = new System.Drawing.Size(147, 19);
            this.pb_dob_strany.TabIndex = 12;
            this.pb_dob_strany.TabStop = false;
            this.pb_dob_strany.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_izm_vid
            // 
            this.pb_izm_vid.BackColor = System.Drawing.Color.Transparent;
            this.pb_izm_vid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_izm_vid.BackgroundImage")));
            this.pb_izm_vid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_izm_vid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_izm_vid.Location = new System.Drawing.Point(376, 146);
            this.pb_izm_vid.Name = "pb_izm_vid";
            this.pb_izm_vid.Size = new System.Drawing.Size(84, 19);
            this.pb_izm_vid.TabIndex = 13;
            this.pb_izm_vid.TabStop = false;
            this.pb_izm_vid.Click += new System.EventHandler(this.pb_izm_vid_Click);
            // 
            // pb_izm_strany
            // 
            this.pb_izm_strany.BackColor = System.Drawing.Color.Transparent;
            this.pb_izm_strany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_izm_strany.BackgroundImage")));
            this.pb_izm_strany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_izm_strany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_izm_strany.Location = new System.Drawing.Point(376, 338);
            this.pb_izm_strany.Name = "pb_izm_strany";
            this.pb_izm_strany.Size = new System.Drawing.Size(84, 19);
            this.pb_izm_strany.TabIndex = 14;
            this.pb_izm_strany.TabStop = false;
            this.pb_izm_strany.Click += new System.EventHandler(this.pb_izm_strany_Click);
            // 
            // pb_udal_vid
            // 
            this.pb_udal_vid.BackColor = System.Drawing.Color.Transparent;
            this.pb_udal_vid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_udal_vid.BackgroundImage")));
            this.pb_udal_vid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_udal_vid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_udal_vid.Location = new System.Drawing.Point(376, 182);
            this.pb_udal_vid.Name = "pb_udal_vid";
            this.pb_udal_vid.Size = new System.Drawing.Size(70, 19);
            this.pb_udal_vid.TabIndex = 15;
            this.pb_udal_vid.TabStop = false;
            this.pb_udal_vid.Click += new System.EventHandler(this.pb_udal_vid_Click);
            // 
            // pb_udal_strany
            // 
            this.pb_udal_strany.BackColor = System.Drawing.Color.Transparent;
            this.pb_udal_strany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_udal_strany.BackgroundImage")));
            this.pb_udal_strany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_udal_strany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_udal_strany.Location = new System.Drawing.Point(376, 375);
            this.pb_udal_strany.Name = "pb_udal_strany";
            this.pb_udal_strany.Size = new System.Drawing.Size(70, 19);
            this.pb_udal_strany.TabIndex = 16;
            this.pb_udal_strany.TabStop = false;
            this.pb_udal_strany.Click += new System.EventHandler(this.pb_udal_strany_Click);
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
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(234, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(160, 19);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Sienna;
            this.textBox1.Location = new System.Drawing.Point(743, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 24);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Sienna;
            this.textBox2.Location = new System.Drawing.Point(743, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 24);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // вид_цветовTableAdapter
            // 
            this.вид_цветовTableAdapter.ClearBeforeFill = true;
            // 
            // страна_производительTableAdapter
            // 
            this.страна_производительTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(735, 406);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(199, 19);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Flower_shop.ЗаказыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аксессуары_в_заказеTableAdapter = null;
            this.tableAdapterManager.Вид_цветовTableAdapter = this.вид_цветовTableAdapter;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.Каталог_аксессуаровTableAdapter = null;
            this.tableAdapterManager.Каталог_цветовTableAdapter = null;
            this.tableAdapterManager.Страна_производительTableAdapter = this.страна_производительTableAdapter;
            this.tableAdapterManager.Цветы_в_заказеTableAdapter = null;
            // 
            // Справочник
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1014, 453);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pb_udal_strany);
            this.Controls.Add(this.pb_udal_vid);
            this.Controls.Add(this.pb_izm_strany);
            this.Controls.Add(this.pb_izm_vid);
            this.Controls.Add(this.pb_dob_strany);
            this.Controls.Add(this.pb_dob_vid);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Справочник";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник";
            this.Load += new System.EventHandler(this.Справочник_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видцветовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.странапроизводительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dob_vid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dob_strany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_izm_vid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_izm_strany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_udal_vid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_udal_strany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ЗаказыDataSet заказыDataSet;
        private System.Windows.Forms.BindingSource видцветовBindingSource;
        private ЗаказыDataSetTableAdapters.Вид_цветовTableAdapter вид_цветовTableAdapter;
        private System.Windows.Forms.BindingSource странапроизводительBindingSource;
        private ЗаказыDataSetTableAdapters.Страна_производительTableAdapter страна_производительTableAdapter;
        private System.Windows.Forms.PictureBox pb_dob_vid;
        private System.Windows.Forms.PictureBox pb_dob_strany;
        private System.Windows.Forms.PictureBox pb_izm_vid;
        private System.Windows.Forms.PictureBox pb_izm_strany;
        private System.Windows.Forms.PictureBox pb_udal_vid;
        private System.Windows.Forms.PictureBox pb_udal_strany;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDвидацветовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDстраныпроизводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private ЗаказыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}