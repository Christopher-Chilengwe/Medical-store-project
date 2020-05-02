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
    public partial class PurchaseReg : Form
    {
        public PurchaseReg(Medical_store.Mdi_parent1 parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        private void PurchaseReg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet5._Purchase_Final' table. You can move, or remove it, as needed.
           // this.purchase_FinalTableAdapter.Fill(this.medicalDataSet5._Purchase_Final);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Total AMT
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=HIREN-9CF1490E8-9CF1490E8-9CF1490E8-9CF1490E8-9CF1490E8-9CF1490E8;Initial Catalog=Medical;Integrated Security=True";

                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "select [Bill-No],Date,[Party-Name],[Total-Net-AMT],[Total-Vat-AMT],[Total-AMT] FROM [Purchase-Final]";
                SqlDataReader dar = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(dar);

                dataGridView1.DataSource = dt;

                double total = 0;
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                   
                    total += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value.ToString().Trim());
                    
                    textBox1.Text = total.ToString().Trim();
                   

                }
                //textBox1.Text = total.ToString().Trim();
                con.Close();
            }
            catch (Exception S)
            {
                //MessageBox.Show(S.Message);
            }

        }
    }
}
