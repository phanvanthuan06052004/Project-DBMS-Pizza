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
    public class DBProvider
    {
        GetConnection cnt = new GetConnection();
        public DataSet GetProvider()
        {
            return cnt.ExcuteQueryDataSet("select * from vw_XemChiTietCungCap", CommandType.Text, null);
        } 

        public DataTable SearchProvider(string Key)
        {
            return cnt.ExcuteTableFunction("fn_SearchSize", CommandType.Text,
                new SqlParameter("@Key", Key)
                );
        }

        public bool DeleteProvider(ref string err, string MaKichCo)
        {
            return cnt.MyExecuteNonQuery("sp_DeleteSize",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKichCo", MaKichCo)
            );
        }
        public bool UpdateProvider(ref string err, string MaKichCo, string TenKichCo)
        {
            return cnt.MyExecuteNonQuery("sp_UpdateSize",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKichCo", MaKichCo),
                new SqlParameter("@TenKichCo", TenKichCo)
            );
        }

        public bool AddProvider(ref string err, string MaKichCo, string TenKichCo)
        {
            return cnt.MyExecuteNonQuery("sp_AddSize",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaKichCo", MaKichCo),
                new SqlParameter("@TenKichCo", TenKichCo)
                );
        }
    }
}
