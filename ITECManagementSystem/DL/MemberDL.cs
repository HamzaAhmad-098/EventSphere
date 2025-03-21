using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.DL
{
    public class MemberDL
    {
        private string connectionString = "server=localhost;port=3306;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;";
        public List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT member_id, committee_id, name, role_id FROM Committee_Members";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int memberId = reader["member_id"] != DBNull.Value ? Convert.ToInt32(reader["member_id"]) : 0;
                            int committeeId = reader["committee_id"] != DBNull.Value ? Convert.ToInt32(reader["committee_id"]) : 0;
                            string name = reader["name"] != DBNull.Value ? reader["name"].ToString() : "";
                            int roleId = reader["role_id"] != DBNull.Value ? Convert.ToInt32(reader["role_id"]) : 0;
                            members.Add(new Member { MemberId = memberId, CommitteeId = committeeId, Name = name, RoleId = roleId });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error loading members: " + ex.Message);
                }
            }
            return members;
        }

        public void AddMember(Member member)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Committee_Members (committee_id, name, role_id) VALUES (@committee_id, @name, @role_id)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@committee_id", member.CommitteeId);
                        cmd.Parameters.AddWithValue("@name", member.Name);
                        cmd.Parameters.AddWithValue("@role_id", member.RoleId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding member: " + ex.Message);
                }
            }
        }
        public void UpdateMember(Member member)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Committee_Members SET committee_id=@committee_id, name=@name, role_id=@role_id WHERE member_id=@member_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@committee_id", member.CommitteeId);
                        cmd.Parameters.AddWithValue("@name", member.Name);
                        cmd.Parameters.AddWithValue("@role_id", member.RoleId);
                        cmd.Parameters.AddWithValue("@member_id", member.MemberId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating member: " + ex.Message);
                }
            }
        }
        public void DeleteMember(int memberId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Committee_Members WHERE member_id=@member_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@member_id", memberId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting member: " + ex.Message);
                }
            }
        }
        public List<Member> GetMembersByCommittee(int committeeId)
        {
            List<Member> members = new List<Member>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT member_id, committee_id, name, role_id FROM committee_members WHERE committee_id = @committeeId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@committeeId", committeeId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Member member = new Member
                            {
                                MemberId = Convert.ToInt32(reader["member_id"]),
                                CommitteeId = Convert.ToInt32(reader["committee_id"]),
                                Name = reader["name"].ToString(),
                                RoleId = Convert.ToInt32(reader["role_id"])
                            };
                            members.Add(member);
                        }
                    }
                }
            }
            return members;
        }
    }
}
