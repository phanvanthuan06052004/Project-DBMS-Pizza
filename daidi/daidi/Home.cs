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
    public partial class Home : Form
    {
        bool sibar;
        bool Menu;
        public Home()
        {
            InitializeComponent();
        }

        private void SibarTImer_Tick(object sender, EventArgs e)
        {
            if (sibar)
            {
                pnlSibar.Width -= 10;
                if (pnlSibar.Width == pnlSibar.MinimumSize.Width)
                {
                    sibar = false;
                    SibarTImer.Stop();
                }
            }
            else
            {
                pnlSibar.Width += 10;
                if (pnlSibar.Width == pnlSibar.MaximumSize.Width)
                {
                    sibar = true;
                    SibarTImer.Stop();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SibarTImer.Start();
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (Menu)
            {
                pnlMenu.Height += 10;
                if (pnlMenu.Height == pnlMenu.MaximumSize.Height)
                {
                    Menu = false;
                    MenuTimer.Stop();
                }
            }
            else
            {
                pnlMenu.Height -= 10;
                if (pnlMenu.Height == pnlMenu.MinimumSize.Height)
                {
                    Menu = true;
                    MenuTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();
        }

        private void pnlSibar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
