namespace Medical_store
{
    partial class itemStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet1 = new Medical_store.MedicalDataSet1();
            this.stockTableAdapter = new Medical_store.MedicalDataSet1TableAdapters.StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(197, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "ITEM STOCK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(55, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyNameDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.saleQTYDataGridViewTextBoxColumn,
            this.purchaseQTYDataGridViewTextBoxColumn,
            this.availableQTYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(587, 244);
            this.dataGridView1.TabIndex = 29;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "Company-Name";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "Company-Name";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "Item-Id";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "Item-Id";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            // 
            // saleQTYDataGridViewTextBoxColumn
            // 
            this.saleQTYDataGridViewTextBoxColumn.DataPropertyName = "Sale-QTY";
            this.saleQTYDataGridViewTextBoxColumn.HeaderText = "Sale-QTY";
            this.saleQTYDataGridViewTextBoxColumn.Name = "saleQTYDataGridViewTextBoxColumn";
            // 
            // purchaseQTYDataGridViewTextBoxColumn
            // 
            this.purchaseQTYDataGridViewTextBoxColumn.DataPropertyName = "Purchase-QTY";
            this.purchaseQTYDataGridViewTextBoxColumn.HeaderText = "Purchase-QTY";
            this.purchaseQTYDataGridViewTextBoxColumn.Name = "purchaseQTYDataGridViewTextBoxColumn";
            // 
            // availableQTYDataGridViewTextBoxColumn
            // 
            this.availableQTYDataGridViewTextBoxColumn.DataPropertyName = "Available-QTY";
            this.availableQTYDataGridViewTextBoxColumn.HeaderText = "Available-QTY";
            this.availableQTYDataGridViewTextBoxColumn.Name = "availableQTYDataGridViewTextBoxColumn";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.medicalDataSet1;
            // 
            // medicalDataSet1
            // 
            this.medicalDataSet1.DataSetName = "MedicalDataSet1";
            this.medicalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // itemStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(652, 401);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "itemStock";
            this.Text = "itemStock";
            this.Load += new System.EventHandler(this.itemStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MedicalDataSet1 medicalDataSet1;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private Medical_store.MedicalDataSet1TableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQTYDataGridViewTextBoxColumn;
    }
}