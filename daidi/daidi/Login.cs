using Repon;
using Service;

namespace daidi
{
    public partial class Login : Form
    {
        GetConnection connection = new GetConnection();
        GetRepo conn = new GetRepo();
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


            conn.sql("select * from chucvu");
            if (conn.mDataSet.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("thanh cong password");
            }
            else
            {
                MessageBox.Show("wrong username or password");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string password = passLoginTxt.Text;
            string conFirm = txtRegis.Text;
            btnLogin.Visible = false;
            txtRegis.Visible = true;
            hidePassBtn.Visible = false;
            passLoginTxt.PasswordChar = '\0';
            txtRegis.PasswordChar = '\0';
            btnRegister.Text = "Confirm";


            if (!password.Equals(conFirm))
            {
                MessageBox.Show("Please confirm the correct password", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (passLoginTxt.Text.Equals("") || userNameTxt.Text.Equals(""))
            {
                MessageBox.Show("vui lòng nhập đầy đủ thông tin!!");
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
