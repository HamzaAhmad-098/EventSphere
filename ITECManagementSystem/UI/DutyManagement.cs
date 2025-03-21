using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.UI
{
    public partial class DutyManagement : Form
    {
        DutyBL dutyBL = new DutyBL();
        CommitteeBL committeeBL = new CommitteeBL(); 
        LookupBL lookupBL = new LookupBL(); 
        MemberBL memberBL = new MemberBL();    

        public DutyManagement()
        {
            InitializeComponent();
        }

        private void DutyManagement_Load(object sender, EventArgs e)
        {
            LoadCommittees();
            LoadStatuses();  
            LoadDuties();
            dataGridViewDuties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadCommittees()
        {
            try
            {
                List<Committee> committees = committeeBL.GetCommittees();
                comboBoxCommittee.DataSource = committees;
                comboBoxCommittee.DisplayMember = "committee_name"; 
                comboBoxCommittee.ValueMember = "committee_id";
                comboBoxCommittee.SelectedIndexChanged += ComboBoxCommittee_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading committees: " + ex.Message);
            }
        }

        private void LoadStatuses()
        {
            try
            {
                var statuses = lookupBL.GetLookupValues("DutyStatus");
                comboBoxStatus.DataSource = new BindingSource(statuses, null);
                comboBoxStatus.DisplayMember = "Value";
                comboBoxStatus.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statuses: " + ex.Message);
            }
        }

        private void LoadDuties()
        {
            try
            {
                List<Duty> duties = dutyBL.GetDuties();
                dataGridViewDuties.DataSource = duties;
                dataGridViewDuties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading duties: " + ex.Message);
            }
        }
        private void ComboBoxCommittee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCommittee.SelectedValue != null)
            {
                int committeeId = Convert.ToInt32(comboBoxCommittee.SelectedValue);
                try
                {
                    List<Member> members = memberBL.GetMembersByCommittee(committeeId);
                    comboBoxAssignedTo.DataSource = new BindingSource(members, null);
                    comboBoxAssignedTo.DisplayMember = "Name";   
                    comboBoxAssignedTo.ValueMember = "MemberId";   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading committee members: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Duty duty = new Duty
                {
                    CommitteeId = Convert.ToInt32(comboBoxCommittee.SelectedValue),
                    AssignedTo = comboBoxAssignedTo.Text.Trim(),
                    TaskDescription = txtTaskDescription.Text.Trim(),
                    Deadline = dateTimePickerDeadline.Value,
                    StatusId = Convert.ToInt32(comboBoxStatus.SelectedValue)
                };

                if (dutyBL.AddDuty(duty))
                {
                    MessageBox.Show("Duty added successfully!");
                    LoadDuties();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add duty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding duty: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewDuties.SelectedRows.Count > 0)
            {
                try
                {
                    int dutyId = Convert.ToInt32(dataGridViewDuties.SelectedRows[0].Cells["DutyId"].Value);
                    Duty duty = new Duty
                    {
                        DutyId = dutyId,
                        CommitteeId = Convert.ToInt32(comboBoxCommittee.SelectedValue),
                        AssignedTo = comboBoxAssignedTo.Text.Trim(),
                        TaskDescription = txtTaskDescription.Text.Trim(),
                        Deadline = dateTimePickerDeadline.Value,
                        StatusId = Convert.ToInt32(comboBoxStatus.SelectedValue)
                    };

                    if (dutyBL.UpdateDuty(duty))
                    {
                        MessageBox.Show("Duty updated successfully!");
                        LoadDuties();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update duty.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating duty: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a duty to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDuties.SelectedRows.Count > 0)
            {
                try
                {
                    int dutyId = Convert.ToInt32(dataGridViewDuties.SelectedRows[0].Cells["DutyId"].Value);
                    if (dutyBL.DeleteDuty(dutyId))
                    {
                        MessageBox.Show("Duty deleted successfully!");
                        LoadDuties();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete duty.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting duty: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a duty to delete.");
            }
        }

        private void dataGridViewDuties_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Duty selectedDuty = (Duty)dataGridViewDuties.Rows[e.RowIndex].DataBoundItem;
                comboBoxCommittee.SelectedValue = selectedDuty.CommitteeId;
                comboBoxAssignedTo.Text = selectedDuty.AssignedTo;
                txtTaskDescription.Text = selectedDuty.TaskDescription;
                dateTimePickerDeadline.Value = selectedDuty.Deadline;
                comboBoxStatus.SelectedValue = selectedDuty.StatusId;
            }
        }

        private void ClearFields()
        {
            comboBoxCommittee.SelectedIndex = -1;
            comboBoxAssignedTo.SelectedIndex = -1;
            txtTaskDescription.Text = "";
            dateTimePickerDeadline.Value = DateTime.Now;
            comboBoxStatus.SelectedIndex = -1;
        }
    }
}
