using System;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class LoginDL
    {
        private string connectionString = "server=localhost;port=3306;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;";
        public User GetUserByUsername(string username)
        {
            User user = null;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT u.email, u.password_hash, u.role_id, r.role_name 
                        FROM users u 
                        INNER JOIN roles r ON u.role_id = r.role_id
                        WHERE u.username = @Username";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username.Trim());
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    Username = username,
                                    Email = reader["email"].ToString(),
                                    PasswordHash = reader["password_hash"].ToString(),
                                    RoleId = reader["role_id"] != DBNull.Value ? Convert.ToInt32(reader["role_id"]) : 0,
                                    RoleName = reader["role_name"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving user: " + ex.Message);
                }
            }
            return user;
        }
    }
}
