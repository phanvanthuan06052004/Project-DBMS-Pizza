using daidi.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daidi.SERVICE
{
    public class DBType
    {
        GetConnection cnt = new GetConnection();
        public DataSet GetType()
        {
            return cnt.ExcuteQueryDataSet("select * from vw_XemLoaiSP", CommandType.Text, null);
        }
    }
}
