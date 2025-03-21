using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class DutyDL
    {
        private string connectionString = "server=localhost;port=3306;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;";
        public List<Duty> GetDuties()
        {
            List<Duty> duties = new List<Duty>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT duty_id, committee_id, assigned_to, task_description, deadline, status_id FROM duties";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Duty duty = new Duty
                            {
                                DutyId = Convert.ToInt32(reader["duty_id"]),
                                CommitteeId = Convert.ToInt32(reader["committee_id"]),
                                AssignedTo = reader["assigned_to"].ToString(),
                                TaskDescription = reader["task_description"].ToString(),
                                Deadline = Convert.ToDateTime(reader["deadline"]),
                                StatusId = Convert.ToInt32(reader["status_id"])
                            };
                            duties.Add(duty);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading duties: " + ex.Message);
                }
            }
            return duties;
        }
        public bool InsertDuty(Duty duty)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO duties (committee_id, assigned_to, task_description, deadline, status_id)
                        VALUES (@committee_id, @assigned_to, @task_description, @deadline, @status_id)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@committee_id", duty.CommitteeId);
                        cmd.Parameters.AddWithValue("@assigned_to", duty.AssignedTo);
                        cmd.Parameters.AddWithValue("@task_description", duty.TaskDescription);
                        cmd.Parameters.AddWithValue("@deadline", duty.Deadline.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@status_id", duty.StatusId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting duty: " + ex.Message);
                }
            }
        }
        public bool UpdateDuty(Duty duty)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        UPDATE duties 
                        SET committee_id = @committee_id, assigned_to = @assigned_to, task_description = @task_description, 
                            deadline = @deadline, status_id = @status_id
                        WHERE duty_id = @duty_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@committee_id", duty.CommitteeId);
                        cmd.Parameters.AddWithValue("@assigned_to", duty.AssignedTo);
                        cmd.Parameters.AddWithValue("@task_description", duty.TaskDescription);
                        cmd.Parameters.AddWithValue("@deadline", duty.Deadline.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@status_id", duty.StatusId);
                        cmd.Parameters.AddWithValue("@duty_id", duty.DutyId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating duty: " + ex.Message);
                }
            }
        }
        public bool DeleteDuty(int dutyId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM duties WHERE duty_id = @duty_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@duty_id", dutyId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting duty: " + ex.Message);
                }
            }
        }
    }
}
