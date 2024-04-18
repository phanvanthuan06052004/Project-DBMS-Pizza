using daidi.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daidi.SERVICE
{
    public  class DBSize
    {
        GetConnection cnt = new GetConnection();
        public DataSet GetSize()
        {
            return cnt.ExcuteQueryDataSet("select * from vw_XemSize", CommandType.Text, null);
        }
    }
}
