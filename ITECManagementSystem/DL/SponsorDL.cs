using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class SponsorDL
    {
        private string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
        public bool InsertSponsor(Sponsor sponsor)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO sponsors (sponsor_name, contact) VALUES (@name, @contact)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", sponsor.SponsorName);
                        cmd.Parameters.AddWithValue("@contact", sponsor.Contact);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting sponsor: " + ex.Message);
                }
            }
        }
        public List<Sponsor> GetSponsors()
        {
            List<Sponsor> sponsors = new List<Sponsor>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT sponsor_id, sponsor_name, contact FROM sponsors";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sponsors.Add(new Sponsor
                            {
                                SponsorId = Convert.ToInt32(reader["sponsor_id"]),
                                SponsorName = reader["sponsor_name"].ToString(),
                                Contact = reader["contact"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading sponsors: " + ex.Message);
                }
            }
            return sponsors;
        }
        public bool UpdateSponsor(Sponsor sponsor)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE sponsors SET sponsor_name = @name, contact = @contact WHERE sponsor_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", sponsor.SponsorName);
                        cmd.Parameters.AddWithValue("@contact", sponsor.Contact);
                        cmd.Parameters.AddWithValue("@id", sponsor.SponsorId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating sponsor: " + ex.Message);
                }
            }
        }
        public bool DeleteSponsor(int sponsorId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM sponsors WHERE sponsor_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", sponsorId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting sponsor: " + ex.Message);
                }
            }
        }
    }
}
