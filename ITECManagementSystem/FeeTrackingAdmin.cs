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
    public partial class FeeTrackingAdmin : Form
    {
        string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
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
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT ep.registration_id, p.name AS participant_name, e.event_name, 
                           ep.fee_amount, 
                           CASE WHEN ep.payment_status_id = 1 THEN 'Pending' ELSE 'Paid' END AS payment_status
                    FROM event_participants ep
                    JOIN participants p ON ep.participant_id = p.participant_id
                    JOIN itec_events e ON ep.event_id = e.event_id";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewPayments.DataSource = dt;
            }
        }

        private void SearchParticipant(string searchText)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT ep.registration_id, p.name AS participant_name, e.event_name, 
                           ep.fee_amount, 
                           CASE WHEN ep.payment_status_id = 1 THEN 'Pending' ELSE 'Paid' END AS payment_status
                    FROM event_participants ep
                    JOIN participants p ON ep.participant_id = p.participant_id
                    JOIN itec_events e ON ep.event_id = e.event_id
                    WHERE p.name LIKE @SearchText"; 

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%"); // Partial match search

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewPayments.DataSource = dt;
                }
            }
        }

        private void PopulatePaymentStatusDropdown()
        {
            comboBoxPaymentStatus.Items.Add("Pending");
            comboBoxPaymentStatus.Items.Add("Paid");
        }

        private void dataGridViewPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPayments.Rows[e.RowIndex];
                selectedRegistrationID = Convert.ToInt32(row.Cells["registration_id"].Value);
                comboBoxPaymentStatus.SelectedItem = row.Cells["payment_status"].Value.ToString();
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

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string updateQuery = "UPDATE event_participants SET payment_status_id = @statusID WHERE registration_id = @registrationID";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@statusID", newStatusID);
                    cmd.Parameters.AddWithValue("@registrationID", selectedRegistrationID);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Payment status updated successfully!");
            LoadParticipantsPayment();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchParticipant(txtSearchParticipant.Text.Trim());
        }

        private void txtSearchParticipant_TextChanged(object sender, EventArgs e)
        {
            SearchParticipant(txtSearchParticipant.Text.Trim());
        }
    }
}

