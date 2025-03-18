using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITECManagementSystem
{
    public partial class SignUp : Form
    {
        string connectionString = "server=localhost;port=3306;database=dbmid;user=root;password=Vat02842@Vat02842@;";

        public SignUp()
        {
            InitializeComponent();
            this.Resize += new EventHandler(SignUp_Resize);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 65, 105, 225);
        }
        private void SignUp_Resize(object sender, EventArgs e)
        {
            CenterLabel();
        }

        private void CenterLabel()
        {
            //label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            //label2.Top = 10;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredRole = txtRolename.Text.Trim().ToLower();
            int roleId = -1;

            if (enteredRole == "admin")
            {
                string secretCode = "AdminCode"; 
                if (txtInvitationCode.Text.Trim() == secretCode)
                {
                    roleId = GetOrCreateRoleId("admin");
                }
                else
                {
                    MessageBox.Show("Invalid invitation code for admin registration.");
                    return;
                }
            }
            else
            {
                roleId = GetOrCreateRoleId("user");
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = @"
                            INSERT INTO users (username, email, password_hash, role_id) 
                            VALUES (@uname, @mail, @pass, @role)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@uname", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@mail", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@role", roleId);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("User registered successfully!");
                            this.Close(); // close sign-up form
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }



        }
        private int GetOrCreateRoleId(string roleName)
        {
            int roleId = -1;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // 1) Check if the role exists
                string selectQuery = "SELECT role_id FROM roles WHERE role_name = @roleName";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@roleName", roleName);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        // Role found
                        roleId = Convert.ToInt32(result);
                    }
                    else
                    {
                        // 2) Insert new role
                        string insertRole = "INSERT INTO roles (role_name) VALUES (@roleName)";
                        using (MySqlCommand cmdInsert = new MySqlCommand(insertRole, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@roleName", roleName);
                            cmdInsert.ExecuteNonQuery();
                            roleId = (int)cmdInsert.LastInsertedId;
                        }
                    }
                }
            }
            return roleId;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
