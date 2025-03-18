using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITECManagementSystem
{
    public partial class CommitteManagment : Form
    {
        string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";

        public CommitteManagment()
        {
            InitializeComponent();
            LoadCommittees();
            LoadItechEditions();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    int itec_id = Convert.ToInt32(cmbItechEdition.SelectedValue); 

                    string query = "INSERT INTO committees (itec_id, committee_name) VALUES (@itec_id, @committee_name)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@itec_id", itec_id);
                        cmd.Parameters.AddWithValue("@committee_name", txtCommitteeName.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Committee added successfully.");
                    LoadCommittees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int selectedCommitteeId = GetSelectedCommitteeId();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "UPDATE committees SET itec_id = @itec_id, committee_name = @committee_name WHERE committee_id = @committee_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@itec_id", cmbItechEdition.SelectedValue);
                    cmd.Parameters.AddWithValue("@committee_name", txtCommitteeName.Text);
                    cmd.Parameters.AddWithValue("@committee_id", selectedCommitteeId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Committee updated successfully.");
                    LoadCommittees();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error updating committee: " + ex.Message);
                }
            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int selectedCommitteeId = GetSelectedCommitteeId();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM committees WHERE committee_id = @committee_id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@committee_id", selectedCommitteeId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Committee deleted successfully.");
                    LoadCommittees();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error deleting committee: " + ex.Message);
                }
            }


        }

        private void dgvCommittees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCommittees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void LoadCommittees()
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM committees";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCommittees.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading committees: " + ex.Message);
                }
            }
        }
        private int GetSelectedCommitteeId()
        {
            if (dgvCommittees.SelectedRows.Count > 0)
            {
                int selectedCommitteeId = Convert.ToInt32(dgvCommittees.SelectedRows[0].Cells["committee_id"].Value);
                return selectedCommitteeId;
            }
            else
            {
                MessageBox.Show("Please select a committee first.");
                return -1;
            }
        }

        private void CommitteManagment_Load(object sender, EventArgs e)
        {

        }

        private void cmbItechEdition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadItechEditions()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT itec_id, year FROM itec_editions";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbItechEdition.DataSource = dt;
                        cmbItechEdition.DisplayMember = "year"; 
                        cmbItechEdition.ValueMember = "itec_id"; 
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading ITEC editions: " + ex.Message);
                }
            }
        }

    }
}
