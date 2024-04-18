using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
namespace Repon
{
    public class GetConnectionV1
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;

        public GetConnectionV1()
        {
            //chuỗi kết nối
            conn = new SqlConnection("Data Source=LAPTOP-PTKCCTJC;" +
                "Initial Catalog=QuanLyPizza;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");
            cmd = conn.CreateCommand();
        }


        public DataSet ExcuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error, params SqlParameter[] param)
        {
            bool f = false;
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                cmd.Parameters.Clear();
                cmd.CommandType = ct;
                cmd.CommandText = strSQL;

                foreach (SqlParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }

                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        public T ExecuteScalarFunction<T>(string functionName, CommandType ct, params SqlParameter[] param)
        {
            T result = default(T);
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                cmd.Parameters.Clear();
                string commandText = "SELECT " + functionName + "(";
                if (param != null)
                {
                    foreach (SqlParameter p in param)
                    {
                        commandText += p.ParameterName + ",";
                        cmd.Parameters.Add(p);
                    }
                    commandText = commandText.TrimEnd(',') + ")";
                }
                else
                {
                    commandText += ")";
                }

                cmd.CommandText = commandText;
                cmd.CommandType = ct;
                object scalarValue = cmd.ExecuteScalar();
                if (scalarValue != null && scalarValue != DBNull.Value)
                {
                    result = (T)scalarValue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public DataTable ExcuteTableFunction(string strSQL, CommandType ct, params SqlParameter[] p)
        {
            DataTable dt = new DataTable();
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                cmd.Parameters.Clear();
                string commandText = string.Format("SELECT * FROM {0}(", strSQL);

                if (p != null)
                {
                    foreach (SqlParameter param in p)
                    {
                        commandText += param.ParameterName + ",";
                        cmd.Parameters.Add(param);
                    }
                    commandText = commandText.TrimEnd(',') + ")";
                }
                else
                {
                    commandText += ")";
                }

                cmd.CommandText = commandText;
                cmd.CommandType = ct;

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public List<T> GetListModels<T>(Func<SqlDataReader, T> converter, string sqlStr, CommandType commandType)
        {
            List<T> list = new List<T>();
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = commandType;
                cmd.CommandText = sqlStr;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    list.Add(converter(reader));
                cmd.Dispose();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }

        public T GetSingleObject<T>(Func<SqlDataReader, T> converter, string sqlStr, CommandType commandType)
        {
            T item;
            List<T> list = GetListModels(converter, sqlStr, commandType);
            item = list[0];
            return item;
        }

        public object GetSingleValueFromFunction(string sqlStr, params SqlParameter[] param)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;
                if (param != null)
                    foreach (SqlParameter p in param)
                    {
                        cmd.Parameters.Add(p);
                    }
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return 0;
        }
    }

    
}
