using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class RoleDL
    {
        private string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT role_id, role_name FROM Roles";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int roleId = reader["role_id"] != DBNull.Value ? Convert.ToInt32(reader["role_id"]) : 0;
                            string roleName = reader["role_name"] != DBNull.Value ? reader["role_name"].ToString() : "";
                            roles.Add(new Role { RoleId = roleId, RoleName = roleName });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading roles: " + ex.Message);
                }
            }
            return roles;
        }
    }
}
