using ITECManagementSystem.Models.ITECManagementSystem.Models;
using ITECManagementSystem.Models;
using MySql.Data.MySqlClient;

public class TeamDL
{
    private string connectionString = "server=localhost;database=MidProjectDb;user=root;password=Vat02842@Vat02842@;";
    public bool InsertTeam(Team team, List<int> participantIds)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlTransaction transaction = conn.BeginTransaction())
            {
                try
                {
                    string query = "INSERT INTO teams (event_id, team_name) VALUES (@event_id, @team_name)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@event_id", team.EventId);
                    cmd.Parameters.AddWithValue("@team_name", team.TeamName);
                    cmd.ExecuteNonQuery();
                    int teamId = (int)cmd.LastInsertedId;
                    foreach (var participantId in participantIds)
                    {
                        string participantQuery = "INSERT INTO team_participants (team_id, participant_id) VALUES (@team_id, @participant_id)";
                        MySqlCommand participantCmd = new MySqlCommand(participantQuery, conn);
                        participantCmd.Parameters.AddWithValue("@team_id", teamId);
                        participantCmd.Parameters.AddWithValue("@participant_id", participantId);
                        participantCmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
    public List<Participant> GetAllParticipants()
    {
        List<Participant> participants = new List<Participant>();
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT participant_id, name FROM participants";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    participants.Add(new Participant
                    {
                        ParticipantId = Convert.ToInt32(reader["participant_id"]),
                        Name = reader["name"].ToString()
                    });
                }
            }
        }
        return participants;
    }
}
