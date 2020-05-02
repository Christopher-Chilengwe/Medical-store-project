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
    public partial class Mdi_parent1 : Form
    {
        private int childFormNumber = 0;

        public Mdi_parent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {

        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {

        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info child = new Info(this);
            child.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void modelMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemMaster child = new ItemMaster(this);
            child.Show();
        }

        private void supplierMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierMaster child = new SupplierMaster(this);
            child.Show();
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customermaster child = new Customermaster(this);
            child.Show();
        }

        private void purchaseLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurechaseBill child = new PurechaseBill(this);
            child.Show();
        }

        private void salesLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleBill child = new SaleBill(this);
            child.Show();
        }

        private void salesRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesreg child = new salesreg(this);
            child.Show();
        }

        private void purchaseRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReg child = new PurchaseReg(this);
            child.Show();
        }

        private void itemStockRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemStock child = new itemStock(this);
            child.Show();
        }

        private void calenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calander child = new Calander(this);
            child.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactUs child = new ContactUs(this);
            child.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("wordpad");
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            loginEditcs child = new loginEditcs(this);
            child.Show();
        }
    }
}
