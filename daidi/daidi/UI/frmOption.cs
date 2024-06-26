﻿using System;
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
    public partial class frmOption : Form
    {
        frmShiftManagement frmShift;
        frmRevenue Revenue;
        FrmPizzaManagement frmPizzaMana;
        frmEmployManagement employee;
        Management management;
        public frmOption()
        {
            InitializeComponent();
        }


        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ptrShiftManagement_Click(object sender, EventArgs e)
        {
            frmShift = new frmShiftManagement();
            frmShift.Show();
        }

        private void ptrEmployeeManagement_Click(object sender, EventArgs e)
        {
            employee = new frmEmployManagement();
            employee.Show();
        }

        private void ptrOrderPizza_Click(object sender, EventArgs e)
        {
            frmPizzaMana = new FrmPizzaManagement();
            //this.Hide();
            frmPizzaMana.Show();
        }

        private void ptrRepoManagement_Click(object sender, EventArgs e)
        {
            management = new Management();
            management.Show();
        }

        private void ptrRevenue_Click(object sender, EventArgs e)
        {
            Revenue = new frmRevenue();
            Revenue.Show();
        }
    }
}
