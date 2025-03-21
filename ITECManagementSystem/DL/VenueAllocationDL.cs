using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class VenueAllocationDL
    {
        private string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
        public List<VenueAllocation> GetVenueAllocations()
        {
            List<VenueAllocation> allocations = new List<VenueAllocation>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            va.venue_allocation_id,
                            va.event_id,
                            va.venue_id,
                            e.event_name,
                            v.venue_name,
                            va.assigned_date,
                            TIME_FORMAT(va.assigned_time, '%H:%i') AS assigned_time
                        FROM venue_allocations va
                        JOIN itec_events e ON va.event_id = e.event_id
                        JOIN venues v ON va.venue_id = v.venue_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            VenueAllocation allocation = new VenueAllocation
                            {
                                VenueAllocationId = reader["venue_allocation_id"] != DBNull.Value ? Convert.ToInt32(reader["venue_allocation_id"]) : 0,
                                EventId = reader["event_id"] != DBNull.Value ? Convert.ToInt32(reader["event_id"]) : 0,
                                VenueId = reader["venue_id"] != DBNull.Value ? Convert.ToInt32(reader["venue_id"]) : 0,
                                EventName = reader["event_name"] != DBNull.Value ? reader["event_name"].ToString() : "",
                                VenueName = reader["venue_name"] != DBNull.Value ? reader["venue_name"].ToString() : "",
                                AssignedDate = reader["assigned_date"] != DBNull.Value ? Convert.ToDateTime(reader["assigned_date"]) : DateTime.MinValue,
                                AssignedTime = reader["assigned_time"] != DBNull.Value ? reader["assigned_time"].ToString() : ""
                            };
                            allocations.Add(allocation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading venue allocations: " + ex.Message);
                }
            }
            return allocations;
        }
        public void AddVenueAllocation(VenueAllocation allocation)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO venue_allocations (event_id, venue_id, assigned_date, assigned_time) VALUES (@event_id, @venue_id, @assigned_date, @assigned_time)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@event_id", allocation.EventId);
                        cmd.Parameters.AddWithValue("@venue_id", allocation.VenueId);
                        cmd.Parameters.AddWithValue("@assigned_date", allocation.AssignedDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@assigned_time", allocation.AssignedTime);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding venue allocation: " + ex.Message);
                }
            }
        }
        public void UpdateVenueAllocation(VenueAllocation allocation)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE venue_allocations SET event_id=@event_id, venue_id=@venue_id, assigned_date=@assigned_date, assigned_time=@assigned_time WHERE venue_allocation_id=@venue_allocation_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@event_id", allocation.EventId);
                        cmd.Parameters.AddWithValue("@venue_id", allocation.VenueId);
                        cmd.Parameters.AddWithValue("@assigned_date", allocation.AssignedDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@assigned_time", allocation.AssignedTime);
                        cmd.Parameters.AddWithValue("@venue_allocation_id", allocation.VenueAllocationId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating venue allocation: " + ex.Message);
                }
            }
        }
        public void DeleteVenueAllocation(int venueAllocationId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM venue_allocations WHERE venue_allocation_id=@venue_allocation_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@venue_allocation_id", venueAllocationId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting venue allocation: " + ex.Message);
                }
            }
        }
        public List<ItecEvent> GetEvents()
        {
            List<ItecEvent> events = new List<ItecEvent>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT event_id, event_name FROM itec_events";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ItecEvent evt = new ItecEvent
                            {
                                EventId = reader["event_id"] != DBNull.Value ? Convert.ToInt32(reader["event_id"]) : 0,
                                EventName = reader["event_name"] != DBNull.Value ? reader["event_name"].ToString() : ""
                            };
                            events.Add(evt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading events: " + ex.Message);
                }
            }
            return events;
        }
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
    }
}
