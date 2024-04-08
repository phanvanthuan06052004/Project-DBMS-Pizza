using Microsoft.Data.SqlClient;
using Repon.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repon
{
    public class LoginRepo
    {
        //khai báo phần kết nối
        private readonly GetConnection _connection = new GetConnection();


        //Hàm nhận vào user kiểm tra có user đó trong danh sách tài khoản
        //Nếu có thì nó Sẽ trả về tài khoản đó
        public TaiKhoan GetUsernameAndPassword(string user)
        {
            TaiKhoan taiKhoan = null;
            try
            {
                string query = "SELECT * FROM TaiKhoan WHERE UserName = @UserName";
                using (var command = new SqlCommand(query, _connection.mConn))
                {
                    command.Parameters.AddWithValue("@UserName", user);
                    _connection.mConn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            taiKhoan = new TaiKhoan
                            {
                                UserName = reader["UserName"].ToString(),
                                Password = reader["Password"].ToString(),
                                MaNv = reader["MaNV"].ToString(),
                                Role = Convert.ToInt32(reader["Role"])
                                // Add other properties as needed
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _connection.mConn.Close();
            }
            return taiKhoan;
        }
    }
}
