namespace ITECManagementSystem
{
    partial class memberAndRoleManagement
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
            comboBox2 = new ComboBox();
            label3 = new Label();
            button3 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "2021", "2022", "2023", "2024", "2025" });
            comboBox2.Location = new Point(59, 229);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(59, 190);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 25;
            label3.Text = "Role";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(241, 258);
            button3.Name = "button3";
            button3.Size = new Size(146, 54);
            button3.TabIndex = 24;
            button3.Text = "Delete Member";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(59, 260);
            button1.Name = "button1";
            button1.Size = new Size(142, 54);
            button1.TabIndex = 23;
            button1.Text = "ADD member";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 330);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(666, 213);
            dataGridView1.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2021", "2022", "2023", "2024", "2025" });
            comboBox1.Location = new Point(59, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(59, 114);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 19;
            label2.Text = "Committe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(59, -28);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 18;
            label1.Text = "Member Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(59, 36);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 27;
            label4.Text = "Member Name";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(413, 258);
            button2.Name = "button2";
            button2.Size = new Size(146, 54);
            button2.TabIndex = 28;
            button2.Text = "Edit Member";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // memberAndRoleManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 448);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "memberAndRoleManagement";
            Text = "memberAndRoleManagement";
            Load += memberAndRoleManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox2;
        private Label label3;
        private Button button3;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button button2;
    }
}