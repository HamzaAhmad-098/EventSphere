using ITECManagementSystem.BL;
using ITECManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITECManagementSystem.UI
{
    public partial class TeamRegistrationForm : Form
    {
        TeamBL teamBL = new TeamBL();
         EventBL eventBL = new EventBL();
        private List<int> participantIds = new List<int>();

        public TeamRegistrationForm()
        {
            InitializeComponent();
            LoadParticipants();
            LoadEvents();
        }
        private void TeamRegistrationForm_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadEvents() 
        {
            comboBoxEvent.DataSource = eventBL.GetEvents();
            comboBoxEvent.DisplayMember = "EventName";
            comboBoxEvent.ValueMember = "EventId";
        }
        private void LoadParticipants()
        {
            comboBoxParticipants.DataSource = teamBL.GetParticipants();
            comboBoxParticipants.DisplayMember = "Name";
            comboBoxParticipants.ValueMember = "ParticipantId";
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            if (comboBoxParticipants.SelectedValue != null)
            {
                int participantId = Convert.ToInt32(comboBoxParticipants.SelectedValue);
                participantIds.Add(participantId);
                listBoxParticipants.Items.Add(comboBoxParticipants.Text);
            }
        }

        private void btnSaveTeam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeamName.Text) || participantIds.Count == 0)
            {
                MessageBox.Show("Please enter a team name and add participants.");
                return;
            }

            Team team = new Team
            {
                EventId = Convert.ToInt32(comboBoxEvent.SelectedValue),
                TeamName = txtTeamName.Text.Trim()
            };

            if (teamBL.AddTeam(team, participantIds))
            {
                MessageBox.Show("Team registered successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error registering team.");
            }
        }
    }

}
