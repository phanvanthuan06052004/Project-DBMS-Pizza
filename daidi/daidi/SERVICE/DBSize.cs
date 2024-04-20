using daidi.DAL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace daidi.SERVICE
{
    public  class DBSize
    {
        GetConnection cnt = new GetConnection();
        public DataSet GetSize()
        {
            return cnt.ExcuteQueryDataSet("select * from vw_XemKichCo", CommandType.Text, null);
        }

        public DataTable SearchSize(string Key)
        {
            return cnt.ExcuteTableFunction("fn_SearchSize", CommandType.Text,
                new SqlParameter("@Key", Key)
                );
        }

        public bool DeleteSize(ref string err, string MaKichCo)
        {
            return cnt.MyExecuteNonQuery("sp_DeleteSize",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKichCo", MaKichCo)
            );
        }
        public bool UpdateSize(ref string err, string MaKichCo, string TenKichCo)
        {
            return cnt.MyExecuteNonQuery("sp_UpdateSize",
                CommandType.StoredProcedure, ref err,
                new SqlParameter("@MaKichCo", MaKichCo), 
                new SqlParameter("@TenKichCo", TenKichCo)
            );
        }

        public bool AddSize(ref string err, string MaKichCo, string TenKichCo)
        {
            return cnt.MyExecuteNonQuery("sp_AddSize",
                CommandType.StoredProcedure, ref err,
                 new SqlParameter("@MaKichCo", MaKichCo),
                new SqlParameter("@TenKichCo", TenKichCo)
                );
        }
    }
}
