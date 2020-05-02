namespace Medical_store
{
    partial class Customermaster
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_MasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet3 = new Medical_store.MedicalDataSet3();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.customer_MasterTableAdapter = new Medical_store.MedicalDataSet3TableAdapters.Customer_MasterTableAdapter();
            this.tableAdapterManager = new Medical_store.MedicalDataSet3TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_MasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(242, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Master";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.moNoDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customer_MasterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "Customer-Id";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "Customer-Id";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "Customer-Name";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer-Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // moNoDataGridViewTextBoxColumn
            // 
            this.moNoDataGridViewTextBoxColumn.DataPropertyName = "Mo-No";
            this.moNoDataGridViewTextBoxColumn.HeaderText = "Mo-No";
            this.moNoDataGridViewTextBoxColumn.Name = "moNoDataGridViewTextBoxColumn";
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "Phone-No";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "Phone-No";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            // 
            // customer_MasterBindingSource
            // 
            this.customer_MasterBindingSource.DataMember = "Customer-Master";
            this.customer_MasterBindingSource.DataSource = this.medicalDataSet3;
            // 
            // medicalDataSet3
            // 
            this.medicalDataSet3.DataSetName = "MedicalDataSet3";
            this.medicalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 264);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_MasterBindingSource, "Phone-No", true));
            this.textBox6.Location = new System.Drawing.Point(117, 229);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(167, 22);
            this.textBox6.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_MasterBindingSource, "Mo-No", true));
            this.textBox5.Location = new System.Drawing.Point(117, 199);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 22);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_MasterBindingSource, "City", true));
            this.textBox4.Location = new System.Drawing.Point(117, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_MasterBindingSource, "Address", true));
            this.textBox3.Location = new System.Drawing.Point(117, 105);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 39);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_MasterBindingSource, "Customer-Name", true));
            this.textBox2.Location = new System.Drawing.Point(117, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customer_MasterBindingSource, "Customer-Id", true));
            this.textBox1.Location = new System.Drawing.Point(119, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(9, 235);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(70, 16);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "MO.NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Customer ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(411, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 207);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Box";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(66, 120);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 16;
            this.button10.Text = "<";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(66, 154);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "<<";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(162, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(162, 154);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = ">>";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(162, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(66, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 29);
            this.button5.TabIndex = 10;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(218, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 29);
            this.button6.TabIndex = 9;
            this.button6.Text = "Modify";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(122, 31);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 29);
            this.button7.TabIndex = 8;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // customer_MasterTableAdapter
            // 
            this.customer_MasterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Customer_MasterTableAdapter = this.customer_MasterTableAdapter;
            this.tableAdapterManager.UpdateOrder = Medical_store.MedicalDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Customermaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(755, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Customermaster";
            this.Text = "Customermaster";
            this.Load += new System.EventHandler(this.Customermaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_MasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        internal System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button6;
        internal System.Windows.Forms.Button button7;
        private MedicalDataSet3 medicalDataSet3;
        private System.Windows.Forms.BindingSource customer_MasterBindingSource;
        private Medical_store.MedicalDataSet3TableAdapters.Customer_MasterTableAdapter customer_MasterTableAdapter;
        private Medical_store.MedicalDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
    }
}