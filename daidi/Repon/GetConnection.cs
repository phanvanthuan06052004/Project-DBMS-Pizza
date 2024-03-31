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

        public  GetConnection()
        {   
            mConn = new SqlConnection("Data Source=LAPTOP-PTKCCTJC;" +
                "Initial Catalog=quanlipizaV1;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");
        }


        public void SQLDB(string strSQL)
        {
            try
            {
                mDataAdapter = new SqlDataAdapter(new SqlCommand(strSQL, mConn));
                mDataSet = new DataSet();
                mDataAdapter.Fill(mDataSet);
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
