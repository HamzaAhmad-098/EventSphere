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
    public partial class Login : Form
    {
        string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            panel1.BackColor = Color.FromArgb(150, 65, 105, 225);
            button1.BackColor = Color.Transparent;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string userQuery = @"
                SELECT u.email, u.password_hash, r.role_name 
                FROM users u 
                INNER JOIN roles r ON u.role_id = r.role_id
                WHERE u.username = @Username";

                    MySqlCommand userCmd = new MySqlCommand(userQuery, conn);
                    userCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());

                    using (MySqlDataReader reader = userCmd.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            string email = reader["email"].ToString();
                            string dbPassword = reader["password_hash"].ToString();
                            string dbRoleName = reader["role_name"].ToString();
                            if (dbPassword != txtPassword.Text)
                            {
                                MessageBox.Show("Incorrect password.");
                                return;
                            }
                            bool isAdmin = dbRoleName.Equals("admin", StringComparison.OrdinalIgnoreCase);

                            reader.Close(); 
                            string participantQuery = "SELECT participant_id FROM participants WHERE email = @Email";
                            MySqlCommand participantCmd = new MySqlCommand(participantQuery, conn);
                            participantCmd.Parameters.AddWithValue("@Email", email);

                            object participantResult = participantCmd.ExecuteScalar();
                            if (participantResult != null)
                            {
                                int participantID = Convert.ToInt32(participantResult);
                                SessionData.CurrentParticipantID = participantID;
                                MessageBox.Show("Login Successful! You are enrolled in an event.");
                            }
                            else
                            {
                                MessageBox.Show("Login Successful! But you are not participating in any event.");
                            }
                            if (isAdmin)
                            {
                                Form1 adminForm = new Form1();
                                adminForm.Show();
                            }
                            else
                            {
                                userDashboard userForm = new userDashboard();
                                userForm.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static class SessionData
        {
            public static int CurrentParticipantID { get; set; }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}