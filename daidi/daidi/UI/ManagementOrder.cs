using daidi.DAL;
using daidi.SERVICE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace daidi
{
    public partial class ManagementOrder : Form
    {
        DBOrder dbOrder = new DBOrder();
        GetConnection cnt = new GetConnection();
        public ManagementOrder()
        {
            InitializeComponent();
        }



        private void ManagementOrder_Load(object sender, EventArgs e)
        {
            dtpMaxOrder.Value = DateTime.Now;
            DataTable dt = new DataTable();
            dt = dbOrder.GetOrder().Tables[0];
            gwOrder.DataSource = dt;
            gwOrder.AutoResizeColumns();
        }

      

        private void btnSearchOr_Click(object sender, EventArgs e)
        {
            DataTable dtOrder = new DataTable();
            if (tbSearchOr.Text == "")
            {
                dtOrder = dbOrder.SearchOrderDate(dtpMinOrder.Value, dtpMaxOrder.Value);
            }
            else
            {
                dtOrder = dbOrder.SearchOrderID(tbSearchOr.Text);
            }
            if (dtOrder.Rows.Count > 0)
            {
                gwOrder.DataSource = dtOrder;

            }
            else
            {
                MessageBox.Show("Không tìm thấy mã hóa đơn!");
            }
        }

       

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = dbOrder.GetOrder().Tables[0];
            gwOrder.DataSource = dt;
            tbSearchOr.Text = null;
        }
    }
}
