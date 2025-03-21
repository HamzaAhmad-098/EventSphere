using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem
{
    public partial class AddVenu : Form
    {
        VenueBL venueBL = new VenueBL();
        private int selectedVenueID = -1;

        public AddVenu()
        {
            InitializeComponent();
            LoadVenues();
        }

        private void AddVenu_Load_1(object sender, EventArgs e)
        {
            dataGridViewVenues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadVenues()
        {
            try
            {
                List<Venue> venues = venueBL.GetVenues();
                dataGridViewVenues.DataSource = venues;
                dataGridViewVenues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading venues: " + ex.Message);
            }
         

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVenueName.Text) ||
                string.IsNullOrWhiteSpace(txtCapacity.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                Venue venue = new Venue
                {
                    VenueId = 0,
                    VenueName = txtVenueName.Text,
                    Capacity = Convert.ToInt32(txtCapacity.Text),
                    Location = txtLocation.Text
                };

                venueBL.AddVenue(venue);
                MessageBox.Show("Venue added successfully!");
                LoadVenues();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding venue: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int venueId = GetSelectedVenueId();
            if (venueId < 0)
            {
                MessageBox.Show("Please select a venue to update.");
                return;
            }

            try
            {
                Venue venue = new Venue
                {
                    VenueId = venueId,
                    VenueName = txtVenueName.Text,
                    Capacity = Convert.ToInt32(txtCapacity.Text),
                    Location = txtLocation.Text
                };

                venueBL.UpdateVenue(venue);
                MessageBox.Show("Venue updated successfully!");
                LoadVenues();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int venueId = GetSelectedVenueId();
            if (venueId == -1)
            {
                MessageBox.Show("Please select a venue to delete.");
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you want to delete this venue?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    venueBL.DeleteVenue(venueId);
                    MessageBox.Show("Venue deleted successfully!");
                    LoadVenues();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed: " + ex.Message);
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
            try
            {
                List<Venue> venues = venueBL.SearchVenues(searchText);
                dataGridViewVenues.DataSource = venues;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching venues: " + ex.Message);
            }
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
                int id = Convert.ToInt32(dataGridViewVenues.SelectedRows[0].Cells["VenueId"].Value);
                return id;
            }
            else
            {
                MessageBox.Show("Please select a venue first.");
                return -1;
            }
        }

        private void dataGridViewVenues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewVenues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewVenues_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
