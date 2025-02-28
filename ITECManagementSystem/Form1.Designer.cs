namespace ITECManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            BtnItecEditionManagement = new Button();
            BtnEventManagement = new Button();
            BtnDutyAssignmentTracking = new Button();
            BtnParticipantRegistrationFeeTracking = new Button();
            BtnCommitteeRoleManagement = new Button();
            BtnAutomatedReportGeneration = new Button();
            BtnEventResultsManagement = new Button();
            BtnVenueAllocationConflictResolution = new Button();
            BtnFinancialManagementSponsorshipTracking = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Azure;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(140, 116);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(0, 46);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // BtnItecEditionManagement
            // 
            BtnItecEditionManagement.Font = new Font("Segoe UI", 10F);
            BtnItecEditionManagement.Location = new Point(20, 24);
            BtnItecEditionManagement.Name = "BtnItecEditionManagement";
            BtnItecEditionManagement.Size = new Size(211, 27);
            BtnItecEditionManagement.TabIndex = 1;
            BtnItecEditionManagement.Text = " ITEC Editions Management ";
            BtnItecEditionManagement.UseVisualStyleBackColor = true;
            BtnItecEditionManagement.Click += button1_Click;
            // 
            // BtnEventManagement
            // 
            BtnEventManagement.Font = new Font("Segoe UI", 10F);
            BtnEventManagement.Location = new Point(20, 57);
            BtnEventManagement.Name = "BtnEventManagement";
            BtnEventManagement.Size = new Size(199, 30);
            BtnEventManagement.TabIndex = 2;
            BtnEventManagement.Text = "Event Management";
            BtnEventManagement.UseVisualStyleBackColor = true;
            BtnEventManagement.Click += BtnEventManagement_Click;
            // 
            // BtnDutyAssignmentTracking
            // 
            BtnDutyAssignmentTracking.Font = new Font("Segoe UI", 10F);
            BtnDutyAssignmentTracking.Location = new Point(20, 167);
            BtnDutyAssignmentTracking.Name = "BtnDutyAssignmentTracking";
            BtnDutyAssignmentTracking.Size = new Size(277, 32);
            BtnDutyAssignmentTracking.TabIndex = 3;
            BtnDutyAssignmentTracking.Text = "Duty Assignment & Tracking ";
            BtnDutyAssignmentTracking.UseVisualStyleBackColor = true;
            BtnDutyAssignmentTracking.Click += button3_Click;
            // 
            // BtnParticipantRegistrationFeeTracking
            // 
            BtnParticipantRegistrationFeeTracking.Font = new Font("Segoe UI", 10F);
            BtnParticipantRegistrationFeeTracking.Location = new Point(20, 93);
            BtnParticipantRegistrationFeeTracking.Name = "BtnParticipantRegistrationFeeTracking";
            BtnParticipantRegistrationFeeTracking.Size = new Size(268, 27);
            BtnParticipantRegistrationFeeTracking.TabIndex = 4;
            BtnParticipantRegistrationFeeTracking.Text = "Participant Registration & Fee Tracking";
            BtnParticipantRegistrationFeeTracking.UseVisualStyleBackColor = true;
            BtnParticipantRegistrationFeeTracking.Click += BtnParticipantRegistrationFeeTracking_Click;
            // 
            // BtnCommitteeRoleManagement
            // 
            BtnCommitteeRoleManagement.Font = new Font("Segoe UI", 10F);
            BtnCommitteeRoleManagement.Location = new Point(20, 126);
            BtnCommitteeRoleManagement.Name = "BtnCommitteeRoleManagement";
            BtnCommitteeRoleManagement.Size = new Size(277, 35);
            BtnCommitteeRoleManagement.TabIndex = 5;
            BtnCommitteeRoleManagement.Text = "Committee & Role Management";
            BtnCommitteeRoleManagement.UseVisualStyleBackColor = true;
            BtnCommitteeRoleManagement.Click += BtnCommitteeRoleManagement_Click;
            // 
            // BtnAutomatedReportGeneration
            // 
            BtnAutomatedReportGeneration.Font = new Font("Segoe UI", 10F);
            BtnAutomatedReportGeneration.Location = new Point(20, 319);
            BtnAutomatedReportGeneration.Name = "BtnAutomatedReportGeneration";
            BtnAutomatedReportGeneration.Size = new Size(277, 32);
            BtnAutomatedReportGeneration.TabIndex = 6;
            BtnAutomatedReportGeneration.Text = "Automated Report Generation ";
            BtnAutomatedReportGeneration.UseVisualStyleBackColor = true;
            BtnAutomatedReportGeneration.Click += BtnAutomatedReportGeneration_Click;
            // 
            // BtnEventResultsManagement
            // 
            BtnEventResultsManagement.Font = new Font("Segoe UI", 10F);
            BtnEventResultsManagement.Location = new Point(20, 281);
            BtnEventResultsManagement.Name = "BtnEventResultsManagement";
            BtnEventResultsManagement.Size = new Size(277, 32);
            BtnEventResultsManagement.TabIndex = 7;
            BtnEventResultsManagement.Text = "Event Results Management ";
            BtnEventResultsManagement.UseVisualStyleBackColor = true;
            BtnEventResultsManagement.Click += BtnEventResultsManagement_Click;
            // 
            // BtnVenueAllocationConflictResolution
            // 
            BtnVenueAllocationConflictResolution.Font = new Font("Segoe UI", 10F);
            BtnVenueAllocationConflictResolution.Location = new Point(20, 243);
            BtnVenueAllocationConflictResolution.Name = "BtnVenueAllocationConflictResolution";
            BtnVenueAllocationConflictResolution.Size = new Size(277, 32);
            BtnVenueAllocationConflictResolution.TabIndex = 8;
            BtnVenueAllocationConflictResolution.Text = "Venue Allocation & Conflict Resolution ";
            BtnVenueAllocationConflictResolution.UseVisualStyleBackColor = true;
            BtnVenueAllocationConflictResolution.Click += BtnVenueAllocationConflictResolution_Click;
            // 
            // BtnFinancialManagementSponsorshipTracking
            // 
            BtnFinancialManagementSponsorshipTracking.Font = new Font("Segoe UI", 10F);
            BtnFinancialManagementSponsorshipTracking.Location = new Point(20, 205);
            BtnFinancialManagementSponsorshipTracking.Name = "BtnFinancialManagementSponsorshipTracking";
            BtnFinancialManagementSponsorshipTracking.Size = new Size(286, 32);
            BtnFinancialManagementSponsorshipTracking.TabIndex = 9;
            BtnFinancialManagementSponsorshipTracking.Text = "Financial Management & Sponsorship Tracking";
            BtnFinancialManagementSponsorshipTracking.UseVisualStyleBackColor = true;
            BtnFinancialManagementSponsorshipTracking.Click += BtnFinancialManagementSponsorshipTracking_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(BtnItecEditionManagement);
            panel1.Controls.Add(BtnAutomatedReportGeneration);
            panel1.Controls.Add(BtnEventResultsManagement);
            panel1.Controls.Add(BtnVenueAllocationConflictResolution);
            panel1.Controls.Add(BtnFinancialManagementSponsorshipTracking);
            panel1.Controls.Add(BtnEventManagement);
            panel1.Controls.Add(BtnParticipantRegistrationFeeTracking);
            panel1.Controls.Add(BtnCommitteeRoleManagement);
            panel1.Controls.Add(BtnDutyAssignmentTracking);
            panel1.Location = new Point(30, 227);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 358);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(629, 664);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 25F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(8, 9, 8, 9);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnItecEditionManagement;
        private Button BtnEventManagement;
        private Button BtnDutyAssignmentTracking;
        private Button BtnParticipantRegistrationFeeTracking;
        private Button BtnCommitteeRoleManagement;
        private Button BtnAutomatedReportGeneration;
        private Button BtnEventResultsManagement;
        private Button BtnVenueAllocationConflictResolution;
        private Button BtnFinancialManagementSponsorshipTracking;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Panel panel1;
    }
}
