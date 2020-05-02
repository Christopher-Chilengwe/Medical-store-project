using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medical_store
{
    public partial class itemStock : Form
    {
        public itemStock(Medical_store.Mdi_parent1 parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
        }

        private void itemStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet1.Stock' table. You can move, or remove it, as needed.
          //  this.stockTableAdapter.Fill(this.medicalDataSet1.Stock);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
