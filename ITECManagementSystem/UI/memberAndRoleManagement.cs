using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem
{
    public partial class memberAndRoleManagement : Form
    {
         MemberBL memberBL = new MemberBL();
        CommitteeBL committeeBL = new CommitteeBL();
        RoleBL roleBL = new RoleBL();

        public memberAndRoleManagement()
        {
            InitializeComponent();
        }

        private void memberAndRoleManagement_Load(object sender, EventArgs e)
        {
            LoadCommitteesAndRoles();
            LoadMembers();
        }

        private readonly LookupBL lookupBL = new LookupBL();

        private void LoadCommitteesAndRoles()
        {
            try
            {
                List<Committee> committees = committeeBL.GetCommittees();
                comboBox1.DataSource = committees;
                comboBox1.DisplayMember = "committee_name";
                comboBox1.ValueMember = "committee_id";
                var roles = lookupBL.GetLookupValues("ParticipantRoles");
                comboBox2.DataSource = new BindingSource(roles, null);
                comboBox2.DisplayMember = "Value";
                comboBox2.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading committees and roles: " + ex.Message);
            }
        }


        private void LoadMembers()
        {
            try
            {
                List<Member> members = memberBL.GetMembers();
                dataGridView1.DataSource = members;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string memberName = textBox1.Text;
                int committeeID = Convert.ToInt32(comboBox1.SelectedValue);
                int roleID = Convert.ToInt32(comboBox2.SelectedValue);

                Member member = new Member { MemberId = 0, CommitteeId = committeeID, Name = memberName, RoleId = roleID };
                memberBL.AddMember(member);
                MessageBox.Show("Committee Member Added Successfully!");
                LoadMembers();
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
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int memberID = ((Member)dataGridView1.SelectedRows[0].DataBoundItem).MemberId;
                    string memberName = textBox1.Text;
                    int committeeID = Convert.ToInt32(comboBox1.SelectedValue);
                    int roleID = Convert.ToInt32(comboBox2.SelectedValue);

                    Member member = new Member { MemberId = memberID, CommitteeId = committeeID, Name = memberName, RoleId = roleID };
                    memberBL.UpdateMember(member);
                    MessageBox.Show("Committee Member Updated Successfully!");
                    LoadMembers();
                }
                else
                {
                    MessageBox.Show("Please select a member to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating member: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int memberID = ((Member)dataGridView1.SelectedRows[0].DataBoundItem).MemberId;
                    memberBL.DeleteMember(memberID);
                    MessageBox.Show("Committee Member Deleted!");
                    LoadMembers();
                }
                else
                {
                    MessageBox.Show("Please select a member to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting member: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Member selectedMember = (Member)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                textBox1.Text = selectedMember.Name;
                comboBox1.SelectedValue = selectedMember.CommitteeId;
                comboBox2.SelectedValue = selectedMember.RoleId;
            }
        }
    }
}
