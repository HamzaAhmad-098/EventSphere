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
    public partial class Registeration_feeTracking : Form
    {
        string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";

        public Registeration_feeTracking()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string insertParticipant = @"INSERT INTO participants (itec_id, name, email, contact,institute , role_id)
                                     VALUES (@itec_id, @name, @email, @contact, @institute , @role_id);
                                     SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(insertParticipant, conn);
                    cmd.Parameters.AddWithValue("@itec_id", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@contact", textBox5.Text);
                    cmd.Parameters.AddWithValue("@institute", textBox3.Text);
                    cmd.Parameters.AddWithValue("@role_id", comboBox1.SelectedValue);

                    int participantID = Convert.ToInt32(cmd.ExecuteScalar());
                    string insertRegistration = @"INSERT INTO event_participants (event_id, participant_id, payment_status_id, fee_amount)
                                      VALUES (@event_id, @participant_id, @payment_status_id, @fee_amount)";

                    MySqlCommand cmd2 = new MySqlCommand(insertRegistration, conn);
                    cmd2.Parameters.AddWithValue("@event_id", comboBox3.SelectedValue);
                    cmd2.Parameters.AddWithValue("@participant_id", participantID);
                    cmd2.Parameters.AddWithValue("@payment_status_id", 1); 
                    cmd2.Parameters.AddWithValue("@fee_amount", Convert.ToDecimal(textBox4.Text));
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Registration successful! Please proceed with fee payment.");
                }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Registeration_feeTracking_Load(object sender, EventArgs e)
        {
            LoadEditions();
            LoadEvents();
            LoadRoles();
        }
        private void LoadRoles()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT role_id, role_name FROM roles";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "role_name";
                comboBox1.ValueMember = "role_id";
            }
        }
        private void LoadEvents()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT event_id, event_name FROM itec_events";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "event_name";
                comboBox3.ValueMember = "event_id";
            }
        }
        private void LoadEditions()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT  itec_id , year FROM itec_editions";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "year";
                comboBox2.ValueMember = "itec_id";
            }
        }
    }
}
