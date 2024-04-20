using daidi.SERVICE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daidi
{
    partial class ManageSize : Form
    {
        DataTable dt;
        DBSize dbsize = new DBSize();
        public ManageSize()
        {
            InitializeComponent();
        }
        void ReloadData()
        {
            try
            {
                dt.Clear();
                dt = dbsize.GetSize().Tables[0];

                // Xóa các cột cũ (nếu có)
                dgvSize.Columns.Clear();

                // Đặt tên cột và liên kết với tên cột tương ứng trong DataTable
                dgvSize.AutoGenerateColumns = false;
                dgvSize.Columns.Add("SizeID", "Size ID");
                dgvSize.Columns["SizeID"].DataPropertyName = "MaKichCo"; // Liên kết với cột MaKichCo trong DataTable
                dgvSize.Columns["SizeID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động lấp đầy

                dgvSize.Columns.Add("SizeName", "Size Name");
                dgvSize.Columns["SizeName"].DataPropertyName = "TenKichCo"; // Liên kết với cột TenKichCo trong DataTable
                dgvSize.Columns["SizeName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động lấp đầy

                dgvSize.DataSource = dt;
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

                dt = new DataTable();
                dt.Clear();
                dt = dbsize.GetSize().Tables[0];
                dgvSize.DataSource = null;
                dgvSize.DataSource = dt;
            }
            catch (SqlException)
            {
                this.Close();
                MessageBox.Show("Không lấy được data!", "Infomation", MessageBoxButtons.OK);
            }
        }

        private void ManageSize_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddSize_Click(object sender, EventArgs e)
        {
            string err = "";
            bool ktr = dbsize.AddSize(ref err, tbIdSize.Text, tbNameSize.Text);
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

        private void btnDeleteSize_Click(object sender, EventArgs e)
        {
            string err = "";
            bool ktr = dbsize.DeleteSize(ref err, tbIdSize.Text);
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

        private void dgvSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvSize.CurrentCell.RowIndex;
            tbIdSize.Text = dgvSize.Rows[r].Cells[0].Value.ToString();
            tbNameSize.Text = dgvSize.Rows[r].Cells[1].Value.ToString();
        }

        private void btnSearchSize_Click(object sender, EventArgs e)
        {
            DataTable dtSize = new DataTable();
            dtSize = dbsize.SearchSize(tbKeySize.Text);
            if (dtSize.Rows.Count > 0)
            {
                try
                {

                    // Xóa các cột cũ (nếu có)
                    dgvSize.Columns.Clear();

                    // Đặt tên cột và liên kết với tên cột tương ứng trong DataTable
                    dgvSize.AutoGenerateColumns = false;
                    dgvSize.Columns.Add("SizeID", "Size ID");
                    dgvSize.Columns["SizeID"].DataPropertyName = "MaKichCo"; // Liên kết với cột MaKichCo trong DataTable
                    dgvSize.Columns["SizeID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động lấp đầy

                    dgvSize.Columns.Add("SizeName", "Size Name");
                    dgvSize.Columns["SizeName"].DataPropertyName = "TenKichCo"; // Liên kết với cột TenKichCo trong DataTable
                    dgvSize.Columns["SizeName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Tự động lấp đầy

                    dgvSize.DataSource = dtSize;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
            }
        }

        private void btnUpdateSize_Click(object sender, EventArgs e)
        {
            string err = "";

            bool f = dbsize.UpdateSize(ref err, tbIdSize.Text, tbNameSize.Text);

            if (f)
            {
                MessageBox.Show("Cập nhật thành công!");
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
            tbIdSize.Text = null;
            tbNameSize.Text = null;
            tbKeySize.Text = null;
        }
    }
}
