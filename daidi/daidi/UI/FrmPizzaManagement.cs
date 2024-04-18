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

    public partial class FrmPizzaManagement : Form
    {
        public FrmPizzaManagement()
        {
            InitializeComponent();
            OpenChildForm(new frmHomePizza());
        }

        bool sibar;
        private Form curentFormChild;//khai bao frm lưu form hiện tại đang đứng
        private void OpenChildForm(Form childForm)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close(); //kiểm tra xem form hiện tại đang mở thì đóng đi để mở form khác khi nhấn button
            }
            curentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnPizza.Controls.Add(childForm);
            pnPizza.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //phân xử lí thanh sibar
        private void sibarTimer_Tick(object sender, EventArgs e)
        {
            if (sibar)
            {
                pnlSibar.Width += 10;
                if (pnlSibar.Width >= pnlSibar.MaximumSize.Width)
                {
                    sibar = false;
                    sibarTimer.Stop();

                    pnlHome.Width = pnlSibar.Width;
                    pnlMenu.Width = pnlSibar.Width;
                    pnlLogout.Width = pnlSibar.Width;

                }
            }
            else
            {
                pnlSibar.Width -= 10;
                if (pnlSibar.Width <= pnlSibar.MinimumSize.Width)
                {
                    sibar = true;
                    sibarTimer.Stop();

                    pnlHome.Width = pnlSibar.Width;
                    pnlMenu.Width = pnlSibar.Width;
                    pnlLogout.Width = pnlSibar.Width;

                }
            }
        }
        //phân xử lí thanh sibar
        private void btnSibar_Click(object sender, EventArgs e)
        {
            sibarTimer.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMenu());
        }





        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHomePizza());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng Form
            }
        }

    }
}
