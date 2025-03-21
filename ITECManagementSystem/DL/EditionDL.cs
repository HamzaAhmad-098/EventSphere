using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class EditionDL
    {
        private string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
        public List<Edition> GetEditions()
        {
            List<Edition> editions = new List<Edition>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT itec_id, year, theme, description FROM ITEC_Editions";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int itecId = reader["itec_id"] != DBNull.Value ? Convert.ToInt32(reader["itec_id"]) : 0;
                            int year = reader["year"] != DBNull.Value ? Convert.ToInt32(reader["year"]) : 0;
                            string theme = reader["theme"] != DBNull.Value ? reader["theme"].ToString() : "";
                            string description = reader["description"] != DBNull.Value ? reader["description"].ToString() : "";

                            editions.Add(new Edition(itecId, year, theme, description));
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading editions: " + ex.Message);
                }
            }
            return editions;
        }
        public void AddEdition(Edition edition)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO ITEC_Editions (year, theme, description) VALUES (@year, @theme, @description)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@year", edition.Year);
                        cmd.Parameters.AddWithValue("@theme", edition.Theme);
                        cmd.Parameters.AddWithValue("@description", edition.Description);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding edition: " + ex.Message);
                }
            }
        }
        public void UpdateEdition(Edition edition)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE ITEC_Editions SET year = @year, theme = @theme, description = @description WHERE itec_id = @itec_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itec_id", edition.ItecId);
                        cmd.Parameters.AddWithValue("@year", edition.Year);
                        cmd.Parameters.AddWithValue("@theme", edition.Theme);
                        cmd.Parameters.AddWithValue("@description", edition.Description);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating edition: " + ex.Message);
                }
            }
        }
        public void DeleteEdition(int itecId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM ITEC_Editions WHERE itec_id = @itec_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itec_id", itecId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting edition: " + ex.Message);
                }
            }
        }
    }
}
