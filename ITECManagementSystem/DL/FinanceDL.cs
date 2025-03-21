using System;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class FinanceDL
    {
        private string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";

        public bool InsertTransaction(FinanceTransaction txn)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO finances (itec_id, event_id, type_id, amount, from_entity_type, from_entity_id, to_entity_type, to_entity_id, description, date_recorded)
                        VALUES (@itec_id, @event_id, @type_id, @amount, @from_entity_type, @from_entity_id, @to_entity_type, @to_entity_id, @description, @date_recorded)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@itec_id", txn.ItecId);
                        cmd.Parameters.AddWithValue("@event_id", txn.EventId);
                        cmd.Parameters.AddWithValue("@type_id", txn.TypeId);
                        cmd.Parameters.AddWithValue("@amount", txn.Amount);
                        cmd.Parameters.AddWithValue("@from_entity_type", txn.FromEntityType);
                        cmd.Parameters.AddWithValue("@from_entity_id", txn.FromEntityId);
                        cmd.Parameters.AddWithValue("@to_entity_type", txn.ToEntityType);
                        cmd.Parameters.AddWithValue("@to_entity_id", txn.ToEntityId);
                        cmd.Parameters.AddWithValue("@description", txn.Description);
                        cmd.Parameters.AddWithValue("@date_recorded", txn.DateRecorded);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting transaction: " + ex.Message);
                }
            }
        }
    }
}
