
namespace Flower_shop
{
    partial class Изменение_цветов
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Изменение_цветов));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.видцветовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыDataSet1 = new Flower_shop.ЗаказыDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.каталогцветовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.странапроизводительBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.заказыDataSet = new Flower_shop.ЗаказыDataSet();
            this.каталог_цветовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталог_цветовTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Каталог_цветовTableAdapter();
            this.tableAdapterManager = new Flower_shop.ЗаказыDataSetTableAdapters.TableAdapterManager();
            this.страна_производительTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Страна_производительTableAdapter();
            this.вид_цветовTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Вид_цветовTableAdapter();
            this.каталогцветовЦветывзаказеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.цветы_в_заказеTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Цветы_в_заказеTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видцветовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогцветовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.странапроизводительBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_цветовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогцветовЦветывзаказеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(468, 305);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 28);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.видцветовBindingSource, "Наименование", true));
            this.comboBox2.DataSource = this.видцветовBindingSource;
            this.comboBox2.DisplayMember = "Наименование";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.ForeColor = System.Drawing.Color.Sienna;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(321, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 27);
            this.comboBox2.TabIndex = 34;
            this.comboBox2.ValueMember = "ID_вида_цветов";
            // 
            // видцветовBindingSource
            // 
            this.видцветовBindingSource.DataMember = "Вид_цветов";
            this.видцветовBindingSource.DataSource = this.заказыDataSet1;
            // 
            // заказыDataSet1
            // 
            this.заказыDataSet1.DataSetName = "ЗаказыDataSet";
            this.заказыDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.каталогцветовBindingSource, "ID_страны_производителя", true));
            this.comboBox1.DataSource = this.странапроизводительBindingSource;
            this.comboBox1.DisplayMember = "Наименование";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.Sienna;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 27);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.ValueMember = "ID_страны_производителя";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // каталогцветовBindingSource
            // 
            this.каталогцветовBindingSource.DataMember = "Каталог_цветов";
            this.каталогцветовBindingSource.DataSource = this.заказыDataSet1;
            // 
            // странапроизводительBindingSource
            // 
            this.странапроизводительBindingSource.DataMember = "Страна_производитель";
            this.странапроизводительBindingSource.DataSource = this.заказыDataSet1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.Color.Sienna;
            this.textBox4.Location = new System.Drawing.Point(321, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 26);
            this.textBox4.TabIndex = 32;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Gilroy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Sienna;
            this.textBox1.Location = new System.Drawing.Point(321, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 26);
            this.textBox1.TabIndex = 31;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(31, 305);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 28);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // заказыDataSet
            // 
            this.заказыDataSet.DataSetName = "ЗаказыDataSet";
            this.заказыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каталог_цветовBindingSource
            // 
            this.каталог_цветовBindingSource.DataMember = "Каталог_цветов";
            this.каталог_цветовBindingSource.DataSource = this.заказыDataSet;
            // 
            // каталог_цветовTableAdapter
            // 
            this.каталог_цветовTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Flower_shop.ЗаказыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аксессуары_в_заказеTableAdapter = null;
            this.tableAdapterManager.Вид_цветовTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.Каталог_аксессуаровTableAdapter = null;
            this.tableAdapterManager.Каталог_цветовTableAdapter = this.каталог_цветовTableAdapter;
            this.tableAdapterManager.Страна_производительTableAdapter = null;
            this.tableAdapterManager.Цветы_в_заказеTableAdapter = null;
            // 
            // страна_производительTableAdapter
            // 
            this.страна_производительTableAdapter.ClearBeforeFill = true;
            // 
            // вид_цветовTableAdapter
            // 
            this.вид_цветовTableAdapter.ClearBeforeFill = true;
            // 
            // каталогцветовЦветывзаказеBindingSource
            // 
            this.каталогцветовЦветывзаказеBindingSource.DataMember = "Каталог_цветовЦветы_в_заказе";
            this.каталогцветовЦветывзаказеBindingSource.DataSource = this.каталог_цветовBindingSource;
            // 
            // цветы_в_заказеTableAdapter
            // 
            this.цветы_в_заказеTableAdapter.ClearBeforeFill = true;
            // 
            // Изменение_цветов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(588, 353);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Изменение_цветов";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение_цветов";
            this.Load += new System.EventHandler(this.Изменение_цветов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видцветовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогцветовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.странапроизводительBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_цветовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталогцветовЦветывзаказеBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ЗаказыDataSet заказыDataSet;
        private System.Windows.Forms.BindingSource каталог_цветовBindingSource;
        private ЗаказыDataSetTableAdapters.Каталог_цветовTableAdapter каталог_цветовTableAdapter;
        private ЗаказыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ЗаказыDataSet заказыDataSet1;
        private System.Windows.Forms.BindingSource странапроизводительBindingSource;
        private ЗаказыDataSetTableAdapters.Страна_производительTableAdapter страна_производительTableAdapter;
        private System.Windows.Forms.BindingSource видцветовBindingSource;
        private ЗаказыDataSetTableAdapters.Вид_цветовTableAdapter вид_цветовTableAdapter;
        private System.Windows.Forms.BindingSource каталогцветовЦветывзаказеBindingSource;
        private ЗаказыDataSetTableAdapters.Цветы_в_заказеTableAdapter цветы_в_заказеTableAdapter;
        private System.Windows.Forms.BindingSource каталогцветовBindingSource;
    }
}