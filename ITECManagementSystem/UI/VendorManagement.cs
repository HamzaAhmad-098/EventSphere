using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem.UI
{
    public partial class VendorManagement : Form
    {
        VendorBL vendorBL = new VendorBL();

        public VendorManagement()
        {
            InitializeComponent();
        }

        private void VendorManagement_Load(object sender, EventArgs e)
        {
            LoadVendors();
        }

        private void LoadVendors()
        {
            try
            {
                List<Vendor> vendors = vendorBL.GetVendors();
                dataGridViewVendors.DataSource = vendors;
                dataGridViewVendors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vendors: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Vendor vendor = new Vendor
                {
                    VendorName = txtVendorName.Text.Trim(),
                    Contact = txtContact.Text.Trim(),
                    ServiceType = txtServiceType.Text.Trim()
                };

                if (vendorBL.AddVendor(vendor))
                {
                    MessageBox.Show("Vendor added successfully!");
                    LoadVendors();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to add vendor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding vendor: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewVendors.SelectedRows.Count > 0)
            {
                try
                {
                    int vendorId = Convert.ToInt32(dataGridViewVendors.SelectedRows[0].Cells["VendorId"].Value);
                    Vendor vendor = new Vendor
                    {
                        VendorId = vendorId,
                        VendorName = txtVendorName.Text.Trim(),
                        Contact = txtContact.Text.Trim(),
                        ServiceType = txtServiceType.Text.Trim()
                    };

                    if (vendorBL.UpdateVendor(vendor))
                    {
                        MessageBox.Show("Vendor updated successfully!");
                        LoadVendors();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update vendor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating vendor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a vendor to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewVendors.SelectedRows.Count > 0)
            {
                try
                {
                    int vendorId = Convert.ToInt32(dataGridViewVendors.SelectedRows[0].Cells["VendorId"].Value);
                    if (vendorBL.DeleteVendor(vendorId))
                    {
                        MessageBox.Show("Vendor deleted successfully!");
                        LoadVendors();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete vendor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting vendor: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a vendor to delete.");
            }
        }

        private void dataGridViewVendors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Vendor selectedVendor = (Vendor)dataGridViewVendors.Rows[e.RowIndex].DataBoundItem;
                txtVendorName.Text = selectedVendor.VendorName;
                txtContact.Text = selectedVendor.Contact;
                txtServiceType.Text = selectedVendor.ServiceType;
            }
        }

        private void ClearFields()
        {
            txtVendorName.Text = "";
            txtContact.Text = "";
            txtServiceType.Text = "";
        }
    }
}
