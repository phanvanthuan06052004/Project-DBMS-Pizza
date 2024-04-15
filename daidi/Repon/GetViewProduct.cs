using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repon
{
    public class GetViewProduct
    {
        GetConnection conn = new GetConnection();
        public DataTable getProductView()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM vw_XemDanhSachSanPham", conn.mConn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
