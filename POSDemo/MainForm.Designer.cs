
using System;

namespace POSDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrAddNUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrEditeProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrDisplayProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrBill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrPurchaseBill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrSalesBill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrReport = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrFile,
            this.toolStrUsers,
            this.toolStrProducts,
            this.toolStrCustomer,
            this.toolStrSuppliers,
            this.toolStrBill,
            this.toolStrReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrFile
            // 
            this.toolStrFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrClose});
            this.toolStrFile.Name = "toolStrFile";
            this.toolStrFile.Size = new System.Drawing.Size(49, 20);
            this.toolStrFile.Text = "الملف";
            // 
            // toolStrClose
            // 
            this.toolStrClose.Name = "toolStrClose";
            this.toolStrClose.Size = new System.Drawing.Size(100, 22);
            this.toolStrClose.Text = "اغلاق";
            this.toolStrClose.Click += new System.EventHandler(this.toolStrClose_Click);
            // 
            // toolStrUsers
            // 
            this.toolStrUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrAddNUser});
            this.toolStrUsers.Name = "toolStrUsers";
            this.toolStrUsers.Size = new System.Drawing.Size(81, 20);
            this.toolStrUsers.Text = "المستخدمون";
            // 
            // toolStrAddNUser
            // 
            this.toolStrAddNUser.Name = "toolStrAddNUser";
            this.toolStrAddNUser.Size = new System.Drawing.Size(180, 22);
            this.toolStrAddNUser.Text = "اضافة مستخدم جديد";
            this.toolStrAddNUser.Click += new System.EventHandler(this.toolStrAddNUser_Click);
            // 
            // toolStrProducts
            // 
            this.toolStrProducts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrAddProduct,
            this.toolStrEditeProduct,
            this.toolStrDisplayProduct});
            this.toolStrProducts.Name = "toolStrProducts";
            this.toolStrProducts.Size = new System.Drawing.Size(62, 20);
            this.toolStrProducts.Text = "المنتجات";
            // 
            // toolStrAddProduct
            // 
            this.toolStrAddProduct.Name = "toolStrAddProduct";
            this.toolStrAddProduct.Size = new System.Drawing.Size(180, 22);
            this.toolStrAddProduct.Text = "اضافة منتجات";
            this.toolStrAddProduct.Click += new System.EventHandler(this.toolStrAddProduct_Click);
            // 
            // toolStrEditeProduct
            // 
            this.toolStrEditeProduct.Name = "toolStrEditeProduct";
            this.toolStrEditeProduct.Size = new System.Drawing.Size(180, 22);
            this.toolStrEditeProduct.Text = "ادارة المنتجات";
            // 
            // toolStrDisplayProduct
            // 
            this.toolStrDisplayProduct.Name = "toolStrDisplayProduct";
            this.toolStrDisplayProduct.Size = new System.Drawing.Size(180, 22);
            this.toolStrDisplayProduct.Text = "عرض كل المنتجات";
            this.toolStrDisplayProduct.Click += new System.EventHandler(this.toolStrDisplayProduct_Click);
            // 
            // toolStrCustomer
            // 
            this.toolStrCustomer.Name = "toolStrCustomer";
            this.toolStrCustomer.Size = new System.Drawing.Size(52, 20);
            this.toolStrCustomer.Text = "العملاء";
            // 
            // toolStrSuppliers
            // 
            this.toolStrSuppliers.Name = "toolStrSuppliers";
            this.toolStrSuppliers.Size = new System.Drawing.Size(61, 20);
            this.toolStrSuppliers.Text = "الموردين";
            // 
            // toolStrBill
            // 
            this.toolStrBill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrPurchaseBill,
            this.toolStrSalesBill});
            this.toolStrBill.Name = "toolStrBill";
            this.toolStrBill.Size = new System.Drawing.Size(55, 20);
            this.toolStrBill.Text = "الفاتورة";
            // 
            // toolStrPurchaseBill
            // 
            this.toolStrPurchaseBill.Name = "toolStrPurchaseBill";
            this.toolStrPurchaseBill.Size = new System.Drawing.Size(151, 22);
            this.toolStrPurchaseBill.Text = "فاتورة مشتريات";
            // 
            // toolStrSalesBill
            // 
            this.toolStrSalesBill.Name = "toolStrSalesBill";
            this.toolStrSalesBill.Size = new System.Drawing.Size(151, 22);
            this.toolStrSalesBill.Text = "فاتورة مبيعات";
            // 
            // toolStrReport
            // 
            this.toolStrReport.Name = "toolStrReport";
            this.toolStrReport.Size = new System.Drawing.Size(47, 20);
            this.toolStrReport.Text = "تقارير";
            this.toolStrReport.Click += new System.EventHandler(this.toolStrReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "الموردين";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "العملاء";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(592, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "المنتجات";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(70, 227);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "التقارير";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(301, 227);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "فواتير المشتريات";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(576, 245);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "فواتير المبيعات";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 371);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolStrClose_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStrFile;
        private System.Windows.Forms.ToolStripMenuItem toolStrClose;
        private System.Windows.Forms.ToolStripMenuItem toolStrUsers;
        private System.Windows.Forms.ToolStripMenuItem toolStrAddNUser;
        private System.Windows.Forms.ToolStripMenuItem toolStrProducts;
        private System.Windows.Forms.ToolStripMenuItem toolStrAddProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStrEditeProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStrDisplayProduct;
        private System.Windows.Forms.ToolStripMenuItem toolStrCustomer;
        private System.Windows.Forms.ToolStripMenuItem toolStrSuppliers;
        private System.Windows.Forms.ToolStripMenuItem toolStrBill;
        private System.Windows.Forms.ToolStripMenuItem toolStrReport;
        private System.Windows.Forms.ToolStripMenuItem toolStrPurchaseBill;
        private System.Windows.Forms.ToolStripMenuItem toolStrSalesBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}