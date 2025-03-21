using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ITECManagementSystem.DL
{
    public class EntitySelectionDL
    {
        private string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";

        public List<KeyValuePair<int, string>> GetEntities(string entityType)
        {
            List<KeyValuePair<int, string>> entities = new List<KeyValuePair<int, string>>();
            string query = "";
            switch (entityType.ToLower())
            {
                case "sponsor":
                    query = "SELECT sponsor_id, sponsor_name FROM sponsors";
                    break;
                case "vendor":
                    query = "SELECT vendor_id, vendor_name FROM vendors";
                    break;
                case "committee":
                    query = "SELECT committee_id, committee_name FROM committees";
                    break;
                case "user":
                    query = "SELECT user_id, username FROM users";
                    break;
                default:
                    throw new Exception("Invalid entity type.");
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader[0]);
                        string name = reader[1].ToString();
                        entities.Add(new KeyValuePair<int, string>(id, name));
                    }
                }
            }
            return entities;
        }
    }
}
