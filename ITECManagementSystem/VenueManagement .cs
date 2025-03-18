using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITECManagementSystem
{
    public partial class AddVenu : Form
    {
        public string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
        private int selectedVenueID = -1;
        public AddVenu()
        {
            InitializeComponent();
            LoadVenues();
        }
        private void AddVenu_Load_1(object sender, EventArgs e)
        {

        }
        private void LoadVenues()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM venues";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewVenues.DataSource = dt;

                dataGridViewVenues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVenueName.Text) || string.IsNullOrWhiteSpace(txtCapacity.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO venues (venue_name, capacity, location) VALUES (@name, @capacity, @location)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtVenueName.Text);
                    cmd.Parameters.AddWithValue("@capacity", Convert.ToInt32(txtCapacity.Text));
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Venue added successfully!");
                    LoadVenues();
                    ClearFields();
                }
                catch (Exception ex) {
                    MessageBox.Show("Error adding Venue " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedCommitteeId = GetSelectedVenueId();
            if (selectedVenueID < 0)
            {
                MessageBox.Show("Please select a venue to update.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE venues SET venue_name = @name, capacity = @capacity, location = @location WHERE venue_id = @venueID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", txtVenueName.Text);
                    cmd.Parameters.AddWithValue("@capacity", Convert.ToInt32(txtCapacity.Text));
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@venueID", selectedVenueID);
                    cmd.ExecuteNonQuery();  
                    MessageBox.Show("Venue updated successfully!");
                    LoadVenues();
                    ClearFields();
                    
                }
                catch (Exception ex ) {
                    MessageBox.Show("Update failed." + ex.Message);
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedVenueID = GetSelectedVenueId();
            if (selectedVenueID == -1)
            {
                MessageBox.Show("Please select a venue to delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this venue?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM venues WHERE venue_id = @venueID";

                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@venueID", selectedVenueID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Venue deleted successfully!");
                            LoadVenues();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Please try again.");
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Delete failed" + ex.Message);
                    }
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchVenue(txtSearchVenue.Text.Trim());
        }

        private void txtSearchVenue_TextChanged(object sender, EventArgs e)
        {
            SearchVenue(txtSearchVenue.Text.Trim());
        }

        private void SearchVenue(string searchText)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM venues WHERE venue_name LIKE @SearchText";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewVenues.DataSource = dt;
                }
            }
        }
        private void dgvCommittees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewVenues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void ClearFields()
        {
            txtVenueName.Text = "";
            txtCapacity.Text = "";
            txtLocation.Text = "";
            selectedVenueID = -1;
        }
        public int GetSelectedVenueId()
        {
            if (dataGridViewVenues.SelectedRows.Count > 0)
            {
                int selectedVenuId = Convert.ToInt32(dataGridViewVenues.SelectedRows[0].Cells["committee_id"].Value);
                return selectedVenuId;
            }
            else
            {
                MessageBox.Show("Please select a committee first.");
                return -1;
            }
        }
    }
}
