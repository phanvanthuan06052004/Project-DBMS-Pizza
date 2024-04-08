using Repon;
using Repon.Entities;
using Service;

namespace daidi
{
    public partial class Login : Form
    {
        LoginService loginService = new LoginService();


        int ktr;

        public Login()
        {
            InitializeComponent();
            ktr = 0;
            
        }



        private void hidePassBtn_Click(object sender, EventArgs e)
        {
            if (hidePassBtn.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                hidePassBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
                passLoginTxt.PasswordChar = '*';
            }
            else
            {
                hidePassBtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                passLoginTxt.PasswordChar = '\0';
            }


   
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //phần xử lí nút xác nhận 
            string password = passLoginTxt.Text;
            string conFirm = txtRegis.Text;
            btnLogin.Visible = false;
            txtRegis.Visible = true;
            hidePassBtn.Visible = false;
            passLoginTxt.PasswordChar = '\0';
            txtRegis.PasswordChar = '\0';
            btnRegister.Text = "Confirm";

            //Phần kiêm tra xem xác nhận có khớp với pass mới ko
            if (!password.Equals(conFirm))
            {
                MessageBox.Show("Please confirm the correct password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Phần Check xem người dùng có nhập đầy đủ thông tin chưa
            if (passLoginTxt.Text.Equals("") || txtRegis.Text.Equals("") || userNameTxt.Text.Equals(""))
            {
                if (ktr == 0)
                {
                    ktr++;
                    btnBack.Visible = true;
                }
                else
                {
                    MessageBox.Show("vui lòng nhập đầy đủ thông tin!!");
                }


            }

        }


        private void btnHideConfirm_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Hàm xử lí nút Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (passLoginTxt.Text.Equals("") || userNameTxt.Text.Equals(""))
            //{
            //    MessageBox.Show("vui lòng nhập đầy đủ thông tin!!");
            //}

            string username = userNameTxt.Text;
            string password = passLoginTxt.Text;

            // Tạo một instance của LoginService
            

            // Gọi phương thức xác thực (authenticate)
            TaiKhoan authenticatedUser = loginService.LoginServices(username, password);

            if (authenticatedUser != null)
            {
                // Đăng nhập thành công, chuyển qua form khác
                frmOption Option = new frmOption();
              
                Option.Show();
                
                Hide(); 
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng kiểm tra lại thông tin đăng nhập.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtRegis.Visible=false;
            btnLogin.Visible = true;
            ktr = 0;
            btnRegister.Text = "Register";
        }
    }
}
