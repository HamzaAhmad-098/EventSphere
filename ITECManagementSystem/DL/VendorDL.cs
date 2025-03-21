using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class VendorDL
    {
        private string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
        public bool InsertVendor(Vendor vendor)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO vendors (vendor_name, contact, service_type) VALUES (@name, @contact, @service_type)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", vendor.VendorName);
                        cmd.Parameters.AddWithValue("@contact", vendor.Contact);
                        cmd.Parameters.AddWithValue("@service_type", vendor.ServiceType);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error inserting vendor: " + ex.Message);
                }
            }
        }
        public List<Vendor> GetVendors()
        {
            List<Vendor> vendors = new List<Vendor>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT vendor_id, vendor_name, contact, service_type FROM vendors";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            vendors.Add(new Vendor
                            {
                                VendorId = Convert.ToInt32(reader["vendor_id"]),
                                VendorName = reader["vendor_name"].ToString(),
                                Contact = reader["contact"].ToString(),
                                ServiceType = reader["service_type"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading vendors: " + ex.Message);
                }
            }
            return vendors;
        }
        public bool UpdateVendor(Vendor vendor)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE vendors SET vendor_name = @name, contact = @contact, service_type = @service_type WHERE vendor_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", vendor.VendorName);
                        cmd.Parameters.AddWithValue("@contact", vendor.Contact);
                        cmd.Parameters.AddWithValue("@service_type", vendor.ServiceType);
                        cmd.Parameters.AddWithValue("@id", vendor.VendorId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating vendor: " + ex.Message);
                }
            }
        }
        public bool DeleteVendor(int vendorId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM vendors WHERE vendor_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", vendorId);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting vendor: " + ex.Message);
                }
            }
        }
    }
}
