using System;
using System.Drawing;
using System.Windows.Forms;
using ITECManagementSystem.BL;
using ITECManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITECManagementSystem
{
    public partial class SignUp : Form
    {
        LookupBL lookupBL = new LookupBL();
        private readonly UserBL userBL = new UserBL();

        public SignUp()
        {
            InitializeComponent();
            this.Resize += new EventHandler(SignUp_Resize);
            populateRoles();
        }

        private void SignUp_Resize(object sender, EventArgs e)
        {
            CenterLabel();
        }

        private void CenterLabel()
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }
            string enteredRole = comboBox1.Text;
            int roleId = -1;
            roleId = userBL.GetOrCreateRoleId(enteredRole);
            if (roleId == -1)
            {
                MessageBox.Show("Invalid role selected.");
                return;
            }
            if (enteredRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                string adminCode = txtAdminCode.Text.Trim(); 
                if (adminCode != "YOUR_SECRET_ADMIN_CODE") 
                {
                    MessageBox.Show("Invalid admin code. Admin sign-up is not allowed without the correct code.");
                    return;
                }
            }
            User newUser = new User
            {
                Username = txtUsername.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PasswordHash = txtPassword.Text.Trim(), 
                RoleId = roleId
            };

            try
            {
                bool success = userBL.RegisterUser(newUser);
                if (success)
                {
                    MessageBox.Show("User registered successfully!");
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 65, 105, 225);
        }
        private void populateRoles()
        {
            var roles = lookupBL.GetLookupValues("UserRoles");
            comboBox1.DataSource = new BindingSource(roles, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }
    }
}
