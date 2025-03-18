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
    public partial class UserFeeTracking : Form
    {
        string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";
        public UserFeeTracking()
        {
            InitializeComponent();
        }
        private void UserFeeTracking_Load(object sender, EventArgs e)
        {
            LoadFeeStatus();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadFeeStatus()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
        SELECT ep.registration_id, e.event_name, ep.fee_amount, 
               CASE WHEN ep.payment_status_id = 1 THEN 'Pending' ELSE 'Paid' END AS payment_status
        FROM event_participant ep
        JOIN itec_events e ON ep.event_id = e.event_id
        WHERE ep.participant_id = @participant_id"; 

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@participant_id", Login.SessionData.CurrentParticipantID);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

    }
}
