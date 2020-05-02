namespace Medical_store
{
    partial class loginEditcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginEditcs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalDataSet6 = new Medical_store.MedicalDataSet6();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTableAdapter = new Medical_store.MedicalDataSet6TableAdapters.LoginTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Medical_store.MedicalDataSet6TableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(83, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 42);
            this.label3.TabIndex = 19;
            this.label3.Text = "Medical Store Management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.TextBox1);
            this.groupBox1.Controls.Add(this.TextBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 179);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Retype Password :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(315, 129);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 24;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "User-Name", true));
            this.TextBox1.Location = new System.Drawing.Point(315, 19);
            this.TextBox1.MaxLength = 25;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(160, 20);
            this.TextBox1.TabIndex = 22;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.medicalDataSet6;
            // 
            // medicalDataSet6
            // 
            this.medicalDataSet6.DataSetName = "MedicalDataSet6";
            this.medicalDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginBindingSource, "Password", true));
            this.TextBox2.Location = new System.Drawing.Point(315, 75);
            this.TextBox2.MaxLength = 20;
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '*';
            this.TextBox2.Size = new System.Drawing.Size(160, 20);
            this.TextBox2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password :";
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Please Enter Your ID first";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LoginTableAdapter = this.loginTableAdapter;
            this.tableAdapterManager.UpdateOrder = Medical_store.MedicalDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(426, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 28);
            this.button2.TabIndex = 24;
            this.button2.Text = "&EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(78, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "&NEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(183, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 28);
            this.button5.TabIndex = 23;
            this.button5.Text = "&ADD";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(302, 315);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 28);
            this.button7.TabIndex = 25;
            this.button7.Text = "&DELETE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // loginEditcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(587, 371);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "loginEditcs";
            this.Text = "loginEditcs";
            this.Load += new System.EventHandler(this.loginEditcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private MedicalDataSet6 medicalDataSet6;
        private Medical_store.MedicalDataSet6TableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.Label label4;
        private Medical_store.MedicalDataSet6TableAdapters.TableAdapterManager tableAdapterManager;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
    }
}