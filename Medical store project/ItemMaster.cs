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
    public partial class ItemMaster : Form
    {
        public int ch,id;
        public ItemMaster(Medical_store.Mdi_parent1 parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        private void ItemMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet1.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.medicalDataSet1.Stock);
            // TODO: This line of code loads data into the 'medicalDataSet._Item_master' table. You can move, or remove it, as needed.
            this.item_masterTableAdapter.Fill(this.medicalDataSet._Item_master);

            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            groupBox3.Enabled=false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

            con.Open();

            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM [Item-master]", con);
            DataSet ds = new DataSet();
            adptr.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            int b = (dt.Rows.Count);
            b++;
            textBox1.Text = b.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new button
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

            con.Open();

            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM [Item-master]", con);
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


                if (con.State == ConnectionState.Closed)
                    con.Open();
                //insert query  
                SqlCommand cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                int a = 0;
                cmd.CommandText = "INSERT INTO [Item-master] VALUES('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO Stock([Company-Name],[Item-id],[Sale-QTY],[Purchase-QTY],[Available-QTY])VALUES ('" + comboBox1.Text + "','" + textBox2.Text + "','" + a + "','" + a + "','" + a + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is succesfully added", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.Connection.Close();
                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM [Item-master]", con);
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
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
        }

        private void button4_Click(object sender, EventArgs e)
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

                cmd.CommandText = "UPDATE [Item-master] SET [Sr-NO] = '" + textBox1.Text + "',[Company-Name] = '" + comboBox1.Text + "',[Item-id]='" + textBox2.Text + "', Prize ='" + textBox3.Text + "' WHERE [Item-id] ='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is succesfully updated", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Connection.Close();

                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM [Item-master]", con);
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



                cmd.CommandText = "select * from [Item-master]";
                DialogResult result = MessageBox.Show("Do You Really Want TO Delete This Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    textBox1.Focus();
                }
                else
                {
                    cmd.CommandText = "DELETE FROM [Item-master] WHERE [Item-id]= '" + textBox2.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Record is deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                cmd.Connection.Close();

                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM [Item-master]", con);
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

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            radioButton1.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //search Ok button
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (ch == 1)
                {
                    cmd.CommandText = "SELECT * FROM [Item-master] WHERE [Item-id] = '" + textBox4.Text + "' ";
                    SqlDataAdapter adptr = new SqlDataAdapter(cmd.CommandText, conn);
                    DataSet ds = new DataSet();
                    adptr.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Record Found", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //groupBox3.Hide();

                    int s = int.Parse(textBox4.Text);
                    s--;
                    groupBox1.Show();

                    textBox1.Text = (dt.Rows[s][0]).ToString();
                    comboBox1.Text = (dt.Rows[s][1]).ToString();
                    textBox2.Text = (dt.Rows[s][2]).ToString();
                    textBox3.Text = (dt.Rows[s][3]).ToString();



                    textBox1.Focus();

                }
                if (ch == 2)
                {
                    cmd.CommandText = "SELECT * FROM [Item-master] WHERE [Company-Name] = '" + textBox5.Text + "' ";
                    SqlDataAdapter adptr = new SqlDataAdapter(cmd.CommandText, conn);
                    DataSet ds = new DataSet();
                    adptr.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    MessageBox.Show((dt.Rows.Count).ToString(), "No.Of Record Found", MessageBoxButtons.OK);

                }
                if (ch == 3)
                {
                    cmd.CommandText = "SELECT * FROM [Item-master] WHERE Prize = '" + textBox6.Text + "' ";
                    SqlDataAdapter adptr = new SqlDataAdapter(cmd.CommandText, conn);
                    DataSet ds = new DataSet();
                    adptr.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    MessageBox.Show((dt.Rows.Count).ToString(), "No.Of Record Found", MessageBoxButtons.OK);

                }

                //groupBox1.Hide();
                //buttonRefresh.Show();
                conn.Close();
            }
            catch (Exception s)
            {
                //MessageBox.Show(s.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //next button
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [Item-master]", con);

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
                    button5.Enabled = true;
                    button10.Enabled = true;

                    textBox1.Text = (dt.Rows[id - 1][0]).ToString();
                    comboBox1.Text = (dt.Rows[id - 1][1]).ToString();
                    textBox2.Text = (dt.Rows[id - 1][2]).ToString();
                    textBox3.Text = (dt.Rows[id - 1][3]).ToString();



                    //textBox1.Focus();
                    con.Close();
                }
                else
                {
                    button5.Enabled = false;
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Last button
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [Item-master]", con);

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
                    comboBox1.Text = (dt.Rows[id][1]).ToString();
                    textBox2.Text = (dt.Rows[id][2]).ToString();
                    textBox3.Text = (dt.Rows[id][3]).ToString();



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
            //last button
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [Item-master]", con);

                DataSet ds = new DataSet();

                adptr.Fill(ds);

                DataTable dt = ds.Tables[0];
                int id = dt.Rows.Count;
                id--;

                if (id == 0)
                {
                    MessageBox.Show("database is Empty");
                }
                else
                {
                    button3.Enabled = true;
                    button9.Enabled = true;

                    textBox1.Text = (dt.Rows[0][0]).ToString();
                    comboBox1.Text = (dt.Rows[0][1]).ToString();
                    textBox2.Text = (dt.Rows[0][2]).ToString();
                    textBox3.Text = (dt.Rows[0][3]).ToString();



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
            //Previous button
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [Item-master]", con);

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
                    button5.Enabled = true;
                    button10.Enabled = true;

                    textBox1.Text = (dt.Rows[id - 1][0]).ToString();
                    comboBox1.Text = (dt.Rows[id - 1][1]).ToString();
                    textBox2.Text = (dt.Rows[id - 1][2]).ToString();
                    textBox3.Text = (dt.Rows[id - 1][3]).ToString();



                    //textBox1.Focus();
                    con.Close();
                }
                else
                {
                    button10.Enabled = false;
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ch = 1;
                textBox4.Enabled = true;
                textBox5.Enabled = false;
                textBox6.Enabled = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ch = 2;
                textBox4.Enabled = false;
                textBox5.Enabled = true;
                textBox6.Enabled = false;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ch = 3;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = true;

            }
        }
    }
}
