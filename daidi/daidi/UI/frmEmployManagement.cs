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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace daidi
{
    public partial class frmEmployManagement : Form
    {
        DBEmployee employee = new DBEmployee();
        DBAccount Account = new DBAccount();
        DataTable dtEmployee = new DataTable();
        DBPosition Position = new DBPosition();
        public frmEmployManagement()
        {
            InitializeComponent();

        }
        void LoadData()
        {
            try
            {
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
                DataTable dtPosition = new DataTable();
                dtPosition = Position.GetPosition().Tables[0];
                cmbPosition.DataSource = dtPosition;
                cmbPosition.DisplayMember = "TenChucVu";
                cmbPosition.ValueMember = "MaChucVu";
            }
            catch (SqlException)
            {
                this.Close();
                MessageBox.Show("You do not have permission to perform this action!", "Infomation", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sex;
            if (CkMen.Checked == true)
            {
                sex = "Nam";
            }
            else
            {
                sex = "Nữ";
            }
            string err = "";
            // Chuyển đổi ngày sinh thành chuỗi theo định dạng yyyy-MM-dd
            DateTime birthDate = dtBirth.Value;
            bool ktr, ktr2;
            ktr = employee.Add_Employee(ref err, txtID.Text, txtLastName.Text, txtFIrstName.Text, birthDate, sex, txtPhone.Text, txtAddress.Text, txtEmail.Text, txtCCCD.Text, cmbPosition.Text);
            ktr2 = Account.AddAccount(ref err, txtUsername.Text, txtPassword.Text, txtID.Text, txtRole.Text);
            if (ktr && ktr2)
            {
                MessageBox.Show("Thêm thành công");
                dtEmployee.Clear();
                dtEmployee = employee.GetEmployee().Tables[0];
                dgvEmployee.DataSource = null;
                dgvEmployee.DataSource = dtEmployee;
                //dgvEmployee.AutoResizeColumns();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string err = "";
            bool ktr = employee.Delete_Employee(ref err, txtID.Text);
            if (ktr)
            {
                MessageBox.Show("Xóa thành công");
                dtEmployee.Clear();
                dtEmployee = employee.GetEmployee().Tables[0];
                dgvEmployee.DataSource = null;
                dgvEmployee.DataSource = dtEmployee;
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sex;
            if (CkMen.Checked == true)
            {
                sex = "Nam";
            }
            else
            {
                sex = "Nữ";
            }
            string err = "";
            DateTime birthDate = dtBirth.Value;
            bool f = employee.Update_Employee(ref err, txtID.Text,
                txtLastName.Text, txtFIrstName.Text, birthDate, sex, txtPhone.Text, txtAddress.Text, txtEmail.Text, txtCCCD.Text);

            if (f)
            {
                MessageBox.Show("Cập nhật thành công!");
                dtEmployee.Clear();
                dtEmployee = employee.GetEmployee().Tables[0];
                dgvEmployee.DataSource = null;
                dgvEmployee.DataSource = dtEmployee;
            }
            else
            {
                MessageBox.Show(err);
            }

        }

        private void frmEmployManagement_Load(object sender, EventArgs e)
        {
            List<string> searchOptions = new List<string>
            {
                "employee ID",
                "employee name",
                "job ID"
            };

            cmbSearchOption.DataSource = searchOptions;
            LoadData();
        }

        private void dgvEmployee_Click(object sender, EventArgs e)
        {

            int r = dgvEmployee.CurrentCell.RowIndex;
            txtID.Text = dgvEmployee.Rows[r].Cells[0].Value.ToString();
            txtLastName.Text = dgvEmployee.Rows[r].Cells[1].Value.ToString();
            txtFIrstName.Text = dgvEmployee.Rows[r].Cells[2].Value.ToString();
            try
            {
                dtBirth.Value = (DateTime)dgvEmployee.Rows[r].Cells[3].Value;
            }
            catch
            {

            }

            if (dgvEmployee.CurrentRow.Cells[4].Value.ToString() == "Nam")
            {
                CkWomen.Checked = false;
                CkMen.Checked = true;
            }
            else
            {
                CkWomen.Checked = true; CkMen.Checked = false;
            }
            txtPhone.Text = dgvEmployee.Rows[r].Cells[5].Value.ToString();
            txtAddress.Text = dgvEmployee.Rows[r].Cells[6].Value.ToString();
            txtEmail.Text = dgvEmployee.Rows[r].Cells[7].Value.ToString();
            txtCCCD.Text = dgvEmployee.Rows[r].Cells[8].Value.ToString();


            DataSet dtAccount;
            dtAccount = Account.GetAccount(); // Lấy dữ liệu từ phương thức GetAccount()

            // Kiểm tra xem DataSet có dữ liệu hay không trước khi truy cập
            if (dtAccount != null && dtAccount.Tables.Count > 0)
            {
                DataTable dtTable = dtAccount.Tables[0]; // Lấy bảng đầu tiên từ DataSet

                // Kiểm tra xem DataTable có dữ liệu hay không trước khi truy cập
                if (dtTable != null && dtTable.Rows.Count > 0)
                {


                    // Kiểm tra xem cột "Username" có tồn tại trong DataTable hay không
                    try
                    {
                        if (dtTable.Columns.Contains("Username"))
                        {
                            txtUsername.Text = dtTable.Rows[r]["Username"].ToString();
                        }

                        // Kiểm tra xem cột "Password" có tồn tại trong DataTable hay không
                        if (dtTable.Columns.Contains("Password"))
                        {
                            txtPassword.Text = dtTable.Rows[r]["Password"].ToString();
                        }
                        //  txtRole.Text = dtTable.Rows[r][4].ToString();


                        // Kiểm tra xem cột thứ 3 (chỉ số 2) có tồn tại và có giá trị không
                        if (dtTable.Columns.Count > 2)
                        {
                            txtRole.Text = dtTable.Rows[r][3].ToString();
                        }
                    }
                    catch

                    {

                    }


                }
                // Lấy giá trị từ ô trong DataGridView
                string cellValue = dgvEmployee.Rows[r].Cells[10].Value.ToString();

                if (cellValue.Equals("Quản lý"))
                {
                    cmbPosition.SelectedIndex = 0;
                }
                if (cellValue.Equals("Phục vụ"))
                {
                    cmbPosition.SelectedIndex = 1;
                }
                if (cellValue.Equals("Bảo vệ"))
                {
                    cmbPosition.SelectedIndex = 2;
                }
                if (cellValue.Equals("Thu ngân"))
                {
                    cmbPosition.SelectedIndex = 3;
                }

            }

        }

        private void cmbSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtEmp;
            string s = cmbSearchOption.SelectedValue.ToString();

            dtEmp = employee.SearchEmployee(s, txtKeySearach.Text);
            if (dtEmp.Rows.Count > 0)
            {
                dgvEmployee.DataSource = null;
                dgvEmployee.DataSource = dtEmp;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên");
            }
        }

        private void CkMen_CheckedChanged(object sender, EventArgs e)
        {
            if (CkMen.Checked)
            {
                CkWomen.Checked = false; // Nếu checkbox1 được chọn, thì checkbox2 sẽ không được chọn
            }
        }

        private void CkWomen_CheckedChanged(object sender, EventArgs e)
        {
            if (CkWomen.Checked)
            {
                CkMen.Checked = false; // Nếu checkbox1 được chọn, thì checkbox2 sẽ không được chọn
            }
        }

        private void CkMen_CheckStateChanged(object sender, EventArgs e)
        {
            //CkWomen.Enabled = false;
        }

        private void CkWomen_CheckStateChanged(object sender, EventArgs e)
        {
            //CkMen.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dtEmployee.Clear();
            dtEmployee = employee.GetEmployee().Tables[0];
            dgvEmployee.DataSource = dtEmployee;
            dgvEmployee.AutoResizeColumns();
            txtID.Text = null;
            txtLastName.Text = null;
            txtFIrstName.Text = null;
            txtPhone.Text = null;
            txtAddress.Text = null;
            txtEmail.Text = null;
            txtCCCD.Text = null;
            txtPassword.Text = null;
            txtUsername.Text = null;
            txtRole.Text = null;
        }

        private void dtBirth_ValueChanged(object sender, EventArgs e)
        {
            dtBirth.Format = DateTimePickerFormat.Custom;

            dtBirth.CustomFormat = "dd-MM-yyyy";

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
