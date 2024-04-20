using daidi.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daidi.SERVICE
{
    public class DBCustomer
    {
        GetConnection cnt = new GetConnection();
        public DataSet GetCustomer()
        {
            return cnt.ExcuteQueryDataSet("select * from vw_XemKhachHang", CommandType.Text, null);
        }

        public DataTable SearchCustomer(string Key)
        {
            return cnt.ExcuteTableFunction("fn_SearchCustomerName", CommandType.Text,
                new SqlParameter("@Name", Key)
                );
        }

        public bool DeleteCustomer(ref string err, string MaKH)
        {
            return cnt.MyExecuteNonQuery("sp_XoaThongTinKhachHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKH", MaKH)
            );
        }
        public bool UpdateCustomer(ref string err, string MaKH, string TenKH, string SoDT)
        {
            return cnt.MyExecuteNonQuery("sp_CapNhatThongTinKhachHang",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@TenKH", TenKH),
                new SqlParameter("@SoDT", SoDT)
            );
        }

        public bool AddCustomer(ref string err, string MaKH, string TenKH, string SoDT)
        {
            return cnt.MyExecuteNonQuery("sp_ThemThongTinKhachHang",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@TenKH", TenKH),
                new SqlParameter("@SoDT", SoDT)
                );
        }
    }
}
