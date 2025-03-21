using System;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class UserDL
    {
        private string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
        public int GetOrCreateRoleId(string roleName)
        {
            int roleId = -1;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string selectQuery = "SELECT role_id FROM roles WHERE role_name = @roleName";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@roleName", roleName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        roleId = Convert.ToInt32(result);
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO roles (role_name) VALUES (@roleName)";
                        using (MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@roleName", roleName);
                            cmdInsert.ExecuteNonQuery();
                            roleId = (int)cmdInsert.LastInsertedId;
                        }
                    }
                }
            }
            return roleId;
        }
        public bool CreateUser(User user)
        {
            bool success = false;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string insertQuery = "INSERT INTO users (username, email, password_hash, role_id) VALUES (@uname, @mail, @pass, @role)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@uname", user.Username.Trim());
                    cmd.Parameters.AddWithValue("@mail", user.Email.Trim());
                    cmd.Parameters.AddWithValue("@pass", user.PasswordHash.Trim());
                    cmd.Parameters.AddWithValue("@role", user.RoleId);
                    int result = cmd.ExecuteNonQuery();
                    success = result > 0;
                }
            }
            return success;
        }
    }
}
