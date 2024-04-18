using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using daidi.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace daidi.SERVICE
{
    
    public class DBAccount
    {
        GetConnection cnt = new GetConnection();
        public bool DeleteAccount(ref string err, string userName)
        {
            return cnt.MyExecuteNonQuery("sp_DeleteTaiKhoan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@UserName", userName));
        }

        //public DataTable GetAccount(string employee_id)
        //{
        //    return cnt.ExcuteTableFunction("vw_InfoAccountEmployee", CommandType.Text,
        //        new SqlParameter("@employee_id", employee_id));
        //}

        public string KiemTraDangNhap(string user_name, string pass_word)
        {
            return cnt.ExecuteScalarFunction<string>("", CommandType.Text,
                new SqlParameter("@user_name", user_name),
                new SqlParameter("@pass_word", pass_word));
        }

        public bool AddAccount  (ref string err, string UserName, string Password, string MaNV, string Role)
        {
            return cnt.MyExecuteNonQuery("sp_AddTaiKhoan", CommandType.StoredProcedure, ref err,
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@Password", Password),
                new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@Role", Role));
        }
    }
}
