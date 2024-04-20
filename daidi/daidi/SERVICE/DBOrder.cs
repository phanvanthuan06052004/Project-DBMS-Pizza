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
    public class DBOrder
    {
        GetConnection cnt = new GetConnection();
        public DataSet GetOrder()
        {
            return cnt.ExcuteQueryDataSet("select * from vw_XemHoaDon", CommandType.Text, null);
        }

        public DataTable SearchOrderDate(DateTime Min, DateTime Max)
        {
            return cnt.ExcuteTableFunction("fn_SearchOrderDate", CommandType.Text,
                new SqlParameter("@Min", Min),
                new SqlParameter("@Max", Max)
                );
        }
        public DataTable SearchOrderID(string Name)
        {
            return cnt.ExcuteTableFunction("fn_SearchOrderID", CommandType.Text,
                new SqlParameter("@Name", Name)
                );
        }
    }
}
