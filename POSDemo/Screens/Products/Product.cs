using POSDemo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSDemo.Screens.Products
{
    public partial class Product : Form
    {
        POSTutEntities db = new POSTutEntities();
        string imagePath = "";
        public Product()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName;
                pictureBox1.ImageLocation = dialog.FileName;

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPName.Text==""|| txtBarcode.Text == "" || txtPrice.Text == "" )
            {
                MessageBox.Show("Please complete all fields");
            }
          else
            {
                
                POSDemo.DB.Product p = new POSDemo.DB.Product();
                p.Name = txtPName.Text;
                p.Code = txtBarcode.Text;
                p.Notes = txtNotes.Text;

                int qty, price;
                int.TryParse(txtQty.Text,out qty);
                int.TryParse(txtPrice.Text,out price);

                p.Price = price;
                p.Quantity = qty;

                db.Products.Add(p);
                db.SaveChanges();
                MessageBox.Show("The product is saved");

                if ( imagePath != "")
                {
                    string newPath = $"{Environment.CurrentDirectory}\\Images\\Products\\{p.Id}.png";
                    File.Copy(imagePath, newPath);

                    p.Image = newPath;
                    db.SaveChanges();
                }


                
            }


            

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
