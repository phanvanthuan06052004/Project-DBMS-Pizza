﻿using daidi.DAL;
using daidi.SERVICE;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daidi
{
    public partial class frmRepoManagement : Form
    {
        DBRepoProduct product = new DBRepoProduct();
        DBType DBType = new DBType();
        DataTable dt;
        DataTable dtType;
        String s;
        public frmRepoManagement()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {

                dt = new DataTable();
                dtType = new DataTable();
                dt.Clear();
                dtType.Clear();
                dt = product.GetProduct().Tables[0];
                dtType = DBType.GetType().Tables[0];
                dgvProduct.DataSource = dt;
                cbTypePro.DataSource = dtType;
                cbTypePro.DisplayMember = "TenLoaiSP";
                cbTypePro.ValueMember = "MaLoaiSP";
            }
            catch (SqlException)
            {
                this.Close();
                MessageBox.Show("Không lấy được data!", "Infomation", MessageBoxButtons.OK);
            }
        }

        private void frmRepoManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void proPicture_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                proPicture.ImageLocation = openFileDialog.FileName;

                s = openFileDialog.FileName;
            }

        }

        //đổi image sang byte
        private byte[] ConvertImgToByte(string imagePath)
        {
            byte[] picbyte = null;
            try
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    picbyte = new byte[fs.Length];
                    fs.Read(picbyte, 0, picbyte.Length);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            return picbyte;
        }

        //đổi từ byte sang image 
        private Image ConvertCellToImage(object cellValue)
        {
            if (cellValue == null || cellValue == DBNull.Value)
            {
                return null;
            }

            try
            {
                byte[] imageData = cellValue as byte[];
                if (imageData == null)
                {
                    MessageBox.Show("Giá trị ô không phải là một mảng byte.");
                    return null;
                }

                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    // Tạo hình ảnh từ luồng bộ nhớ
                    Image image = Image.FromStream(memoryStream);
                    return image;
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Lỗi: " + ex.Message);
                return null;
            }
        }



        private void btnAddPro_Click(object sender, EventArgs e)
        {
            string err = "";
            bool ktr = product.AddProduct(ref err, tbIdPro.Text, tbNamePro.Text, cbTypePro.SelectedValue.ToString(), ConvertImgToByte(s));
            if (ktr)
            {
                MessageBox.Show("Thêm thành công");
                dt.Clear();
                dt = product.GetProduct().Tables[0];
                dgvProduct.DataSource = null;
                dgvProduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvProduct.CurrentCell.RowIndex;
            tbIdPro.Text = dgvProduct.Rows[r].Cells[0].Value.ToString();
            tbNamePro.Text = dgvProduct.Rows[r].Cells[1].Value.ToString();
            // Lấy giá trị của cột mã loại sản phẩm từ DataGridView
            string maLoaiSP = dgvProduct.Rows[r].Cells[2].Value.ToString();

            // Tìm tên loại sản phẩm tương ứng trong DataTable của ComboBox
            DataRow[] foundRows = dtType.Select($"MaLoaiSP = '{maLoaiSP}'");
            if (foundRows.Length > 0)
            {
                string tenLoaiSP = foundRows[0]["TenLoaiSP"].ToString();
                cbTypePro.SelectedValue = maLoaiSP; // Gán giá trị cho ComboBox
            }
            if (dgvProduct.Rows[r].Cells[3].Value != null)
                proPicture.Image = ConvertCellToImage(dgvProduct.Rows[r].Cells[3].Value);

            // Lấy chỉ số của cột hình ảnh trong DataGridView
            // MessageBox.Show(dgvProduct.Rows[r].Cells[5].Value.GetType().ToString());
        }

        private void btnUpdatePro_Click(object sender, EventArgs e)
        {
            string err = "";

            // Lấy giá trị được chọn từ ComboBox
            string maLoaiSP = cbTypePro.SelectedValue.ToString();

            bool f = product.UpdateProduct(ref err, tbIdPro.Text, tbNamePro.Text, maLoaiSP, ConvertImgToByte(s));

            if (f)
            {
                MessageBox.Show("Cập nhật thành công!");
                dt.Clear();
                dt = product.GetProduct().Tables[0];
                dgvProduct.DataSource = dt;
                //dgvProduct.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show(err);
            }

        }


        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            string err = "";
            bool ktr = product.DeleteProduct(ref err, tbIdPro.Text);
            if (ktr)
            {
                MessageBox.Show("Xóa thành công");
                dt.Clear();
                dt = product.GetProduct().Tables[0];
                dgvProduct.DataSource = null;
                dgvProduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void btnSearchPro_Click(object sender, EventArgs e)
        {
            DataTable dtPro = new DataTable();
            dtPro = product.SearchProduct(tbSearchPro.Text);
            if(dtPro.Rows.Count > 0)
            {
                dgvProduct.DataSource = null;
                dgvProduct.DataSource = dtPro;
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
            }    
        }
    }
}
