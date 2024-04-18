using daidi.DAL;
using LiveChartsCore.Geo;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daidi.SERVICE
{
    public class DBRepoProduct
    {
        GetConnection cnt = new GetConnection();
        public DataSet GetProduct()
        {
            return cnt.ExcuteQueryDataSet("SELECT * from SanPham", CommandType.Text, null);
        }

        public bool UpdateProduct(ref string err, string MaSP, string TenSP, string MaLoaiSP, byte[] HinhAnh)
        {
                return cnt.MyExecuteNonQuery("sp_UpdateSanPham",
                    CommandType.StoredProcedure, ref err,
                    new SqlParameter("@MaSP", MaSP),
                    new SqlParameter("@TenSP", TenSP),
                    new SqlParameter("@MaLoaiSP", MaLoaiSP),
                    new SqlParameter("@HinhAnh", HinhAnh)
                );
        }

        public bool AddProduct(ref string err, string MaSP, string TenSP, string MaLoaiSP, byte[] HinhAnh)
        {
            return cnt.MyExecuteNonQuery("sp_AddSanPham",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaSP", MaSP),
                    new SqlParameter("@TenSP", TenSP),
                    new SqlParameter("@MaLoaiSP", MaLoaiSP),
                    new SqlParameter("@HinhAnh", HinhAnh)
                );
        }


    }
}
