using daidi.SERVICE;
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
    public partial class ManagementImport : Form
    {
        DBProvider dbProvider = new DBProvider();
        public ManagementImport()
        {
            InitializeComponent();
        }


        private void ManagementImport_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = dbProvider.GetProvider().Tables[0];
            dgvProvider.DataSource = table;
            dgvProvider.AutoResizeColumns();
        }

        private void dgvProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
