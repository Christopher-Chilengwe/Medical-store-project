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
    
    public partial class Info : Form
    {
        public int id;
        public Info(Medical_store.Mdi_parent1 parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            
        }

        private void Info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet.info' table. You can move, or remove it, as needed.
            //this.infoTableAdapter.Fill(this.medicalDataSet.info);
           
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new button
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

            //textBox1.Focus();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

					

            con.Open();

            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM info", con);
            DataSet ds = new DataSet();
            adptr.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            int b = (dt.Rows.Count);
            b++;
            textBox1.Text = b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //insert query  
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

                con.Open();

                //insert query  
                SqlCommand cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Info VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is succesfully added", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.Connection.Close();

                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM info", con);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;


            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
            finally
            {
                //After succeesful insertion, all the fields will be cleared
                //textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                //textBoxSrNo.Text = textBoxSrNo.Text + 1;
                //textBox1.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //delete query 
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

                con.Open();

                //delete query  
                SqlCommand cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [info]";
                DialogResult result = MessageBox.Show("Do You Really Want TO Delete This Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    textBox1.Focus();
                }
                else
                {
                    cmd.CommandText = "DELETE FROM [info] WHERE Id= '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Record is deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //cmd.CommandText = "select * from [info]";


                cmd.Connection.Close();

                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM info", con);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //update query  
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

                con.Open();

                //update query  
                SqlCommand cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "UPDATE info SET Id ='" + textBox1.Text + "', PartyName ='" + textBox2.Text + "', Name ='" + textBox3.Text + "', Gender ='" + comboBox1.Text + "', Age ='" + textBox5.Text + "', Address ='" + textBox6.Text + "', [Contac-No] ='" + textBox7.Text + "', [Mo-No] ='" + textBox8.Text + "', [Email Address] ='" + textBox9.Text + "', Remarks ='" + textBox10.Text + "' WHERE Id = '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is succesfully updated", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Connection.Close();

                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM info", con);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;

            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //next button
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [info]", con);

                DataSet ds = new DataSet();

                adptr.Fill(ds);

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i][0] = (i + 1);
                }
                id = int.Parse(textBox1.Text);
                id = id + 1;
                if (id <= dt.Rows.Count)
                {
                    button1.Enabled = true;
                    button10.Enabled = true;
                    textBox1.Text = (dt.Rows[id - 1][0]).ToString();
                    textBox2.Text = (dt.Rows[id - 1][1]).ToString();
                    textBox3.Text = (dt.Rows[id - 1][2]).ToString();
                    comboBox1.Text = (dt.Rows[id - 1][3]).ToString();
                    textBox5.Text = (dt.Rows[id - 1][4]).ToString();
                    textBox6.Text = (dt.Rows[id - 1][5]).ToString();
                    textBox7.Text = (dt.Rows[id - 1][6]).ToString();
                    textBox8.Text = (dt.Rows[id - 1][7]).ToString();
                    textBox9.Text = (dt.Rows[id - 1][8]).ToString();
                    textBox10.Text = (dt.Rows[id - 1][9]).ToString();


                    //textBox1.Focus();
                    con.Close();
                }
                else
                {
                    button1.Enabled = false;
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Last button
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [info]", con);

                DataSet ds = new DataSet();

                adptr.Fill(ds);

                DataTable dt = ds.Tables[0];
                int id = dt.Rows.Count;
                id--;

                if (id == 0)
                {
                    MessageBox.Show("Database is empty");
                }
                else
                {
                    button3.Enabled = true;
                    button9.Enabled = true;

                    textBox1.Text = (dt.Rows[id][0]).ToString();
                    textBox2.Text = (dt.Rows[id][1]).ToString();
                    textBox3.Text = (dt.Rows[id][2]).ToString();
                    comboBox1.Text = (dt.Rows[id][3]).ToString();
                    textBox5.Text = (dt.Rows[id][4]).ToString();
                    textBox6.Text = (dt.Rows[id][5]).ToString();
                    textBox7.Text = (dt.Rows[id][6]).ToString();
                    textBox8.Text = (dt.Rows[id][7]).ToString();
                    textBox9.Text = (dt.Rows[id][8]).ToString();
                    textBox10.Text = (dt.Rows[id][9]).ToString();


                    //textBox1.Focus();
                    con.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //First button
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [info]", con);

                DataSet ds = new DataSet();

                adptr.Fill(ds);

                DataTable dt = ds.Tables[0];
                int id = dt.Rows.Count;
                id--;

                if (id == 0)
                {
                    MessageBox.Show("Database is Empty");
                }
                else
                {
                    button3.Enabled = true;
                    button9.Enabled = true;

                    textBox1.Text = (dt.Rows[0][0]).ToString();
                    textBox2.Text = (dt.Rows[0][1]).ToString();
                    textBox3.Text = (dt.Rows[0][2]).ToString();
                    comboBox1.Text = (dt.Rows[0][3]).ToString();
                    textBox5.Text = (dt.Rows[0][4]).ToString();
                    textBox6.Text = (dt.Rows[0][5]).ToString();
                    textBox7.Text = (dt.Rows[0][6]).ToString();
                    textBox8.Text = (dt.Rows[0][7]).ToString();
                    textBox9.Text = (dt.Rows[0][8]).ToString();
                    textBox10.Text = (dt.Rows[0][9]).ToString();


                    //textBox1.Focus();
                    con.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //previous button
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [info]", con);

                DataSet ds = new DataSet();

                adptr.Fill(ds);

                DataTable dt = ds.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i][0] = (i + 1);
                }
                id = int.Parse(textBox1.Text);
                id = id - 1;
                if (id > 0)
                {
                    button1.Enabled = true;
                    button10.Enabled = true;
                    textBox1.Text = (dt.Rows[id - 1][0]).ToString();
                    textBox2.Text = (dt.Rows[id - 1][1]).ToString();
                    textBox3.Text = (dt.Rows[id - 1][2]).ToString();
                    comboBox1.Text = (dt.Rows[id - 1][3]).ToString();
                    textBox5.Text = (dt.Rows[id - 1][4]).ToString();
                    textBox6.Text = (dt.Rows[id - 1][5]).ToString();
                    textBox7.Text = (dt.Rows[id - 1][6]).ToString();
                    textBox8.Text = (dt.Rows[id - 1][7]).ToString();
                    textBox9.Text = (dt.Rows[id - 1][8]).ToString();
                    textBox10.Text = (dt.Rows[id - 1][9]).ToString();


                    textBox1.Focus();
                    con.Close();
                }
                else
                {
                    button1.Enabled = false;
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
