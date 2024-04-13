using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
namespace Repon
{
    public class GetConnection
    {
        public SqlDataAdapter mDataAdapter = new SqlDataAdapter();
        public DataSet mDataSet = new DataSet();
        public SqlConnection mConn;

        public GetConnection()
        {   
            //chuỗi kết nối
            mConn = new SqlConnection("Data Source=LAPTOP-PTKCCTJC;" +
                "Initial Catalog=QuanLyPizza;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");
        }


        public DataSet SQLDB(string strSQL)
        {
            //phần xử lí truyền srtSQL câu truy vấn xuống thao tác với Database
            try
            {
                mDataAdapter = new SqlDataAdapter(new SqlCommand(strSQL, mConn));
                mDataSet = new DataSet();
                mDataAdapter.Fill(mDataSet);
                return mDataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mConn.Close();
            }

        }
        public void ClearRes()
        {
            //giải phóng tài nguyên mDataAdapter khi thao tác xong
            mDataAdapter.Dispose();
            mDataAdapter = null;
            mDataSet.Dispose();
            if (mConn.State != ConnectionState.Closed)
            {
                mConn.Close();

            }

        }
    }

    
}
