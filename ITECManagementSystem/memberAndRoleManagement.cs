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
    public partial class memberAndRoleManagement : Form
    {
        string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";

        public memberAndRoleManagement()
        {
            InitializeComponent();
        }

        private void memberAndRoleManagement_Load(object sender, EventArgs e)
        {
            LoadCommitteesAndRoles();
            LoadMembers();
        }
        private void LoadCommitteesAndRoles()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string committeeQuery = "SELECT committee_id, committee_name FROM committees;";
            MySqlDataAdapter committeeAdapter = new MySqlDataAdapter(committeeQuery, conn);
            DataTable committeeTable = new DataTable();
            committeeAdapter.Fill(committeeTable);
            comboBox1.DataSource = committeeTable;
            comboBox1.DisplayMember = "committee_name";
            comboBox1.ValueMember = "committee_id";
            string roleQuery = "SELECT role_id , role_name FROM Roles";
            MySqlDataAdapter roleAdapter = new MySqlDataAdapter(roleQuery, conn);
            DataTable roleTable = new DataTable();
            roleAdapter.Fill(roleTable);
            comboBox2.DataSource = roleTable;
            comboBox2.DisplayMember = "role_name";
            comboBox2.ValueMember = "role_id";
        }
        private void LoadMembers()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string query = "SELECT member_id, committee_id, name, role_id FROM Committee_Members";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string memberName = textBox1.Text;
            int committeeID = Convert.ToInt32(comboBox1.SelectedValue);
            int roleID = Convert.ToInt32(comboBox2.SelectedValue);

            string query = "INSERT INTO Committee_Members (committee_id, name, role_id) VALUES (@committeeID, @name, @roleID)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@committeeID", committeeID);
                cmd.Parameters.AddWithValue("@name", memberName);
                cmd.Parameters.AddWithValue("@roleID", roleID);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Committee Member Added Successfully!");
                LoadMembers();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int memberID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                string query = "DELETE FROM Committee_Members WHERE member_id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", memberID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Committee Member Deleted!");
                    LoadMembers();
                }
            }
            else
            {
                MessageBox.Show("Please select a member to delete.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int memberID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string memberName = textBox1.Text;
                int committeeID = Convert.ToInt32(comboBox1.SelectedValue);
                int roleID = Convert.ToInt32(comboBox2.SelectedValue);

                string query = "UPDATE Committee_Members SET committee_id=@committeeID, name=@name, role_id=@roleID WHERE member_id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@committeeID", committeeID);
                    cmd.Parameters.AddWithValue("@name", memberName);
                    cmd.Parameters.AddWithValue("@roleID", roleID);
                    cmd.Parameters.AddWithValue("@id", memberID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Committee Member Updated Successfully!");
                    LoadMembers();
                }
            }
            else
            {
                MessageBox.Show("Please select a member to update.");
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["name"].Value.ToString();
                comboBox1.SelectedValue = row.Cells["committee_id"].Value;
                comboBox2.SelectedValue = row.Cells["role_id"].Value;
            }
        }

    }
}
