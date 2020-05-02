namespace Medical_store
{
    partial class PurchaseReg
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.billNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNetAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalVatAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseFinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet5 = new Medical_store.MedicalDataSet5();
            this.purchase_FinalTableAdapter = new Medical_store.MedicalDataSet5TableAdapters.Purchase_FinalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseFinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(127, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 42);
            this.label1.TabIndex = 28;
            this.label1.Text = "PURCHASE REGISTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(234, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "&Total Purchase Amount ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(486, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 26);
            this.textBox1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 26;
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
            this.billNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.partyNameDataGridViewTextBoxColumn,
            this.totalNetAMTDataGridViewTextBoxColumn,
            this.totalVatAMTDataGridViewTextBoxColumn,
            this.totalAMTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purchaseFinalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 211);
            this.dataGridView1.TabIndex = 29;
            // 
            // billNoDataGridViewTextBoxColumn
            // 
            this.billNoDataGridViewTextBoxColumn.DataPropertyName = "Bill-No";
            this.billNoDataGridViewTextBoxColumn.HeaderText = "Bill-No";
            this.billNoDataGridViewTextBoxColumn.Name = "billNoDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // partyNameDataGridViewTextBoxColumn
            // 
            this.partyNameDataGridViewTextBoxColumn.DataPropertyName = "Party-Name";
            this.partyNameDataGridViewTextBoxColumn.HeaderText = "Party-Name";
            this.partyNameDataGridViewTextBoxColumn.Name = "partyNameDataGridViewTextBoxColumn";
            // 
            // totalNetAMTDataGridViewTextBoxColumn
            // 
            this.totalNetAMTDataGridViewTextBoxColumn.DataPropertyName = "Total-Net-AMT";
            this.totalNetAMTDataGridViewTextBoxColumn.HeaderText = "Total-Net-AMT";
            this.totalNetAMTDataGridViewTextBoxColumn.Name = "totalNetAMTDataGridViewTextBoxColumn";
            // 
            // totalVatAMTDataGridViewTextBoxColumn
            // 
            this.totalVatAMTDataGridViewTextBoxColumn.DataPropertyName = "Total-Vat-AMT";
            this.totalVatAMTDataGridViewTextBoxColumn.HeaderText = "Total-Vat-AMT";
            this.totalVatAMTDataGridViewTextBoxColumn.Name = "totalVatAMTDataGridViewTextBoxColumn";
            // 
            // totalAMTDataGridViewTextBoxColumn
            // 
            this.totalAMTDataGridViewTextBoxColumn.DataPropertyName = "Total-AMT";
            this.totalAMTDataGridViewTextBoxColumn.HeaderText = "Total-AMT";
            this.totalAMTDataGridViewTextBoxColumn.Name = "totalAMTDataGridViewTextBoxColumn";
            this.totalAMTDataGridViewTextBoxColumn.Width = 150;
            // 
            // purchaseFinalBindingSource
            // 
            this.purchaseFinalBindingSource.DataMember = "Purchase-Final";
            this.purchaseFinalBindingSource.DataSource = this.medicalDataSet5;
            // 
            // medicalDataSet5
            // 
            this.medicalDataSet5.DataSetName = "MedicalDataSet5";
            this.medicalDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchase_FinalTableAdapter
            // 
            this.purchase_FinalTableAdapter.ClearBeforeFill = true;
            // 
            // PurchaseReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(696, 402);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "PurchaseReg";
            this.Text = "PurchaseReg";
            this.Load += new System.EventHandler(this.PurchaseReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseFinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MedicalDataSet5 medicalDataSet5;
        private System.Windows.Forms.BindingSource purchaseFinalBindingSource;
        private Medical_store.MedicalDataSet5TableAdapters.Purchase_FinalTableAdapter purchase_FinalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNetAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalVatAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAMTDataGridViewTextBoxColumn;
    }
}