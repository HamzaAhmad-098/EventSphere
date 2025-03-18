namespace ITECManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(160, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 304);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe Print", 9F);
            button3.ForeColor = Color.Gold;
            button3.Location = new Point(83, 171);
            button3.Name = "button3";
            button3.Size = new Size(120, 33);
            button3.TabIndex = 8;
            button3.Text = "forget password";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(141, 210);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Login ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(261, 251);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 6;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(22, 251);
            label5.Name = "label5";
            label5.Size = new Size(233, 28);
            label5.TabIndex = 5;
            label5.Text = "Do not have an account ?";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Wide Latin", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(121, 21);
            label4.Name = "label4";
            label4.Size = new Size(117, 26);
            label4.TabIndex = 4;
            label4.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(83, 118);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(83, 47);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 2;
            label1.Text = "User Name ";
            label1.Click += label1_Click_1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(83, 142);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(178, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += password_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(83, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.ShortcutsEnabled = false;
            txtUsername.Size = new Size(178, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += userName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Monotype Corsiva", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(73, 0);
            label2.Name = "label2";
            label2.Size = new Size(631, 79);
            label2.TabIndex = 1;
            label2.Text = "Itech Management System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(720, 441);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label1;
        private Label label4;
        private Button button1;
        private Label label5;
        private Button button2;
        private Button button3;
    }
}