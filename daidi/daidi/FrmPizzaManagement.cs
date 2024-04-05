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

        frmMenu Menu;
        frmOrder Order;
        frmRevenue Revenue;


        bool sibar;
        public FrmPizzaManagement()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            mdiProp();

            Menu = new frmMenu();
            Menu.TopLevel = false;
            Menu.FormBorderStyle = FormBorderStyle.None;
            Menu.Dock = DockStyle.Fill; // Điều này làm cho frmMenu điền vào panel
            panel2.Controls.Add(Menu); // Thêm frmMenu vào panel pnlMenu

            Order = new frmOrder();
            Order.TopLevel = false;
            Order.FormBorderStyle = FormBorderStyle.None;
            Order.Dock = DockStyle.Fill; // Điều này làm cho frmMenu điền vào panel
            panel2.Controls.Add(Order);
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(255, 224, 192);
        }
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
                    pnlOrder.Width = pnlSibar.Width;
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
                    pnlOrder.Width = pnlSibar.Width;
                }
            }
        }

        private void btnSibar_Click(object sender, EventArgs e)
        {
            sibarTimer.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //if (Menu == null)
            //{
            //    Menu = new frmMenu();
            //    Menu.FormClosed += Menu_Close;
            //    Menu.MdiParent = this;
            //    Menu.Show();
            //}
            //else
            //{
            //    Menu.Activate();
            //}

             // Hiển thị pnlMenu nếu nó đã bị ẩn
            panel2.Visible = true;
    // Hiển thị frmMenu bên trong pnlMenu
            Menu.Show();
        }

        private void Menu_Close(object? sender, FormClosedEventArgs e)
        {
            Menu = null;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //if(Order == null)
            //{
            //    Order = new frmOrder();
            //    Order.FormClosed += Order_FrmClose;
            //    Order.MdiParent = this;
            //    Order.Show();
            //}
            //else 
            //{
            //    Order.Activate();
            //}

            // Hiển thị pnlMenu nếu nó đã bị ẩn
            panel2.Visible = true;
            // Hiển thị frmMenu bên trong pnlMenu
            Menu.Hide();
            Order.Show();
        }

        private void Order_FrmClose(object? sender, FormClosedEventArgs e)
        {
            Order = null;
        }
    }
}
