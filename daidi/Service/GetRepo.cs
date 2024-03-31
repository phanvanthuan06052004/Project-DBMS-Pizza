using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repon;
namespace Service
{
    public class GetRepo
    {
        GetConnection conn;
        public DataSet mDataSet = new DataSet();
        public  GetRepo()
        {
            conn = new GetConnection();
        }
        public void sql(string str)
        {
            conn.SQLDB(str);
            mDataSet = conn.mDataSet;
        }

    }

    
}
