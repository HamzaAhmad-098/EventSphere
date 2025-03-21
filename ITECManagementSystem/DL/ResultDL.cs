using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class ResultDL
    {
        private string connectionString = "server=localhost;port=3306;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;";
        public List<ResultRecord> GetResults()
        {
            List<ResultRecord> results = new List<ResultRecord>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT r.result_id, e.event_name, p.name AS participant_name, t.team_name, 
                               r.position, r.score, r.remarks,
                               r.event_id,
                               p.participant_id,
                               t.team_id
                        FROM event_results r
                        LEFT JOIN itec_events e ON r.event_id = e.event_id
                        LEFT JOIN participants p ON r.participant_id = p.participant_id
                        LEFT JOIN teams t ON r.team_id = t.team_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ResultRecord result = new ResultRecord
                            {
                                ResultId = Convert.ToInt32(reader["result_id"]),
                                EventId = Convert.ToInt32(reader["event_id"]),
                                EventName = reader["event_name"].ToString(),
                                ParticipantId = reader["participant_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["participant_id"]),
                                ParticipantName = reader["participant_name"].ToString(),
                                TeamId = reader["team_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["team_id"]),
                                TeamName = reader["team_name"].ToString(),
                                Position = Convert.ToInt32(reader["position"]),
                                Score = Convert.ToDecimal(reader["score"]),
                                Remarks = reader["remarks"].ToString()
                            };
                            results.Add(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading results: " + ex.Message);
                }
            }
            return results;
        }
        public bool InsertResult(ResultRecord result)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO event_results (event_id, participant_id, team_id, position, score, remarks)
                        VALUES (@eventID, @participantID, @teamID, @position, @score, @remarks)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventID", result.EventId);
                        cmd.Parameters.AddWithValue("@participantID", (object)result.ParticipantId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@teamID", (object)result.TeamId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@position", result.Position);
                        cmd.Parameters.AddWithValue("@score", result.Score);
                        cmd.Parameters.AddWithValue("@remarks", result.Remarks);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting result: " + ex.Message);
                }
            }
        }
        public bool UpdateResult(ResultRecord result)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE event_results 
                        SET event_id = @eventID, participant_id = @participantID, team_id = @teamID, 
                            position = @position, score = @score, remarks = @remarks
                        WHERE result_id = @resultID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventID", result.EventId);
                        cmd.Parameters.AddWithValue("@participantID", (object)result.ParticipantId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@teamID", (object)result.TeamId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@position", result.Position);
                        cmd.Parameters.AddWithValue("@score", result.Score);
                        cmd.Parameters.AddWithValue("@remarks", result.Remarks);
                        cmd.Parameters.AddWithValue("@resultID", result.ResultId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating result: " + ex.Message);
                }
            }
        }
        public bool DeleteResult(int resultID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM event_results WHERE result_id = @resultID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@resultID", resultID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting result: " + ex.Message);
                }
            }
        }
    }
}
