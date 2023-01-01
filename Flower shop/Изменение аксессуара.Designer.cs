
namespace Flower_shop
{
    partial class Изменение_аксессуара
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Изменение_аксессуара));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ценаtextBox = new System.Windows.Forms.TextBox();
            this.цветtextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.заказыDataSet = new Flower_shop.ЗаказыDataSet();
            this.каталог_аксессуаровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.каталог_аксессуаровTableAdapter = new Flower_shop.ЗаказыDataSetTableAdapters.Каталог_аксессуаровTableAdapter();
            this.tableAdapterManager = new Flower_shop.ЗаказыDataSetTableAdapters.TableAdapterManager();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_аксессуаровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(387, 246);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 28);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ценаtextBox
            // 
            this.ценаtextBox.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ценаtextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ценаtextBox.Location = new System.Drawing.Point(261, 136);
            this.ценаtextBox.Name = "ценаtextBox";
            this.ценаtextBox.Size = new System.Drawing.Size(141, 24);
            this.ценаtextBox.TabIndex = 11;
            this.ценаtextBox.TextChanged += new System.EventHandler(this.цветtextBox_TextChanged);
            this.ценаtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ценаtextBox_KeyPress);
            // 
            // цветtextBox
            // 
            this.цветtextBox.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.цветtextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.цветtextBox.Location = new System.Drawing.Point(261, 179);
            this.цветtextBox.Name = "цветtextBox";
            this.цветtextBox.Size = new System.Drawing.Size(141, 24);
            this.цветtextBox.TabIndex = 10;
            this.цветtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.цветtextBox_KeyPress);
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.Font = new System.Drawing.Font("Gilroy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.наименованиеTextBox.ForeColor = System.Drawing.Color.SaddleBrown;
            this.наименованиеTextBox.Location = new System.Drawing.Point(261, 96);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(141, 24);
            this.наименованиеTextBox.TabIndex = 13;
            // 
            // заказыDataSet
            // 
            this.заказыDataSet.DataSetName = "ЗаказыDataSet";
            this.заказыDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // каталог_аксессуаровBindingSource
            // 
            this.каталог_аксессуаровBindingSource.DataMember = "Каталог_аксессуаров";
            this.каталог_аксессуаровBindingSource.DataSource = this.заказыDataSet;
            // 
            // каталог_аксессуаровTableAdapter
            // 
            this.каталог_аксессуаровTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Flower_shop.ЗаказыDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Аксессуары_в_заказеTableAdapter = null;
            this.tableAdapterManager.Вид_цветовTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.Каталог_аксессуаровTableAdapter = this.каталог_аксессуаровTableAdapter;
            this.tableAdapterManager.Каталог_цветовTableAdapter = null;
            this.tableAdapterManager.Страна_производительTableAdapter = null;
            this.tableAdapterManager.Цветы_в_заказеTableAdapter = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(28, 246);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 28);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Изменение_аксессуара
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(514, 297);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(this.ценаtextBox);
            this.Controls.Add(this.цветtextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Изменение_аксессуара";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение_аксессуара";
            this.Load += new System.EventHandler(this.Изменение_аксессуара_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_аксессуаровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ценаtextBox;
        private System.Windows.Forms.TextBox цветtextBox;
        private ЗаказыDataSet заказыDataSet;
        private System.Windows.Forms.BindingSource каталог_аксессуаровBindingSource;
        private ЗаказыDataSetTableAdapters.Каталог_аксессуаровTableAdapter каталог_аксессуаровTableAdapter;
        private ЗаказыDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}