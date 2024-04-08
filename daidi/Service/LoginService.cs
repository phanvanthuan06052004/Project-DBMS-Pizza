using Repon.Entities;
using Repon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class LoginService
    {
        LoginRepo _loginRepo = new LoginRepo();

        //public LoginService(LoginRepo loginRepo)
        //{
        //    _loginRepo = loginRepo ?? throw new ArgumentNullException(nameof(loginRepo));
        //}

       
        public TaiKhoan LoginServices(string user, string pass)
        {
            //kiểm tra role bằng 1 mới cho Login
            //nó truyền user vào Repo để lấy lên danh sách Tài khoản theo tham số user truyền vào
            //nếu có thì nó sẽ chuyển list Tài khoản của user đó cho serveice xử lí, nếu ko thì trả về null
            TaiKhoan taiKhoan = _loginRepo.GetUsernameAndPassword(user);
            if (taiKhoan != null && taiKhoan.Password == pass && taiKhoan.Role == 1)
            {
                return taiKhoan;
            }
            return null;
        }
    }
}
