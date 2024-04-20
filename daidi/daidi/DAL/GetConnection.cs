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



       
        //dùng cho function trả về kiểu Table
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
                cmd.Parameters.Clear();//dọn sạch cái củ
                string commandText = string.Format("SELECT * FROM {0}(", strSQL); //câu lệnh được thực thi theo cấu trúc select

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
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        

    }
}
