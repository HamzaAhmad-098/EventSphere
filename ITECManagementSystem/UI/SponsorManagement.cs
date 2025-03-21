using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.UI
{
    public partial class SponsorManagement : Form
    {
        SponsorBL sponsorBL = new SponsorBL();

        public SponsorManagement()
        {
            InitializeComponent();
        }

        private void SponsorManagement_Load(object sender, EventArgs e)
        {
            LoadSponsors();
        }

        private void LoadSponsors()
        {
            try
            {
                List<Sponsor> sponsors = sponsorBL.GetSponsors();
                dataGridViewSponsors.DataSource = sponsors;
                dataGridViewSponsors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sponsors: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Sponsor sponsor = new Sponsor
                {
                    SponsorName = txtSponsorName.Text.Trim(),
                    Contact = txtContact.Text.Trim()
                };

                if (sponsorBL.AddSponsor(sponsor))
                {
                    MessageBox.Show("Sponsor added successfully!");
                    LoadSponsors();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add sponsor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding sponsor: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewSponsors.SelectedRows.Count > 0)
            {
                try
                {
                    int sponsorId = Convert.ToInt32(dataGridViewSponsors.SelectedRows[0].Cells["SponsorId"].Value);
                    Sponsor sponsor = new Sponsor
                    {
                        SponsorId = sponsorId,
                        SponsorName = txtSponsorName.Text.Trim(),
                        Contact = txtContact.Text.Trim()
                    };

                    if (sponsorBL.UpdateSponsor(sponsor))
                    {
                        MessageBox.Show("Sponsor updated successfully!");
                        LoadSponsors();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update sponsor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating sponsor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a sponsor to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSponsors.SelectedRows.Count > 0)
            {
                try
                {
                    int sponsorId = Convert.ToInt32(dataGridViewSponsors.SelectedRows[0].Cells["SponsorId"].Value);
                    if (sponsorBL.DeleteSponsor(sponsorId))
                    {
                        MessageBox.Show("Sponsor deleted successfully!");
                        LoadSponsors();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete sponsor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting sponsor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a sponsor to delete.");
            }
        }

        private void dataGridViewSponsors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Sponsor selectedSponsor = (Sponsor)dataGridViewSponsors.Rows[e.RowIndex].DataBoundItem;
                txtSponsorName.Text = selectedSponsor.SponsorName;
                txtContact.Text = selectedSponsor.Contact;
            }
        }

        private void ClearFields()
        {
            txtSponsorName.Text = "";
            txtContact.Text = "";
        }
    }
}
