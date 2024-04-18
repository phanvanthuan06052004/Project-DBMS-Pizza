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
    public partial class frmEmployManagement : Form
    {
        DBEmployee employee = new DBEmployee();
        DBAccount Account = new DBAccount();
        DataTable dtEmployee = new DataTable();

        public frmEmployManagement()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtEmployee = new DataTable();
                dtEmployee.Clear();
                dtEmployee = employee.GetEmployee().Tables[0];
                dgvEmployee.DataSource = dtEmployee;
                dgvEmployee.AutoResizeColumns();
                // Đổi tên các cột trong DataGridView
                dgvEmployee.Columns["MaNV"].HeaderText = "Employee ID";
                dgvEmployee.Columns["HoNV"].HeaderText = "Last Name";
                dgvEmployee.Columns["TenNV"].HeaderText = "First Name";
                dgvEmployee.Columns["NgaySinh"].HeaderText = "Births";
                dgvEmployee.Columns["GioiTinh"].HeaderText = "Sex";
                dgvEmployee.Columns["SoDT"].HeaderText = "Phone";
                dgvEmployee.Columns["DiaChi"].HeaderText = "Address";
                dgvEmployee.Columns["Email"].HeaderText = "Email";
                dgvEmployee.Columns["CCCD"].HeaderText = "CCCD";
                dgvEmployee.Columns["MaChucVu"].HeaderText = "Position ID";
            }
            catch (SqlException)
            {
                this.Close();
                MessageBox.Show("You do not have permission to perform this action!", "Infomation", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string err = "";
            // Chuyển đổi ngày sinh thành chuỗi theo định dạng yyyy-MM-dd
            DateTime birthDate = dtBirth.Value;
            employee.Add_Employee(ref err, txtID.Text, txtLastName.Text, txtFIrstName.Text, birthDate, "", txtPhone.Text, txtAddress.Text, txtEmail.Text, txtCCCD.Text, txtPositionID.Text);
            Account.AddAccount(ref err, txtUsername.Text, txtPassword.Text, txtID.Text, txtRole.Text);
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void frmEmployManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            int r = dgvEmployee.CurrentCell.RowIndex;
            txtID.Text = dgvEmployee.Rows[r].Cells[0].Value.ToString();
            txtLastName.Text = dgvEmployee.Rows[r].Cells[1].Value.ToString();
            txtFIrstName.Text = dgvEmployee.Rows[r].Cells[2].Value.ToString();
            dtBirth.Value = (DateTime)dgvEmployee.Rows[r].Cells[3].Value;
            if (dgvEmployee.CurrentRow.Cells[4].Value.ToString() == "Nam")
            {
                CkMen.Checked = true;
            }
            else CkWomen.Checked = true;
            txtPhone.Text = dgvEmployee.Rows[r].Cells[5].Value.ToString();
            txtAddress.Text = dgvEmployee.Rows[r].Cells[6].Value.ToString();
            txtEmail.Text = dgvEmployee.Rows[r].Cells[7].Value.ToString();
            txtCCCD.Text = dgvEmployee.Rows[r].Cells[8].Value.ToString();
            
            
            
            //DataTable dtAccount = new DataTable();
            //dtAccount = Account(EMPdataGridView.Rows[r].Cells[0].Value.ToString());
            //txtUser_name.Text = dtAccount.Rows[0][0].ToString();
            //txtPass.Text = dtAccount.Rows[0][1].ToString();
            //cbxRole.Text = dtAccount.Rows[0][3].ToString();

            //txtUser_name.Enabled = false;
            //txtPass.Enabled = false;
            //cbxRole.Enabled = false;
        }
    }
}
