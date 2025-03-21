using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;
using Org.BouncyCastle.Asn1.Crmf;

namespace ITECManagementSystem
{
    

    public partial class ResultManagement : Form
    {
        ResultBL resultBL = new ResultBL();

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
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;"))
            {
                conn.Open();
                string query = "SELECT event_id, event_name FROM itec_events";
                var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(query, conn);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                comboBoxEvent.DataSource = dt;
                comboBoxEvent.DisplayMember = "event_name";
                comboBoxEvent.ValueMember = "event_id";
            }
        }

        private void LoadParticipants()
        {
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;"))
            {
                conn.Open();
                string query = "SELECT name, participant_id FROM participants";
                var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(query, conn);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                comboBoxParticipant.DataSource = dt;
                comboBoxParticipant.DisplayMember = "name";
                comboBoxParticipant.ValueMember = "participant_id";
            }
        }

        private void LoadTeams()
        {
            using (var conn = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;"))
            {
                conn.Open();
                string query = "SELECT team_id, team_name FROM teams";
                var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(query, conn);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                comboBoxTeam.DataSource = dt;
                comboBoxTeam.DisplayMember = "team_name";
                comboBoxTeam.ValueMember = "team_id";
            }
        }

        private void LoadResults()
        {
            try
            {
                List<ResultRecord> results = resultBL.GetResults();
                dataGridViewResults.DataSource = results;
                dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading results: " + ex.Message);
            }
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            try
            {
                ResultRecord result = new ResultRecord
                {
                    EventId = Convert.ToInt32(comboBoxEvent.SelectedValue),
                    ParticipantId = comboBoxParticipant.SelectedValue != null ? (int?)Convert.ToInt32(comboBoxParticipant.SelectedValue) : null,
                    TeamId = comboBoxTeam.SelectedValue != null ? (int?)Convert.ToInt32(comboBoxTeam.SelectedValue) : null,
                    Position = Convert.ToInt32(numericUpDownPosition.Value),
                    Score = Convert.ToDecimal(textBoxScore.Text),
                    Remarks = textBoxRemarks.Text
                };

                if (resultBL.SaveResult(result))
                {
                    MessageBox.Show("Result saved successfully!");
                    LoadResults();
                }
                else
                {
                    MessageBox.Show("Failed to save result.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving result: " + ex.Message);
            }
        }

        private void btnUpdateResult_Click(object sender, EventArgs e)
        {
            if (dataGridViewResults.SelectedRows.Count > 0)
            {
                try
                {
                    int resultID = Convert.ToInt32(dataGridViewResults.SelectedRows[0].Cells["ResultId"].Value);
                    ResultRecord result = new ResultRecord
                    {
                        ResultId = resultID,
                        EventId = Convert.ToInt32(comboBoxEvent.SelectedValue),
                        ParticipantId = comboBoxParticipant.SelectedValue != null ? (int?)Convert.ToInt32(comboBoxParticipant.SelectedValue) : null,
                        TeamId = comboBoxTeam.SelectedValue != null ? (int?)Convert.ToInt32(comboBoxTeam.SelectedValue) : null,
                        Position = Convert.ToInt32(numericUpDownPosition.Value),
                        Score = Convert.ToDecimal(textBoxScore.Text),
                        Remarks = textBoxRemarks.Text
                    };

                    if (resultBL.UpdateResult(result))
                    {
                        MessageBox.Show("Result updated successfully!");
                        LoadResults();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update result.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating result: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an event result to update.");
            }
        }

        private void btnDeleteResult_Click(object sender, EventArgs e)
        {
            if (dataGridViewResults.SelectedRows.Count > 0)
            {
                try
                {
                    int resultID = Convert.ToInt32(dataGridViewResults.SelectedRows[0].Cells["ResultId"].Value);
                    if (resultBL.DeleteResult(resultID))
                    {
                        MessageBox.Show("Result deleted successfully!");
                        LoadResults();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete result.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting result: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an event result to delete.");
            }
        }

        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ItecEvent selectedEvent = (ItecEvent)dataGridViewResults.Rows[e.RowIndex].DataBoundItem;
                ResultRecord selectedResult = (ResultRecord)dataGridViewResults.Rows[e.RowIndex].DataBoundItem;
                comboBoxEvent.SelectedValue = selectedResult.EventId;
                if (selectedResult.ParticipantId.HasValue)
                    comboBoxParticipant.SelectedValue = selectedResult.ParticipantId.Value;
                if (selectedResult.TeamId.HasValue)
                    comboBoxTeam.SelectedValue = selectedResult.TeamId.Value;
                numericUpDownPosition.Value = selectedResult.Position;
                textBoxScore.Text = selectedResult.Score.ToString();
                textBoxRemarks.Text = selectedResult.Remarks;
            }
        }


    }
}
