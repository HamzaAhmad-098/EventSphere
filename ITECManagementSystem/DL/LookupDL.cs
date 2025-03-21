using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ITECManagementSystem.DL
{
    public class LookupDL
    {
        private string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
        public List<KeyValuePair<int, string>> GetLookupValues(string category)
        {
            List<KeyValuePair<int, string>> lookupValues = new List<KeyValuePair<int, string>>();
            string query = "SELECT lookup_id, value FROM lookup WHERE category = @category";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@category", category);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["lookup_id"]);
                            string val = reader["value"].ToString();
                            lookupValues.Add(new KeyValuePair<int, string>(id, val));
                        }
                    }
                }
            }
            return lookupValues;
        }
    }
}
