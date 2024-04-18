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
        DBSize DBSize = new DBSize();
        DBType DBType = new DBType();
        DataTable dt;
        DataTable dtSize;
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
                //dtSize = new DataTable();
                dtType = new DataTable();
                dt.Clear();
                //dtSize.Clear();
                dtType.Clear();
                dt = product.GetProduct().Tables[0];
                //dtSize = DBSize.GetSize().Tables[0];
                dtType = DBType.GetType().Tables[0];
                dgvProduct.DataSource = dt;
                // dgvProduct.AutoResizeColumns();
                // Đổi tên các cột trong DataGridView
                //cbSizePro.DataSource = dtSize;
                //cbSizePro.DisplayMember = "TenKichCo";
                //cbSizePro.ValueMember = "MaKichCo";
                cbTypePro.DataSource = dtType;
                cbTypePro.DisplayMember = "TenLoaiSP";
                cbTypePro.ValueMember = "MaLoaiSP";
            }
            catch (SqlException)
            {
                this.Close();
                MessageBox.Show("You do not have permission to perform this action!", "Infomation", MessageBoxButtons.OK);
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


        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvProduct.CurrentCell.RowIndex;
            tbIdPro.Text = dgvProduct.Rows[r].Cells[0].Value.ToString();
            tbNamePro.Text = dgvProduct.Rows[r].Cells[1].Value.ToString();
            cbTypePro.Text = dgvProduct.Rows[r].Cells[2].Value.ToString();
            if (dgvProduct.Rows[r].Cells[3].Value != null)
                proPicture.Image = ConvertCellToImage(dgvProduct.Rows[r].Cells[3].Value);

            // Lấy chỉ số của cột hình ảnh trong DataGridView
            // MessageBox.Show(dgvProduct.Rows[r].Cells[5].Value.GetType().ToString());
        }

        private void btnUpdatePro_Click(object sender, EventArgs e)
        {
            string err = "";
            bool f = product.UpdateProduct(ref err, tbIdPro.Text, tbNamePro.Text, "LSP002", ConvertImgToByte(s));

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

        private void btnReload_Click(object sender, EventArgs e)
        {
        }
    }
}
