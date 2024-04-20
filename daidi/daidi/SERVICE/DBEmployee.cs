using daidi.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace daidi.SERVICE
{
    public class DBEmployee
    {
        GetConnection cnt = new GetConnection();

        //public DBEmployee()
        //{
        //    db = new DAL(DBCurrentLogin.GetCurrentLoginInfo().UserName,
        //        DBCurrentLogin.GetCurrentLoginInfo().Password);
        //}


        public DataSet GetEmployee()
        {
            return cnt.ExcuteQueryDataSet("select * from vw_XemThongTinNhanVien", CommandType.Text, null);
        }

        //public DataTable GetInfo1Employee()
        //{
        //    return cnt.ExcuteTableFunction("[dbo].[Get_infor_employee]", CommandType.Text,
        //        new SqlParameter("@user_name", DBCurrentLogin.GetCurrentLoginInfo().UserName),
        //        new SqlParameter("@pass_word", DBCurrentLogin.GetCurrentLoginInfo().Password));
        //}

        //public string SinhMaNhanVien()
        //{
        //    return cnt.ExecuteScalarFunction<string>("[dbo].[ftGet_next_employee_id]", CommandType.Text, null);
        //}

        public bool Add_Employee(ref string err, string Manv, string HoNV, string TenNV, 
            DateTime NgaySinh, string GioiTinh, string SoDT, string DiaChi, string Email, string CCCD, string MaChucVu)
        {
            return cnt.MyExecuteNonQuery("sp_AddEmployee",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", Manv),
                new SqlParameter("@HoNV", HoNV),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@SoDT", SoDT),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Email", Email),
                new SqlParameter("@CCCD", CCCD),
                new SqlParameter("@MaChucVu", MaChucVu)
                );
        }


        public bool Update_Employee(ref string err, string Manv, string HoNV, string TenNV, DateTime NgaySinh, string GioiTinh, string SoDT, string DiaChi, string Email, string CCCD)
        {
            return cnt.MyExecuteNonQuery("sp_UpdateEmployee",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", Manv),
                new SqlParameter("@HoNV", HoNV),
                new SqlParameter("@TenNV", TenNV),
                new SqlParameter("@NgaySinh", NgaySinh),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@SoDT", SoDT),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Email", Email),
                new SqlParameter("@CCCD", CCCD)
                );
        }

        public bool Delete_Employee(ref string err, string MaNV)
        {
            return cnt.MyExecuteNonQuery("sp_DeleteEmployee",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaNV", MaNV)
                );
        }

        public DataTable SearchEmployee(string Option, string key)
        {
            return cnt.ExcuteTableFunction("fn_searchEmployee", CommandType.Text,
                new SqlParameter("@Option", Option),
                new SqlParameter("@key", key)
                );
        }

    }
}
