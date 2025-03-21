using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class VenueDL
    {
        private string connectionString = "server=localhost;port=3306;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;";
        public List<Venue> GetVenues()
        {
            List<Venue> venues = new List<Venue>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT venue_id, venue_name, capacity, location FROM venues";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venue venue = new Venue
                            {
                                VenueId = reader["venue_id"] != DBNull.Value ? Convert.ToInt32(reader["venue_id"]) : 0,
                                VenueName = reader["venue_name"] != DBNull.Value ? reader["venue_name"].ToString() : "",
                                Capacity = reader["capacity"] != DBNull.Value ? Convert.ToInt32(reader["capacity"]) : 0,
                                Location = reader["location"] != DBNull.Value ? reader["location"].ToString() : ""
                            };
                            venues.Add(venue);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading venues: " + ex.Message);
                }
            }
            return venues;
        }
        public void AddVenue(Venue venue)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO venues (venue_name, capacity, location) VALUES (@name, @capacity, @location)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", venue.VenueName);
                        cmd.Parameters.AddWithValue("@capacity", venue.Capacity);
                        cmd.Parameters.AddWithValue("@location", venue.Location);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding venue: " + ex.Message);
                }
            }
        }
        public void UpdateVenue(Venue venue)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE venues SET venue_name = @name, capacity = @capacity, location = @location WHERE venue_id = @venueID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", venue.VenueName);
                        cmd.Parameters.AddWithValue("@capacity", venue.Capacity);
                        cmd.Parameters.AddWithValue("@location", venue.Location);
                        cmd.Parameters.AddWithValue("@venueID", venue.VenueId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating venue: " + ex.Message);
                }
            }
        }
        public void DeleteVenue(int venueId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM venues WHERE venue_id = @venueID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@venueID", venueId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting venue: " + ex.Message);
                }
            }
        }
        public List<Venue> SearchVenues(string searchText)
        {
            List<Venue> venues = new List<Venue>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT venue_id, venue_name, capacity, location FROM venues WHERE venue_name LIKE @searchText";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Venue venue = new Venue
                                {
                                    VenueId = reader["venue_id"] != DBNull.Value ? Convert.ToInt32(reader["venue_id"]) : 0,
                                    VenueName = reader["venue_name"] != DBNull.Value ? reader["venue_name"].ToString() : "",
                                    Capacity = reader["capacity"] != DBNull.Value ? Convert.ToInt32(reader["capacity"]) : 0,
                                    Location = reader["location"] != DBNull.Value ? reader["location"].ToString() : ""
                                };
                                venues.Add(venue);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error searching venues: " + ex.Message);
                }
            }
            return venues;
        }
    }
}
