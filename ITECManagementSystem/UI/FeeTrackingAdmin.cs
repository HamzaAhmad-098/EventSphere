using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem
{
    public partial class FeeTrackingAdmin : Form
    {
        PaymentTrackingBL trackingBL = new PaymentTrackingBL();
        private int selectedRegistrationID = -1;
        public FeeTrackingAdmin()
        {
            InitializeComponent();
        }
        private void FeeTrackingAdmin_Load(object sender, EventArgs e)
        {
            LoadParticipantsPayment();
            PopulatePaymentStatusDropdown();
        }
        private void LoadParticipantsPayment()
        {
            try
            {
                List<PaymentTracking> payments = trackingBL.GetPayments();
                dataGridViewPayments.DataSource = payments;
                dataGridViewPayments.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payments: " + ex.Message);
            }
        }

        LookupBL lookupBL = new LookupBL();

        private void PopulatePaymentStatusDropdown()
        {
            try
            {
                var statuses = lookupBL.GetLookupValues("PaymentStatus");
                comboBoxPaymentStatus.DataSource = new BindingSource(statuses, null);
                comboBoxPaymentStatus.DisplayMember = "Value";
                comboBoxPaymentStatus.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment statuses: " + ex.Message);
            }
        }
        private void dataGridViewPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPayments.Rows[e.RowIndex];
                selectedRegistrationID = Convert.ToInt32(row.Cells["RegistrationId"].Value);
                comboBoxPaymentStatus.SelectedItem = row.Cells["PaymentStatus"].Value.ToString();
            }
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            if (selectedRegistrationID == -1)
            {
                MessageBox.Show("Please select a participant to update.");
                return;
            }

            int newStatusID = comboBoxPaymentStatus.SelectedItem.ToString() == "Pending" ? 1 : 2;

            try
            {
                trackingBL.UpdatePaymentStatus(selectedRegistrationID, newStatusID);
                MessageBox.Show("Payment status updated successfully!");
                LoadParticipantsPayment();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payment: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchParticipant(txtSearchParticipant.Text.Trim());
        }

        private void txtSearchParticipant_TextChanged(object sender, EventArgs e)
        {
            SearchParticipant(txtSearchParticipant.Text.Trim());
        }

        private void SearchParticipant(string searchText)
        {
            try
            {
                List<PaymentTracking> payments = trackingBL.SearchPayments(searchText);
                dataGridViewPayments.DataSource = payments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching payments: " + ex.Message);
            }
        }
    }
}
