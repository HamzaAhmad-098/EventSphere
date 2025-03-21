using ITECManagementSystem.UI;

namespace ITECManagementSystem
{
    public partial class Form1 : Form
    {
        string text = "Welcome to ITEC  Management System!";
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditionManagment eventsForm = new EditionManagment(); // Create subform instance
            eventsForm.Show(); // Open the subform


        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (index < text.Length)
            {
                label1.Text += text[index++];
            }
            else
            {
                timer1.Stop();
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 10; // Adjust for spacing from the top
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void BtnEventManagement_Click(object sender, EventArgs e)
        {
            EventManagement eventManagement = new EventManagement();    
            eventManagement.Show();
        }

        private void BtnParticipantRegistrationFeeTracking_Click(object sender, EventArgs e)
        {
            Registration registeration_FeeTracking = new Registration();
            registeration_FeeTracking.Show();
        }

        private void BtnCommitteeRoleManagement_Click(object sender, EventArgs e)
        {
            CommitteManagment committeManagement = new CommitteManagment();
            committeManagement.Show();
        }

        private void BtnFinancialManagementSponsorshipTracking_Click(object sender, EventArgs e)
        {
            FinancialManagement financialManagement = new FinancialManagement();
            financialManagement.Show();
        }

        private void BtnVenueAllocationConflictResolution_Click(object sender, EventArgs e)
        {
            VenuAllocation venuAllocation = new VenuAllocation();
            venuAllocation.Show();
        }

        private void BtnEventResultsManagement_Click(object sender, EventArgs e)
        {
            ResultManagement resultManagement = new ResultManagement();
            resultManagement.Show();
        }

        private void BtnAutomatedReportGeneration_Click(object sender, EventArgs e)
        {
            ReportGeneration reportGeneration = new ReportGeneration();
            reportGeneration.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            memberAndRoleManagement roleManagement = new memberAndRoleManagement();
            roleManagement.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FeeTrackingAdmin feeTracking = new FeeTrackingAdmin();
            feeTracking.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddVenu venu = new AddVenu();
            venu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DutyManagement dutyManagement = new DutyManagement();   
            dutyManagement.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SponsorManagement sponsor = new SponsorManagement();
            sponsor.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VendorManagement vendorManagement = new VendorManagement(); 
            vendorManagement.Show();
        }
    }
}
