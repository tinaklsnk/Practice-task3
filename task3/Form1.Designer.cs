
namespace task3
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.ProducerBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.WarrantyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.pCShopDataSet = new task3.PCShopDataSet();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new task3.PCShopDataSetTableAdapters.GoodsTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warrantyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.goodsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.goodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.producerDataGridViewTextBoxColumn,
            this.warrantyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(324, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1034, 743);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(11, 31);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(283, 22);
            this.NameBox.TabIndex = 2;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(11, 86);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 22);
            this.PriceBox.TabIndex = 3;
            // 
            // ProducerBox
            // 
            this.ProducerBox.Location = new System.Drawing.Point(11, 140);
            this.ProducerBox.Name = "ProducerBox";
            this.ProducerBox.Size = new System.Drawing.Size(137, 22);
            this.ProducerBox.TabIndex = 4;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(12, 198);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(183, 22);
            this.TypeBox.TabIndex = 5;
            // 
            // WarrantyBox
            // 
            this.WarrantyBox.Location = new System.Drawing.Point(12, 255);
            this.WarrantyBox.Name = "WarrantyBox";
            this.WarrantyBox.Size = new System.Drawing.Size(71, 22);
            this.WarrantyBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Виробник";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Категорія";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Гарантія";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Insert);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PathBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PriceBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProducerBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TypeBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.WarrantyBox);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 433);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Шлях";
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(12, 314);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(282, 22);
            this.PathBox.TabIndex = 15;
            // 
            // pCShopDataSet
            // 
            this.pCShopDataSet.DataSetName = "PCShopDataSet";
            this.pCShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.pCShopDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.IdBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(1, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 162);
            this.panel2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Код";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(11, 41);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(100, 22);
            this.IdBox.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 59);
            this.button2.TabIndex = 16;
            this.button2.Text = "Вилучити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Remove);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 48;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 69;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 69;
            // 
            // producerDataGridViewTextBoxColumn
            // 
            this.producerDataGridViewTextBoxColumn.DataPropertyName = "Producer";
            this.producerDataGridViewTextBoxColumn.HeaderText = "Producer";
            this.producerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.producerDataGridViewTextBoxColumn.Name = "producerDataGridViewTextBoxColumn";
            this.producerDataGridViewTextBoxColumn.Width = 95;
            // 
            // warrantyDataGridViewTextBoxColumn
            // 
            this.warrantyDataGridViewTextBoxColumn.DataPropertyName = "Warranty";
            this.warrantyDataGridViewTextBoxColumn.HeaderText = "Warranty";
            this.warrantyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.warrantyDataGridViewTextBoxColumn.Name = "warrantyDataGridViewTextBoxColumn";
            this.warrantyDataGridViewTextBoxColumn.Width = 95;
            // 
            // goodsBindingSource2
            // 
            this.goodsBindingSource2.DataSource = typeof(task3.Goods);
            // 
            // goodsBindingSource3
            // 
            this.goodsBindingSource3.DataSource = typeof(task3.Goods);
            // 
            // goodsBindingSource1
            // 
            this.goodsBindingSource1.DataSource = typeof(task3.Goods);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Магазин комплектуючих для ПК ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox ProducerBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox WarrantyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private PCShopDataSet pCShopDataSet;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private PCShopDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.BindingSource goodsBindingSource1;
        private System.Windows.Forms.BindingSource goodsBindingSource2;
        private System.Windows.Forms.BindingSource goodsBindingSource3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn warrantyDataGridViewTextBoxColumn;
    }
}

