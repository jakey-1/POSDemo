using POSDemo.Screens.Products;
using POSDemo.Screens.Users;
using System;
using System.Windows.Forms;

namespace POSDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStrDisplayProduct_Click(object sender, EventArgs e)
        {

        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrAddNUser_Click(object sender, EventArgs e)
        {
            NewUser frm = new NewUser();
            frm.Show();
        }

        private void toolStrAddProduct_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
        }

        private void toolStrReport_Click(object sender, EventArgs e)
        {

        }
    }
}
