using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;
using ITECManagementSystem.Models.ITECManagementSystem.Models;
using ITECManagementSystem.UI;

namespace ITECManagementSystem
{
    public partial class Registration : Form
    {
        private readonly ParticipantBL participantBL = new ParticipantBL();
        
        public Registration()
        {
            InitializeComponent();
            radioButton2.CheckedChanged += new EventHandler(radioButton2_CheckedChanged);
        }

        private void Registration_Load(object sender, EventArgs e)
        {

          
            LoadEditions();
            LoadEvents();
            LoadRoles();

        }

        private void LoadEditions()
        {
            comboBox2.DataSource = new BindingSource(participantBL.GetEditions(), null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        private void LoadEvents()
        {
            comboBox3.DataSource = new BindingSource(participantBL.GetEvents(), null);
            comboBox3.DisplayMember = "Value";
            comboBox3.ValueMember = "Key";
        }

        private void LoadRoles()
        {
            comboBox1.DataSource = new BindingSource(participantBL.GetRoles(), null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Participant participant = new Participant
                {
                    ItecId = Convert.ToInt32(comboBox2.SelectedValue),
                    Name = textBox1.Text.Trim(),
                    Email = textBox2.Text.Trim(),
                    Contact = textBox5.Text.Trim(),
                    Institute = textBox3.Text.Trim(),
                    RoleId = Convert.ToInt32(comboBox1.SelectedValue)
                };

                decimal feeAmount = Convert.ToDecimal(textBox4.Text);
                int eventId = Convert.ToInt32(comboBox3.SelectedValue);

                if (participantBL.RegisterParticipant(participant, eventId, feeAmount))
                {
                    MessageBox.Show("Registration successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                TeamRegistrationForm teamForm = new TeamRegistrationForm();
                teamForm.ShowDialog();
            }
        }
    }
}
