using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;
using ITECManagementSystem.Models.ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class ParticipantDL
    {
        private string connectionString = "server=localhost;port=3306;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;";
        public bool RegisterParticipant(Participant participant, int eventId, decimal feeAmount)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertParticipantQuery = @"
                        INSERT INTO participants (itec_id, name, email, contact, institute, role_id)
                        VALUES (@itec_id, @name, @email, @contact, @institute, @role_id);
                        SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(insertParticipantQuery, conn);
                    cmd.Parameters.AddWithValue("@itec_id", participant.ItecId);
                    cmd.Parameters.AddWithValue("@name", participant.Name);
                    cmd.Parameters.AddWithValue("@email", participant.Email);
                    cmd.Parameters.AddWithValue("@contact", participant.Contact);
                    cmd.Parameters.AddWithValue("@institute", participant.Institute);
                    cmd.Parameters.AddWithValue("@role_id", participant.RoleId);
                    int participantId = Convert.ToInt32(cmd.ExecuteScalar());
                    string insertRegistrationQuery = @"
                        INSERT INTO event_participants (event_id, participant_id, payment_status_id, fee_amount)
                        VALUES (@event_id, @participant_id, @payment_status_id, @fee_amount)";
                    MySqlCommand cmd2 = new MySqlCommand(insertRegistrationQuery, conn);
                    cmd2.Parameters.AddWithValue("@event_id", eventId);
                    cmd2.Parameters.AddWithValue("@participant_id", participantId);
                    cmd2.Parameters.AddWithValue("@payment_status_id", 13);
                    cmd2.Parameters.AddWithValue("@fee_amount", feeAmount);
                    cmd2.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error registering participant: " + ex.Message);
                }
            }
        }
        public List<KeyValuePair<int, string>> GetEditions()
        {
            List<KeyValuePair<int, string>> editions = new List<KeyValuePair<int, string>>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT itec_id, year FROM itec_editions";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    editions.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(reader["itec_id"]),
                        reader["year"].ToString()
                    ));
                }
            }
            return editions;
        }
        public List<KeyValuePair<int, string>> GetEvents()
        {
            List<KeyValuePair<int, string>> events = new List<KeyValuePair<int, string>>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT event_id, event_name FROM itec_events";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    events.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(reader["event_id"]),
                        reader["event_name"].ToString()
                    ));
                }
            }
            return events;
        }
        public List<KeyValuePair<int, string>> GetRoles()
        {
            List<KeyValuePair<int, string>> roles = new List<KeyValuePair<int, string>>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT role_id, role_name FROM roles";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    roles.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(reader["role_id"]),
                        reader["role_name"].ToString()
                    ));
                }
            }
            return roles;
        }
    }
}
