using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITECManagementSystem
{
    public partial class ResultManagement : Form
    {
        string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";

        public ResultManagement()
        {
            InitializeComponent();
        }

        private void ResultManagement_Load(object sender, EventArgs e)
        {
            LoadEvents();
            LoadParticipants();
            LoadTeams();
            LoadResults();
        }

        private void LoadEvents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT event_id, event_name FROM itec_events";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxEvent.DataSource = dt;
                comboBoxEvent.DisplayMember = "event_name";
                comboBoxEvent.ValueMember = "event_id";
            }
        }

        private void LoadParticipants()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name , participant_id FROM participants";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxParticipant.DataSource = dt;
                comboBoxParticipant.DisplayMember = "name";
                comboBoxParticipant.ValueMember = "participant_id";
            }
        }

        private void LoadTeams()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT team_id, team_name FROM teams";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                comboBoxTeam.DataSource = dt;
                comboBoxTeam.DisplayMember = "team_name";
                comboBoxTeam.ValueMember = "team_id";
            }
        }

        private void LoadResults()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT r.result_id, e.event_name, p.name, t.team_name, 
                           r.position, r.score, r.remarks
                    FROM event_results r
                    LEFT JOIN itec_events e ON r.event_id = e.event_id
                    LEFT JOIN participants p ON r.participant_id = p.participant_id
                    LEFT JOIN teams t ON r.team_id = t.team_id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewResults.DataSource = dt;
                dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO event_results (event_id, participant_id, team_id, position, score, remarks) 
                         VALUES (@eventID, @participantID, @teamID, @position, @score, @remarks)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eventID", comboBoxEvent.SelectedValue);
                    cmd.Parameters.AddWithValue("@participantID", comboBoxParticipant.SelectedValue ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@teamID", comboBoxTeam.SelectedValue ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@position", numericUpDownPosition.Value);
                    cmd.Parameters.AddWithValue("@score", Convert.ToDecimal(textBoxScore.Text));
                    cmd.Parameters.AddWithValue("@remarks", textBoxRemarks.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Result saved successfully!");
                    LoadResults();
                }
            }
        }
        private void btnDeleteResult_Click(object sender, EventArgs e)
        {
            if (dataGridViewResults.SelectedRows.Count > 0)
            {
                int resultID = Convert.ToInt32(dataGridViewResults.SelectedRows[0].Cells["result_id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM event_results WHERE result_id = @resultID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@resultID", resultID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Result deleted successfully!");
                LoadResults();
            }
        }
        private void btnUpdateResult_Click(object sender, EventArgs e)
        {
            if (dataGridViewResults.SelectedRows.Count > 0)
            {
                int resultID = Convert.ToInt32(dataGridViewResults.SelectedRows[0].Cells["result_id"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE event_results 
                             SET event_id = @eventID, participant_id = @participantID, team_id = @teamID, 
                                 position = @position, score = @score, remarks = @remarks
                             WHERE result_id = @resultID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventID", comboBoxEvent.SelectedValue);
                        cmd.Parameters.AddWithValue("@participantID", comboBoxParticipant.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@teamID", comboBoxTeam.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@position", numericUpDownPosition.Value);
                        cmd.Parameters.AddWithValue("@score", Convert.ToDecimal(textBoxScore.Text));
                        cmd.Parameters.AddWithValue("@remarks", textBoxRemarks.Text);
                        cmd.Parameters.AddWithValue("@resultID", resultID);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Result updated successfully!");
                        LoadResults();
                    }
                }
            }
        }

    }
}
