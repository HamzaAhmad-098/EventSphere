namespace ITECManagementSystem
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            panel1 = new Panel();
            label7 = new Label();
            txtInvitationCode = new TextBox();
            label6 = new Label();
            txtRolename = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            button2 = new Button();
            label4 = new Label();
            button1 = new Button();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtInvitationCode);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtRolename);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(194, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 386);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(55, 279);
            label7.Name = "label7";
            label7.Size = new Size(169, 21);
            label7.TabIndex = 12;
            label7.Text = "code (For admins only)";
            // 
            // txtInvitationCode
            // 
            txtInvitationCode.Location = new Point(54, 301);
            txtInvitationCode.Name = "txtInvitationCode";
            txtInvitationCode.PasswordChar = '*';
            txtInvitationCode.Size = new Size(190, 23);
            txtInvitationCode.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(54, 223);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 10;
            label6.Text = "Role Name";
            // 
            // txtRolename
            // 
            txtRolename.Location = new Point(54, 253);
            txtRolename.Name = "txtRolename";
            txtRolename.PasswordChar = '*';
            txtRolename.Size = new Size(190, 23);
            txtRolename.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(54, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(190, 23);
            txtPassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(54, 167);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 7;
            label5.Text = "Password";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(237, 354);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Login In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(76, 356);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 6;
            label4.Text = "Have an Account ?";
            // 
            // button1
            // 
            button1.Location = new Point(201, 330);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(54, 132);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '*';
            txtEmail.Size = new Size(190, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(54, 73);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(190, 23);
            txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(54, 108);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 2;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(54, 49);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Wide Latin", 15.75F);
            label1.Location = new Point(109, 13);
            label1.Name = "label1";
            label1.Size = new Size(150, 26);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            label1.Click += label1_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(701, 459);
            Controls.Add(panel1);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Button button2;
        private Label label4;
        private TextBox txtPassword;
        private Label label5;
        private Label label6;
        private TextBox txtRolename;
        private Label label7;
        private TextBox txtInvitationCode;
    }
}