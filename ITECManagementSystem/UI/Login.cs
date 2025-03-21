using System;
using System.Drawing;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;

namespace ITECManagementSystem
{
    public partial class Login : Form
    {
        private readonly LoginBL loginBL = new LoginBL();

        public Login()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Login_Resize);
            CenterLabel();
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Optionally, additional initialization
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            CenterLabel();
        }

        private void CenterLabel()
        {
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            label2.Top = 10;
            CenterPanel();
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 65, 105, 225);
            button1.BackColor = Color.Transparent;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                User user = loginBL.AuthenticateUser(txtUsername.Text, txtPassword.Text);
                string roleName = user.RoleName;
                SessionData.CurrentParticipantID = GetParticipantIdByEmail(user.Email);

                MessageBox.Show("Login Successful!");
                RedirectBasedOnRole(roleName);

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void RedirectBasedOnRole(string roleName)
        {
            switch (roleName)
            {
                case "Admin":
                    Form1 adminForm = new Form1();
                    adminForm.Show();
                    break;
                case "Student":
                    userDashboard studentForm = new userDashboard();
                    studentForm.Show();
                    break;
                /*case "faculty":
                    FacultyForm facultyForm = new FacultyForm();
                    facultyForm.Show();
                    break;
                case "sponsor":
                    SponsorForm sponsorForm = new SponsorForm();
                    sponsorForm.Show();
                    break;*/
                default:
                    MessageBox.Show("Unrecognized role.");
                    break;
            }
        }
        private int GetParticipantIdByEmail(string email)
        {
            return 0;
        }

        public static class SessionData
        {
            public static int CurrentParticipantID { get; set; }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
