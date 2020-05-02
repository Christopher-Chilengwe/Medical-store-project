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
    public partial class loginEditcs : Form
    {
        public loginEditcs(Medical_store.Mdi_parent1 parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Button
            TextBox1.Text = "";
            TextBox2.Text = "";
            textBox3.Text = "";
            TextBox1.Focus();
        }

        private void loginEditcs_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            textBox3.Text = "";
            TextBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //add button
            //If three of one field is empty then invalid;
            if (TextBox1.Text.Equals("") || TextBox2.Text.Equals("") || textBox3.Text.Equals(""))
            {
                MessageBox.Show("Invalid User Name Or Password", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBox1.Focus();
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

                try
                {
                    conn.Open();

                    SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM Login", conn);

                    DataSet ds = new DataSet();

                    adptr.Fill(ds);

                    DataTable dt = ds.Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //Condition for checking existance of username;
                        if (TextBox1.Text == (dt.Rows[i][0]).ToString())
                        {
                            MessageBox.Show("Enter Different User Name", "User Name Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TextBox1.Focus();
                            break;
                        }
                    }
                    //checking of password matching
                    if (TextBox2.Text == textBox3.Text)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = "INSERT INTO Login VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "')";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("You Account Has Been Successfully Created", "CONGRATULATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Password Does Not Match", "Re-Enter PassWord", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (result == DialogResult.Retry)
                        {
                            TextBox2.Focus();
                        }
                        else
                        {
                            button5.Focus();
                        }
                    }
                    conn.Close();
                }
                catch (Exception s)
                {
                    MessageBox.Show(s.Message);
                }
                finally
                {
                    //finally it will clears all the fields;
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    textBox3.Text = "";
                    TextBox1.Focus();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //delete Account
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

            try
            {
                conn.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM Login", conn);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                DataTable dt = ds.Tables[0];
                int t = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (TextBox1.Text == (dt.Rows[i][0]).ToString() && TextBox2.Text == (dt.Rows[i][1]).ToString())
                    {
                        DialogResult result = MessageBox.Show("Do you really want to delete your account", "Confirm to delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            if (TextBox2.Text == textBox3.Text)
                            {
                                SqlCommand cmd = new SqlCommand();
                                cmd = conn.CreateCommand();
                                cmd.CommandType = CommandType.Text;

                                cmd.CommandText = "DELETE FROM Login WHERE [User-Name]=  '" + TextBox1.Text + "' ";
                                cmd.ExecuteNonQuery();
                                TextBox1.Focus();
                                TextBox2.Text = "";
                                textBox3.Text = "";
                                MessageBox.Show("Your account has been deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else
                        {
                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            textBox3.Text = "";
                            TextBox1.Focus();
                        }
                        t++;
                        break;
                    }

                }
                if (t == 0)
                {
                    DialogResult result = MessageBox.Show("User Name and ID didn't get Matched", "Information Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Retry)
                    {
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        textBox3.Text = "";
                        TextBox1.Focus();
                    }
                    else
                    {
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        textBox3.Text = "";
                        TextBox1.Focus();

                    }
                }
                conn.Close();
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}