using POSDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDemo.Screens.Products
{
    public partial class ProductList : Form
    {
        POSTutEntities db = new POSTutEntities();


        public ProductList()
        {
            InitializeComponent();


        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.pOSTutDataSet.Product);

        }

       

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                dataGridView1.DataSource = db.Products.Where(x => x.Code == txtBarcode.Text).ToList();
            }
            else
            {
                dataGridView1.DataSource = db.Products.Where(x => x.Code == txtBarcode.Text || x.Name.Contains(txtName.Text)).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var result = db.Products.SingleOrDefault(x => x.Id == id);
            txtFormBarcode.Text = result.Code;
            txtPName.Text = result.Name;
            txtNotes.Text = result.Notes;
            txtPrice.Text = result.Price.ToString();
            txtQty.Text = result.Quantity.ToString();
            pictureBox1.ImageLocation = result.Image;
        }
    }
}
