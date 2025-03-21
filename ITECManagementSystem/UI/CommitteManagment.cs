using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem
{
    public partial class CommitteManagment : Form
    {
        CommitteeBL committeeBL = new CommitteeBL();
        private void CommitteManagment_Load(object sender, EventArgs e)
        {
            dgvCommittees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public CommitteManagment()
        {
            InitializeComponent();
            LoadCommittees();
            LoadItechEditions();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int itecId = Convert.ToInt32(cmbItechEdition.SelectedValue);
                Committee committee = new Committee(0, itecId, txtCommitteeName.Text);
                committeeBL.AddCommittee(committee);
                MessageBox.Show("Committee added successfully.");
                LoadCommittees();
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
                int selectedCommitteeId = GetSelectedCommitteeId();
                if (selectedCommitteeId == -1)
                    return;

                int itecId = Convert.ToInt32(cmbItechEdition.SelectedValue);
                Committee committee = new Committee(selectedCommitteeId, itecId, txtCommitteeName.Text);
                committeeBL.UpdateCommittee(committee);
                MessageBox.Show("Committee updated successfully.");
                LoadCommittees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating committee: " + ex.Message);
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                int selectedCommitteeId = GetSelectedCommitteeId();
                if (selectedCommitteeId == -1)
                    return;

                committeeBL.DeleteCommittee(selectedCommitteeId);
                MessageBox.Show("Committee deleted successfully.");
                LoadCommittees();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting committee: " + ex.Message);
            }
        }
        private void LoadCommittees()
        {
            try
            {
                List<Committee> committees = committeeBL.GetCommittees();
                dgvCommittees.DataSource = committees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading committees: " + ex.Message);
            }
        }
        private void LoadItechEditions()
        {
            try
            {
                List<ItechEdition> editions = committeeBL.GetItechEditions();
                cmbItechEdition.DataSource = editions;
                cmbItechEdition.DisplayMember = "Year";
                cmbItechEdition.ValueMember = "ItecId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading ITEC editions: " + ex.Message);
            }
        }
        private int GetSelectedCommitteeId()
        {
            if (dgvCommittees.SelectedRows.Count > 0)
            {
                return ((Committee)dgvCommittees.SelectedRows[0].DataBoundItem).committee_id;
            }
            else
            {
                MessageBox.Show("Please select a committee first.");
                return -1;
            }
        }

        private void dgvCommittees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCommittees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void cmbItechEdition_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dgvCommittees_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
