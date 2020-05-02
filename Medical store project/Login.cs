using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet6.Login' table. You can move, or remove it, as needed.
            //this.loginTableAdapter.Fill(this.medicalDataSet6.Login);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Define object of SqlConnection and paasing of ConnectioString copied from database property
                SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = @"Data Source=SAGAR-C2F6419CA;Initial Catalog=info;Integrated Security=True";
                conn.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                //Connection with Database starts
                conn.Open();

                //Create object of SqlAdapter and pass the query and object of ConnectionString
                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM Login", conn);

                //Create object of Dataset 
                DataSet ds = new DataSet();

                //dataset is fiiled with dataAdapter
                adptr.Fill(ds);

                //create object of DataTable and assign the table to it
                DataTable dt = ds.Tables[0];

                //loops start
                Boolean b = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //comparision with the username and password entered
                    if ((textBox1.Text).Equals((dt.Rows[i][0]).ToString()) && (textBox2.Text).Equals((dt.Rows[i][1]).ToString()))
                    {
                        MessageBox.Show("You Are Successfully Loged in...", "Wel-Come To Medical-Store-Management-System", MessageBoxButtons.OK, MessageBoxIcon.None);

                        //shows the mdi form and hide the login form
                        Mdi_parent1 childMdi = new Mdi_parent1();
                        childMdi.Show();
                        this.Hide();
                        b = true;
                        break;
                    }
                }

                // if User name and password are not matched
                if (!b)
                {
                    MessageBox.Show("Invalid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }

                // Closing of database
                conn.Close();
            }
            finally
            {
            }
        }
    }
}
