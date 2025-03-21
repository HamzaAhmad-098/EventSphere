using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class CommitteeDL
    {
        private string connectionString = "server=localhost;port=3306;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;";
        public List<Committee> GetCommittees()
        {
            List<Committee> committees = new List<Committee>();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT committee_id, itec_id, committee_name FROM committees";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int committeeId = reader["committee_id"] != DBNull.Value ? Convert.ToInt32(reader["committee_id"]) : 0;
                                int itecId = reader["itec_id"] != DBNull.Value ? Convert.ToInt32(reader["itec_id"]) : 0;
                                string committeeName = reader["committee_name"] != DBNull.Value ? reader["committee_name"].ToString() : "Unknown";

                                committees.Add(new Committee(committeeId, itecId, committeeName));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading committees from database: " + ex.Message);
                }
            }
            return committees;
        }
        public List<ItechEdition> GetItechEditions()
        {
            List<ItechEdition> editions = new List<ItechEdition>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT itec_id, year , theme FROM itec_editions";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            editions.Add(new ItechEdition(
                            Convert.ToInt32(reader["itec_id"]),
                            Convert.ToInt32(reader["year"]),
                            reader["theme"].ToString()
                        ));

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading ITEC editions: " + ex.Message);
                }
            }
            return editions;
        }
        public void AddCommittee(Committee committee)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO committees (itec_id, committee_name) VALUES (@itec_id, @committee_name)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@itec_id", committee.itec_id);
                        cmd.Parameters.AddWithValue("@committee_name", committee.committee_name);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding committee: " + ex.Message);
                }
            }
        }
        public void UpdateCommittee(Committee committee)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE committees SET itec_id = @itec_id, committee_name = @committee_name WHERE committee_id = @committee_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@itec_id", committee.itec_id);
                        cmd.Parameters.AddWithValue("@committee_name", committee.committee_name);
                        cmd.Parameters.AddWithValue("@committee_id", committee.committee_id);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating committee: " + ex.Message);
                }
            }
        }

        public void DeleteCommittee(int committeeId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM committees WHERE committee_id = @committee_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@committee_id", committeeId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting committee: " + ex.Message);
                }
            }
        }
    }
}
