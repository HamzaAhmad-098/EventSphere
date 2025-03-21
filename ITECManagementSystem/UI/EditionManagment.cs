using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem
{
    public partial class EditionManagment : Form
    {
        private readonly EditionBL editionBL = new EditionBL();

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
            try
            {
                int year = int.Parse(cmbItechEdition.Text);
                string theme = txtCommitteeName.Text;
                string description = textBox2.Text;

                Edition edition = new Edition(0, year, theme, description);
                editionBL.AddEdition(edition);
                MessageBox.Show("Edition Added Successfully!");
                LoadEditions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedItecId = GetSelectedEditionId();
                if (selectedItecId <= 0)
                    return;

                int year = int.Parse(cmbItechEdition.Text);
                string theme = txtCommitteeName.Text;
                string description = textBox2.Text;

                Edition edition = new Edition(selectedItecId, year, theme, description);
                editionBL.UpdateEdition(edition);
                MessageBox.Show("Edition Updated Successfully!");
                LoadEditions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating edition: " + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedItecId = GetSelectedEditionId();
                if (selectedItecId <= 0)
                    return;

                editionBL.DeleteEdition(selectedItecId);
                MessageBox.Show("Edition deleted Successfully!");
                LoadEditions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting edition: " + ex.Message);
            }
        }
        private void LoadEditions()
        {
            try
            {
                List<Edition> editions = editionBL.GetEditions();
                dgvEditions.DataSource = editions;
                dgvEditions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvEditions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading editions: " + ex.Message);
            }
        }
        private int GetSelectedEditionId()
        {
            if (dgvEditions.SelectedRows.Count > 0)
            {
                Edition selectedEdition = (Edition)dgvEditions.SelectedRows[0].DataBoundItem;
                return selectedEdition.ItecId;
            }
            else
            {
                MessageBox.Show("Please select an edition first.");
                return -1;
            }
        }

        private void dgvEditions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEditions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
