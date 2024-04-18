using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace daidi.DAL
{
    public class GetConnection
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;

        public GetConnection()
        {
            //chuỗi kết nối
            conn = new SqlConnection("Data Source=LAPTOP-PTKCCTJC;" +
                "Initial Catalog=QuanLyPizza;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");
            cmd = conn.CreateCommand();
        }
        //Constructor của lớp GetConnection, được sử dụng để khởi tạo đối tượng SqlConnection
        //và gán chuỗi kết nối tới cơ sở dữ liệu SQL Server.
        //Khởi tạo một đối tượng cmd dựa trên conn đã khởi tạo để thực thi các truy vấn.



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
        //Phương thức này được sử dụng để thực thi một truy vấn
        //SQL và trả về một DataSet chứa kết quả của truy vấn.

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
                MessageBox.Show(error);
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        //Phương thức này được sử dụng để thực thi một truy vấn SQL không trả về dữ liệu
        //(ví dụ: INSERT, UPDATE, DELETE) và trả về một giá trị bool để chỉ ra thành công hoặc
        //thất bại của truy vấn.(storeProcedure)



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
        //Phương thức này được sử dụng để thực thi một hàm trả
        //về một giá trị đơn lẻ và trả về giá trị đó.

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
        //Phương thức này được sử dụng để thực thi một truy vấn SQL và trả
        //về một DataTable chứa kết quả của truy vấn.


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
       // Phương thức này được sử dụng để thực thi một
       // truy vấn SQL và trả về một danh sách các đối tượng T.


        public T GetSingleObject<T>(Func<SqlDataReader, T> converter, string sqlStr, CommandType commandType)
        {
            T item;
            List<T> list = GetListModels(converter, sqlStr, commandType);
            item = list[0];
            return item;
        }
        //Phương thức này được sử dụng để trả về một đối tượng đơn lẻ từ kết quả của một truy vấn SQL.



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
        //Phương thức này được sử dụng để lấy một giá trị đơn lẻ từ một hàm trong
        //cơ sở dữ liệu và trả về giá trị đó.

    }
}
