using Repon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daidi
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            // Ví dụ cho một control trong frmMenu


        }

        private void Menu_Close(object sender, FormClosedEventArgs e)
        {
            //frmMenu = null;
        }

        private void productPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            GetViewProduct gw = new GetViewProduct();
            //productPanel.DataSource = gw.getProductView();
            // cBSize.DataSource = 
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Additem(string productName, string Price, Image ptcProduct, ComboBox product)
        {
            pnlProduct.Controls.Add(new UserControl1
            {
                ProductName = productName,
                Price = Price,
                ptcProduct = ptcProduct,
                ProductComboBox = product
            });
        }
    }
}
