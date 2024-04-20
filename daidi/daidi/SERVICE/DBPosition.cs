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
    public class DBPosition
    {
        GetConnection cnt = new GetConnection();
        public DataSet GetPosition()
        {
            return cnt.ExcuteQueryDataSet("SELECT * FROM ChucVu", CommandType.Text, null);

        }
    }
}
