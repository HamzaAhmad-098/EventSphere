using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class EditionManagment : Form
    {
        public string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";


        public EditionManagment()
        {
            InitializeComponent();
        }

        private void EditionManagment_Load(object sender, EventArgs e)
        {
            LoadEditions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string year = cmbItechEdition.Text;
            string theme = txtCommitteeName.Text;
            string description = textBox2.Text;

            string query = "INSERT INTO ITEC_Editions (year, theme, description) VALUES (@year, @theme, @description)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@theme", theme);
                cmd.Parameters.AddWithValue("@description", description);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Edition Added Successfully!");
                LoadEditions();
            }
        }
        private void LoadEditions()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            string query = "SELECT* FROM ITEC_Editions";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvEditions.DataSource = dt;
            dgvEditions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            int itec_id = int.Parse(dgvEditions.SelectedRows[0].Cells[0].Value.ToString());
            string query = "DELETE FROM itec_editions WHERE itec_id = @itec_id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@itec_id", itec_id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Edition deleted Successfully!");
                LoadEditions();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            int itec_id = int.Parse(dgvEditions.SelectedRows[0].Cells[0].Value.ToString());
            string year = cmbItechEdition.Text;
            string theme = txtCommitteeName.Text;
            string description = textBox2.Text;

            string query = "UPDATE ITEC_Editions SET year = @year, theme = @theme, description = @description WHERE itec_id = @itec_id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@itec_id", itec_id);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@theme", theme);
                cmd.Parameters.AddWithValue("@description", description);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Edition Updated Successfully!");
                LoadEditions();
            }
        }
        private int GetSelectedEditionId()
        {
            if (dgvEditions.SelectedRows.Count > 0)
            {
                int selectedEditionId = Convert.ToInt32(dgvEditions.SelectedRows[0].Cells["year"].Value);
                return selectedEditionId;
            }
            else
            {
                MessageBox.Show("Please select a committee first.");
                return -1;
            }
        }

        private void dgvEditions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEditions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
