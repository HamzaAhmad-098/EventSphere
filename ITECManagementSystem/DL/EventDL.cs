using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class EventDL
    {
        private readonly string connectionString = "server=localhost;port=3306;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;";
        public List<ItecEvent> GetEvents()
        {
            List<ItecEvent> events = new List<ItecEvent>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT event_id, itec_id, event_name, event_category_id, description, event_date, venue_id, committee_id FROM itec_events";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ItecEvent evt = new ItecEvent
                            {
                                EventId = Convert.ToInt32(reader["event_id"]),
                                ItecId = Convert.ToInt32(reader["itec_id"]),
                                EventName = reader["event_name"].ToString(),
                                EventCategoryId = Convert.ToInt32(reader["event_category_id"]),
                                Description = reader["description"].ToString(),
                                EventDate = Convert.ToDateTime(reader["event_date"]),
                                VenueId = Convert.ToInt32(reader["venue_id"]),
                                CommitteeId = Convert.ToInt32(reader["committee_id"])
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
        public bool InsertEvent(ItecEvent evt)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO itec_events (itec_id, event_name, event_category_id, description, event_date, venue_id, committee_id)
                        VALUES (@itec_id, @event_name, @event_category_id, @description, @event_date, @venue_id, @committee_id)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itec_id", evt.ItecId);
                        cmd.Parameters.AddWithValue("@event_name", evt.EventName);
                        cmd.Parameters.AddWithValue("@event_category_id", evt.EventCategoryId);
                        cmd.Parameters.AddWithValue("@description", evt.Description);
                        cmd.Parameters.AddWithValue("@event_date", evt.EventDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@venue_id", evt.VenueId);
                        cmd.Parameters.AddWithValue("@committee_id", evt.CommitteeId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting event: " + ex.Message);
                }
            }
        }
        public bool UpdateEvent(ItecEvent evt)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE itec_events 
                        SET itec_id=@itec_id, event_name=@event_name, event_category_id=@event_category_id, 
                            description=@description, event_date=@event_date, venue_id=@venue_id, committee_id=@committee_id
                        WHERE event_id=@event_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itec_id", evt.ItecId);
                        cmd.Parameters.AddWithValue("@event_name", evt.EventName);
                        cmd.Parameters.AddWithValue("@event_category_id", evt.EventCategoryId);
                        cmd.Parameters.AddWithValue("@description", evt.Description);
                        cmd.Parameters.AddWithValue("@event_date", evt.EventDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@venue_id", evt.VenueId);
                        cmd.Parameters.AddWithValue("@committee_id", evt.CommitteeId);
                        cmd.Parameters.AddWithValue("@event_id", evt.EventId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating event: " + ex.Message);
                }
            }
        }
        public bool DeleteEvent(int eventId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM itec_events WHERE event_id = @event_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@event_id", eventId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting event: " + ex.Message);
                }
            }
        }

        public List<ItechEdition> GetEditions()
        {
            List<ItechEdition> editions = new List<ItechEdition>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT itec_id, year, theme FROM itec_editions";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ItechEdition ed = new ItechEdition
                            {
                                ItecId = Convert.ToInt32(reader["itec_id"]),
                                Year = Convert.ToInt32(reader["year"]),
                                Theme = reader["theme"].ToString()
                            };
                            editions.Add(ed);
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
        public List<EventCategory> GetEventCategories()
        {
            List<EventCategory> categories = new List<EventCategory>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT event_category_id, category_name FROM event_categories";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EventCategory cat = new EventCategory
                            {
                                EventCategoryId = Convert.ToInt32(reader["event_category_id"]),
                                CategoryName = reader["category_name"].ToString()
                            };
                            categories.Add(cat);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading event categories: " + ex.Message);
                }
            }
            return categories;
        }
        public List<Committee> GetCommittees()
        {
            List<Committee> committees = new List<Committee>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT committee_id, committee_name FROM committees";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Committee com = new Committee()
                            {
                                committee_id = Convert.ToInt32(reader["committee_id"]),
                                committee_name = reader["committee_name"].ToString()
                            };
                            committees.Add(com);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading committees: " + ex.Message);
                }
            }
            return committees;
        }
        public List<Venue> GetVenues()
        {
            List<Venue> venues = new List<Venue>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT venue_id, venue_name FROM venues";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venue ven = new Venue
                            {
                                VenueId = Convert.ToInt32(reader["venue_id"]),
                                VenueName = reader["venue_name"].ToString()
                            };
                            venues.Add(ven);
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
