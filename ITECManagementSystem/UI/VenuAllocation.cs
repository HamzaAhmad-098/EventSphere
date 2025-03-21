using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem
{
    public partial class VenuAllocation : Form
    {
        VenueAllocationBL allocationBL = new VenueAllocationBL();

        public VenuAllocation()
        {
            InitializeComponent();
        }

        private void VenuAllocation_Load(object sender, EventArgs e)
        {
            LoadEvents();
            LoadVenues();
            LoadVenueAllocations();
            dataGridViewAllocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAllocations.MultiSelect = false;
        }

        private void LoadEvents()
        {
            try
            {
                List<ItecEvent> events = allocationBL.GetEvents();
                comboBoxEvent.DataSource = events;
                comboBoxEvent.DisplayMember = "EventName";
                comboBoxEvent.ValueMember = "EventId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }

        private void LoadVenues()
        {
            try
            {
                List<Venue> venues = allocationBL.GetVenues();
                comboBoxVenue.DataSource = venues;
                comboBoxVenue.DisplayMember = "VenueName";
                comboBoxVenue.ValueMember = "VenueId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading venues: " + ex.Message);
            }
        }

        private void LoadVenueAllocations()
        {
            try
            {
                List<VenueAllocation> allocations = allocationBL.GetVenueAllocations();
                dataGridViewAllocations.DataSource = allocations;
                if (dataGridViewAllocations.Columns["EventId"] != null)
                    dataGridViewAllocations.Columns["EventId"].Visible = false;
                if (dataGridViewAllocations.Columns["VenueId"] != null)
                    dataGridViewAllocations.Columns["VenueId"].Visible = false;

                dataGridViewAllocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading venue allocations: " + ex.Message);
            }
        }

        private void btnAllocate_Click_1(object sender, EventArgs e)
        {
            try
            {
                int eventID = Convert.ToInt32(comboBoxEvent.SelectedValue);
                int venueID = Convert.ToInt32(comboBoxVenue.SelectedValue);
                DateTime assignedDate = dateTimePicker1.Value;
                string assignedTime = maskedTextBox1.Text;

                if (!IsValidTime(assignedTime))
                {
                    MessageBox.Show("Please enter a valid time in HH:mm format (e.g., 14:30).", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                VenueAllocation allocation = new VenueAllocation
                {
                    VenueAllocationId = 0,
                    EventId = eventID,
                    VenueId = venueID,
                    AssignedDate = assignedDate,
                    AssignedTime = assignedTime
                };

                allocationBL.AddVenueAllocation(allocation);
                MessageBox.Show("Venue allocated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadVenueAllocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedAllocationId = GetSelectedAllocationId();
                if (selectedAllocationId <= 0)
                    return;

                int eventID = Convert.ToInt32(comboBoxEvent.SelectedValue);
                int venueID = Convert.ToInt32(comboBoxVenue.SelectedValue);
                DateTime assignedDate = dateTimePicker1.Value;
                string assignedTime = maskedTextBox1.Text;

                VenueAllocation allocation = new VenueAllocation
                {
                    VenueAllocationId = selectedAllocationId,
                    EventId = eventID,
                    VenueId = venueID,
                    AssignedDate = assignedDate,
                    AssignedTime = assignedTime
                };

                allocationBL.UpdateVenueAllocation(allocation);
                MessageBox.Show("Venue updated successfully.");
                LoadVenueAllocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating venue allocation: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedAllocationId = GetSelectedAllocationId();
                if (selectedAllocationId <= 0)
                    return;

                DialogResult result = MessageBox.Show("Are you sure you want to delete this allocation?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    allocationBL.DeleteVenueAllocation(selectedAllocationId);
                    MessageBox.Show("Venue allocation deleted successfully.");
                    LoadVenueAllocations();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting venue allocation: " + ex.Message);
            }
        }

        private int GetSelectedAllocationId()
        {
            if (dataGridViewAllocations.SelectedRows.Count > 0)
            {
                VenueAllocation selected = (VenueAllocation)dataGridViewAllocations.SelectedRows[0].DataBoundItem;
                return selected.VenueAllocationId;
            }
            else
            {
                MessageBox.Show("Please select an allocation first.");
                return -1;
            }
        }

        private bool IsValidTime(string time)
        {
            if (string.IsNullOrWhiteSpace(time) || time.Contains("_"))
                return false;

            DateTime tempTime;
            return DateTime.TryParseExact(time, "HH:mm", null, System.Globalization.DateTimeStyles.None, out tempTime);
        }

        private void maskedTextBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsValidTime(maskedTextBox1.Text))
            {
                MessageBox.Show("Invalid time format. Please enter time as HH:mm (e.g., 14:30).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox1.Focus();
                e.Cancel = true;
            }
        }

        private void dataGridViewAllocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAllocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
