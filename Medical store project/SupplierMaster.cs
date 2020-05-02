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
    public partial class SupplierMaster : Form
    {
        public int id;
        public SupplierMaster(Medical_store.Mdi_parent1 parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        private void SupplierMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet2._supplier_master' table. You can move, or remove it, as needed.
            //this.supplier_masterTableAdapter.Fill(this.medicalDataSet2._supplier_master);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new button
            //textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

            con.Open();

            SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM [supplier-master]", con);
            DataSet ds = new DataSet();
            adptr.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            int b = (dt.Rows.Count);
            b++;
            textBox1.Text = b.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //insert
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

                con.Open();


                //insert query  
                SqlCommand cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "INSERT INTO supplier-master VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                cmd.CommandText = "INSERT INTO [supplier-master] VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is succesfully added", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.Connection.Close();

                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM [supplier-master]", con);
                DataSet ds = new DataSet();
                adptr.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                int b = (dt.Rows.Count);
                b++;
                textBox1.Text = b.ToString();


            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
            finally
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

                con.Open();

                //update query  
                SqlCommand cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "UPDATE [supplier-master] SET [supplier-id]='" + textBox1.Text + "',[supllier-name]='" + textBox2.Text + "',[address]='" + textBox3.Text + "',[city]='" + textBox4.Text + "',[Mo-No]='" + textBox5.Text + "',[Phone-No]='" + textBox6.Text + "' WHERE  [supplier-id]= '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is succesfully updated", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Connection.Close();

                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM [supplier-master]", con);
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

        private void button5_Click(object sender, EventArgs e)
        {
            //delete query 
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                //con.ConnectionString = @"Data Source=PRAKASH\SQLEXPRESS;Initial Catalog=info;Integrated Security=True";
                con.Open();


                SqlCommand cmd = new SqlCommand();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;


                cmd.CommandText = "select * from [supplier-master]";
                DialogResult result = MessageBox.Show("Do You Really Want TO Delete This Record", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    textBox1.Focus();
                }
                else
                {
                    cmd.CommandText = "DELETE FROM [supplier-master] WHERE [supplier-id]= '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Record is deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                cmd.Connection.Close();

                SqlDataAdapter adptr = new SqlDataAdapter("SELECT * FROM [supplier-master]", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Next button
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [supplier-master]", con);

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
                    button2.Enabled = true;
                    button10.Enabled = true;

                    textBox1.Text = (dt.Rows[id - 1][0]).ToString();
                    textBox2.Text = (dt.Rows[id - 1][1]).ToString();
                    textBox3.Text = (dt.Rows[id - 1][2]).ToString();
                    textBox4.Text = (dt.Rows[id - 1][3]).ToString();
                    textBox5.Text = (dt.Rows[id - 1][4]).ToString();
                    textBox6.Text = (dt.Rows[id - 1][5]).ToString();

                    //textBox1.Focus();
                    con.Close();
                }
                else
                {
                    button2.Enabled = false;
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

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [supplier-master]", con);

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
                    button8.Enabled = true;
                    button9.Enabled = true;

                    textBox1.Text = (dt.Rows[id][0]).ToString();
                    textBox2.Text = (dt.Rows[id][1]).ToString();
                    textBox3.Text = (dt.Rows[id][2]).ToString();
                    textBox4.Text = (dt.Rows[id][3]).ToString();
                    textBox5.Text = (dt.Rows[id][4]).ToString();
                    textBox6.Text = (dt.Rows[id][5]).ToString();



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
            //First buttom
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [supplier-master]", con);

                DataSet ds = new DataSet();

                adptr.Fill(ds);

                DataTable dt = ds.Tables[0];
                int id = dt.Rows.Count;
                id--;
                if (id == 0)
                {
                    MessageBox.Show("database is empty");
                }
                else
                {
                    button8.Enabled = true;
                    button9.Enabled = true;

                    textBox1.Text = (dt.Rows[0][0]).ToString();
                    textBox2.Text = (dt.Rows[0][1]).ToString();
                    textBox3.Text = (dt.Rows[0][2]).ToString();
                    textBox4.Text = (dt.Rows[0][3]).ToString();
                    textBox5.Text = (dt.Rows[0][4]).ToString();
                    textBox6.Text = (dt.Rows[0][5]).ToString();

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
            //previous buttom
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataAdapter adptr = new SqlDataAdapter("Select * From [supplier-master]", con);

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
                    button2.Enabled = true;
                    button10.Enabled = true;

                    textBox1.Text = (dt.Rows[id - 1][0]).ToString();
                    textBox2.Text = (dt.Rows[id - 1][1]).ToString();
                    textBox3.Text = (dt.Rows[id - 1][2]).ToString();
                    textBox4.Text = (dt.Rows[id - 1][3]).ToString();
                    textBox5.Text = (dt.Rows[id - 1][4]).ToString();
                    textBox6.Text = (dt.Rows[id - 1][5]).ToString();



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
    }
}
