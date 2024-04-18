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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
            OpenChildForm(new frmRepoManagement());
        }

        private Form curentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
            curentFormChild = childForm;
            childForm.Width = 1343;
            childForm.Height = 598; 
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnManage.Controls.Add(childForm);
            pnManage.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void btnProMana_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRepoManagement());

        }

        private void btnSizeMana_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageSize());
        }

        private void btnManaCus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagemrentCustomer());
        }

        private void btnManaImp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagementImport());
        }

        private void btnManaOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagementOrder());
        }

        private void pnManage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
