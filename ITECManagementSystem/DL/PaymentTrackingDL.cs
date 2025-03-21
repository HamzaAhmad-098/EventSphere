using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class PaymentTrackingDL
    {
        private string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
        public List<PaymentTracking> GetPayments()
        {
            List<PaymentTracking> payments = new List<PaymentTracking>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                           ep.registration_id,
                           p.name AS participant_name,
                           e.event_name,
                           ep.fee_amount,
                           ep.payment_status_id,
                           CASE WHEN ep.payment_status_id = 1 THEN 'Pending' ELSE 'Paid' END AS payment_status
                        FROM event_participants ep
                        JOIN participants p ON ep.participant_id = p.participant_id
                        JOIN itec_events e ON ep.event_id = e.event_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PaymentTracking pt = new PaymentTracking
                            {
                                RegistrationId = reader["registration_id"] != DBNull.Value ? Convert.ToInt32(reader["registration_id"]) : 0,
                                ParticipantName = reader["participant_name"] != DBNull.Value ? reader["participant_name"].ToString() : "",
                                EventName = reader["event_name"] != DBNull.Value ? reader["event_name"].ToString() : "",
                                FeeAmount = reader["fee_amount"] != DBNull.Value ? Convert.ToDecimal(reader["fee_amount"]) : 0,
                                PaymentStatusId = reader["payment_status_id"] != DBNull.Value ? Convert.ToInt32(reader["payment_status_id"]) : 0,
                                PaymentStatus = reader["payment_status"] != DBNull.Value ? reader["payment_status"].ToString() : ""
                            };
                            payments.Add(pt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading payments: " + ex.Message);
                }
            }
            return payments;
        }
        public void UpdatePaymentStatus(int registrationId, int newStatusId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE event_participants SET payment_status_id = @statusID WHERE registration_id = @registrationID";
                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@statusID", newStatusId);
                        cmd.Parameters.AddWithValue("@registrationID", registrationId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating payment status: " + ex.Message);
                }
            }
        }
        public List<PaymentTracking> SearchPayments(string searchText)
        {
            List<PaymentTracking> payments = new List<PaymentTracking>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                           ep.registration_id,
                           p.name AS participant_name,
                           e.event_name,
                           ep.fee_amount,
                           ep.payment_status_id,
                           CASE WHEN ep.payment_status_id = 1 THEN 'Pending' ELSE 'Paid' END AS payment_status
                        FROM event_participants ep
                        JOIN participants p ON ep.participant_id = p.participant_id
                        JOIN itec_events e ON ep.event_id = e.event_id
                        WHERE p.name LIKE @SearchText";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PaymentTracking pt = new PaymentTracking
                                {
                                    RegistrationId = reader["registration_id"] != DBNull.Value ? Convert.ToInt32(reader["registration_id"]) : 0,
                                    ParticipantName = reader["participant_name"] != DBNull.Value ? reader["participant_name"].ToString() : "",
                                    EventName = reader["event_name"] != DBNull.Value ? reader["event_name"].ToString() : "",
                                    FeeAmount = reader["fee_amount"] != DBNull.Value ? Convert.ToDecimal(reader["fee_amount"]) : 0,
                                    PaymentStatusId = reader["payment_status_id"] != DBNull.Value ? Convert.ToInt32(reader["payment_status_id"]) : 0,
                                    PaymentStatus = reader["payment_status"] != DBNull.Value ? reader["payment_status"].ToString() : ""
                                };
                                payments.Add(pt);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error searching payments: " + ex.Message);
                }
            }
            return payments;
        }
    }
}
