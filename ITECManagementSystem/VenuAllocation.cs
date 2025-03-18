using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ITECManagementSystem
{
    public partial class VenuAllocation : Form
    {
        string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";

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
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT event_id, event_name FROM itec_events";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable eventTable = new DataTable();
                adapter.Fill(eventTable);
                comboBoxEvent.DataSource = eventTable;
                comboBoxEvent.DisplayMember = "event_name";
                comboBoxEvent.ValueMember = "event_id";
            }
        }
        private void LoadVenues()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT venue_id, venue_name FROM venues";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable venueTable = new DataTable();
                adapter.Fill(venueTable);

                comboBoxVenue.DataSource = venueTable;
                comboBoxVenue.DisplayMember = "venue_name";
                comboBoxVenue.ValueMember = "venue_id";
            }
        }
        private void LoadVenueAllocations()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        va.venue_allocation_id,
                        va.event_id,
                        va.venue_id,
                        e.event_name,
                        v.venue_name,
                        va.assigned_date,
                        TIME_FORMAT(va.assigned_time, '%H:%i') AS assigned_time
                    FROM venue_allocations va
                    JOIN itec_events e ON va.event_id = e.event_id
                    JOIN venues v ON va.venue_id = v.venue_id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewAllocations.DataSource = dt;
                dataGridViewAllocations.Columns["event_id"].Visible = false;
                dataGridViewAllocations.Columns["venue_id"].Visible = false;

                dataGridViewAllocations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void btnAllocate_Click_1(object sender, EventArgs e)
        {
            try
            {
                int eventID = Convert.ToInt32(comboBoxEvent.SelectedValue);
                int venueID = Convert.ToInt32(comboBoxVenue.SelectedValue);

                string assignedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string assignedTime = maskedTextBox1.Text;
                if (!IsValidTime(assignedTime))
                {
                    MessageBox.Show("Please enter a valid time in HH:mm format (e.g., 14:30).",
                                    "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string conflictQuery = @"
                        SELECT COUNT(*) FROM venue_allocations 
                        WHERE venue_id = @venueID 
                          AND assigned_date = @assignedDate 
                          AND assigned_time = @assignedTime";

                    using (MySqlCommand conflictCmd = new MySqlCommand(conflictQuery, conn))
                    {
                        conflictCmd.Parameters.AddWithValue("@venueID", venueID);
                        conflictCmd.Parameters.AddWithValue("@assignedDate", assignedDate);
                        conflictCmd.Parameters.AddWithValue("@assignedTime", assignedTime);

                        int count = Convert.ToInt32(conflictCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("This venue is already allocated at the selected date and time. Please choose another venue or time slot.",
                                            "Conflict Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    string insertQuery = @"
                        INSERT INTO venue_allocations (event_id, venue_id, assigned_date, assigned_time) 
                        VALUES (@eventID, @venueID, @assignedDate, @assignedTime)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@eventID", eventID);
                        cmd.Parameters.AddWithValue("@venueID", venueID);
                        cmd.Parameters.AddWithValue("@assignedDate", assignedDate);
                        cmd.Parameters.AddWithValue("@assignedTime", assignedTime);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Venue allocated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadVenueAllocations();
                        }
                        else
                        {
                            MessageBox.Show("Failed to allocate venue. No rows were inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllocations.SelectedRows.Count > 0)
            {
                int selectedVenuAllocationId = GetSelectedVenu_Id();

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    try
                    {
                        int eventID = Convert.ToInt32(comboBoxEvent.SelectedValue);
                        int venueID = Convert.ToInt32(comboBoxVenue.SelectedValue);

                        string assignedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                        string assignedTime = maskedTextBox1.Text;
                        con.Open();
                        string updateQuery = @"
                            UPDATE venue_allocations
                            SET event_id = @eventID,
                                venue_id = @venueID,
                                assigned_date = @assignedDate,
                                assigned_time = @assignedTime
                            WHERE venue_allocation_id = @allocationID";
                        MySqlCommand cmd = new MySqlCommand(updateQuery, con);
                        cmd.Parameters.AddWithValue("@eventID", eventID);
                        cmd.Parameters.AddWithValue("@venueID", venueID);
                        cmd.Parameters.AddWithValue("@assignedDate", assignedDate);
                        cmd.Parameters.AddWithValue("@assignedTime", assignedTime);
                        cmd.Parameters.AddWithValue("@allocationID", selectedVenuAllocationId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Venue updated successfully.");
                        LoadVenueAllocations();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error updating committee: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an allocation to update.");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedVenu_allocation_Id = GetSelectedVenu_Id();
            if (dataGridViewAllocations.SelectedRows.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this allocation?",
                                                        "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            con.Open();
                            string query = "DELETE FROM venue_allocations WHERE venue_allocation_id = @allocationID";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@allocationID", selectedVenu_allocation_Id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Venu deleted successfully.");
                            LoadVenueAllocations();
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Error deleting committee: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an allocation to delete.");
            }




        }
        private void dataGridViewAllocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAllocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private bool IsValidTime(string time)
        {
            if (string.IsNullOrWhiteSpace(time) || time.Contains("_"))
                return false;

            DateTime tempTime;
            return DateTime.TryParseExact(time, "HH:mm", null,
                System.Globalization.DateTimeStyles.None, out tempTime);
        }
        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidTime(maskedTextBox1.Text))
            {
                MessageBox.Show("Invalid time format. Please enter time as HH:mm (e.g., 14:30).",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBox1.Focus();
                e.Cancel = true;
            }
        }
        private int GetSelectedVenu_Id()
        {
            if (dataGridViewAllocations.SelectedRows.Count > 0)
            {
                int selectedCommitteeId = Convert.ToInt32(dataGridViewAllocations.SelectedRows[0].Cells["venue_allocation_id"].Value);
                return selectedCommitteeId;
            }
            else
            {
                MessageBox.Show("Please select a committee first.");
                return -1;
            }
        }

 
    }
}
