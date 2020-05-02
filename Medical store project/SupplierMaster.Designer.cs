namespace Medical_store
{
    partial class SupplierMaster
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.supplier_masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet2 = new Medical_store.MedicalDataSet2();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_masterTableAdapter = new Medical_store.MedicalDataSet2TableAdapters.supplier_masterTableAdapter();
            this.tableAdapterManager = new Medical_store.MedicalDataSet2TableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_masterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 269);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplier_masterBindingSource, "address", true));
            this.textBox3.Location = new System.Drawing.Point(127, 101);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 40);
            this.textBox3.TabIndex = 3;
            // 
            // supplier_masterBindingSource
            // 
            this.supplier_masterBindingSource.DataMember = "supplier-master";
            this.supplier_masterBindingSource.DataSource = this.medicalDataSet2;
            // 
            // medicalDataSet2
            // 
            this.medicalDataSet2.DataSetName = "MedicalDataSet2";
            this.medicalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplier_masterBindingSource, "Phone-No", true));
            this.textBox6.Location = new System.Drawing.Point(127, 230);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(149, 22);
            this.textBox6.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(19, 233);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(70, 16);
            this.Label6.TabIndex = 24;
            this.Label6.Text = "Phone No";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplier_masterBindingSource, "Mo-No", true));
            this.textBox5.Location = new System.Drawing.Point(127, 199);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(149, 22);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplier_masterBindingSource, "city", true));
            this.textBox4.Location = new System.Drawing.Point(127, 162);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 22);
            this.textBox4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "MO.NO";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplier_masterBindingSource, "supllier-name", true));
            this.textBox2.Location = new System.Drawing.Point(127, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Address";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplier_masterBindingSource, "supplier-id", true));
            this.textBox1.Location = new System.Drawing.Point(129, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Supplier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Supplier ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(414, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 228);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customermaster";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(296, -297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Supplier Master";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(79, 118);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 16;
            this.button10.Text = "<";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(83, 167);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "<<";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(177, 167);
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
            this.button2.Location = new System.Drawing.Point(177, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(79, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "&New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(229, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "&Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(34, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 28);
            this.button5.TabIndex = 10;
            this.button5.Text = "&Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(128, 66);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 28);
            this.button6.TabIndex = 9;
            this.button6.Text = "&Modify";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(181, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 28);
            this.button7.TabIndex = 8;
            this.button7.Text = "&Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(214, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(317, 36);
            this.label7.TabIndex = 21;
            this.label7.Text = "SUPPLIER MASTER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplieridDataGridViewTextBoxColumn,
            this.suplliernameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.moNoDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplier_masterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier-id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "supplier-id";
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            // 
            // suplliernameDataGridViewTextBoxColumn
            // 
            this.suplliernameDataGridViewTextBoxColumn.DataPropertyName = "supllier-name";
            this.suplliernameDataGridViewTextBoxColumn.HeaderText = "supllier-name";
            this.suplliernameDataGridViewTextBoxColumn.Name = "suplliernameDataGridViewTextBoxColumn";
            this.suplliernameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
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
            // supplier_masterTableAdapter
            // 
            this.supplier_masterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.supplier_masterTableAdapter = this.supplier_masterTableAdapter;
            this.tableAdapterManager.UpdateOrder = Medical_store.MedicalDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SupplierMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(772, 508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "SupplierMaster";
            this.Text = "SupplierMaster";
            this.Load += new System.EventHandler(this.SupplierMaster_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplier_masterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button6;
        internal System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MedicalDataSet2 medicalDataSet2;
        private System.Windows.Forms.BindingSource supplier_masterBindingSource;
        private Medical_store.MedicalDataSet2TableAdapters.supplier_masterTableAdapter supplier_masterTableAdapter;
        private Medical_store.MedicalDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
    }
}