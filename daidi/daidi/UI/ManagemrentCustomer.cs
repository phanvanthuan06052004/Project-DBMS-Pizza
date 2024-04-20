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
using System.Windows.Forms;

namespace daidi
{
    public partial class ManagemrentCustomer : Form
    {
        DBCustomer dBCustomer = new DBCustomer();
        DataTable dtCustomer;
        public ManagemrentCustomer()
        {
            InitializeComponent();
        }

        void ReloadData()
        {
            try
            {
                dtCustomer.Clear();
                dtCustomer = dBCustomer.GetCustomer().Tables[0];

                // Xóa các cột cũ (nếu có)
                dgvCustomer.Columns.Clear();

                // Đặt tên cột và liên kết với tên cột tương ứng trong DataTable
                dgvCustomer.AutoGenerateColumns = false;
                dgvCustomer.Columns.Add("CustomerID", "Customer ID");
                dgvCustomer.Columns["CustomerID"].DataPropertyName = "MaKH"; // Liên kết với cột MaKichCo trong DataTable
                dgvCustomer.Columns["CustomerID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động lấp đầy

                dgvCustomer.Columns.Add("CustomerName", "Customer Name");
                dgvCustomer.Columns["CustomerName"].DataPropertyName = "TenKH"; // Liên kết với cột TenKichCo trong DataTable
                dgvCustomer.Columns["CustomerName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động lấp đầy

                dgvCustomer.Columns.Add("Phone", "Phone");
                dgvCustomer.Columns["Phone"].DataPropertyName = "SoDT"; // Liên kết với cột TenKichCo trong DataTable
                dgvCustomer.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động lấp đầy

                dgvCustomer.DataSource = dtCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadData()
        {
            try
            {

                dtCustomer = new DataTable();
                dtCustomer.Clear();
                dtCustomer = dBCustomer.GetCustomer().Tables[0];
                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = dtCustomer;
            }
            catch (SqlException)
            {
                this.Close();
                MessageBox.Show("Không lấy được data!", "Infomation", MessageBoxButtons.OK);
            }
        }
        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            DataTable dtS = new DataTable();
            dtS = dBCustomer.SearchCustomer(tbSearchCus.Text);
            if (dtS.Rows.Count > 0)
            {
                try
                {

                    // Xóa các cột cũ (nếu có)
                    dgvCustomer.Columns.Clear();

                    // Đặt tên cột và liên kết với tên cột tương ứng trong DataTable
                    dgvCustomer.AutoGenerateColumns = false;
                    dgvCustomer.Columns.Add("CustomerID", "Customer ID");
                    dgvCustomer.Columns["CustomerID"].DataPropertyName = "MaKH"; // Liên kết với cột MaKichCo trong DataTable
                    dgvCustomer.Columns["CustomerID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động lấp đầy

                    dgvCustomer.Columns.Add("CustomerName", "Customer Name");
                    dgvCustomer.Columns["CustomerName"].DataPropertyName = "TenKH"; // Liên kết với cột TenKichCo trong DataTable
                    dgvCustomer.Columns["CustomerName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động lấp đầy

                    dgvCustomer.Columns.Add("Phone", "Phone");
                    dgvCustomer.Columns["Phone"].DataPropertyName = "SoDT"; // Liên kết với cột TenKichCo trong DataTable
                    dgvCustomer.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động lấp đầy

                    dgvCustomer.DataSource = dtS;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy Khách Hàng!");
            }
        }

        private void ManagemrentCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            string err = "";
            bool ktr = dBCustomer.AddCustomer(ref err, tbIdCustomer.Text, tbNameCustomer.Text, tbPhoneCus.Text);
            if (ktr)
            {
                MessageBox.Show("Thêm thành công");
                ReloadData();
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            string err = "";
            bool ktr = dBCustomer.DeleteCustomer(ref err, tbIdCustomer.Text);
            if (ktr)
            {
                MessageBox.Show("Xóa thành công");
                ReloadData();
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void btnUpdateCus_Click(object sender, EventArgs e)
        {
            string err = "";
            bool ktr = dBCustomer.UpdateCustomer(ref err, tbIdCustomer.Text, tbNameCustomer.Text, tbPhoneCus.Text);
            if (ktr)
            {
                MessageBox.Show("cập nhật thành công");
                ReloadData();
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadData();
            tbSearchCus.Text = null;
            tbPhoneCus.Text = null;
            tbNameCustomer.Text = null;
            tbIdCustomer.Text = null;

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCustomer.CurrentCell.RowIndex;
            tbIdCustomer.Text = dgvCustomer.Rows[r].Cells[0].Value.ToString();
            tbNameCustomer.Text = dgvCustomer.Rows[r].Cells[1].Value.ToString();
            tbPhoneCus.Text = dgvCustomer.Rows[r].Cells[2].Value.ToString();
        }
    }
}
