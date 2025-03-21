namespace ITECManagementSystem
{
    partial class CommitteManagment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommitteManagment));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dgvCommittees = new DataGridView();
            cmbItechEdition = new ComboBox();
            txtCommitteeName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCommittees).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(31, 140);
            button3.Name = "button3";
            button3.Size = new Size(144, 32);
            button3.TabIndex = 15;
            button3.Text = "Delete Committe";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(31, 92);
            button2.Name = "button2";
            button2.Size = new Size(144, 32);
            button2.TabIndex = 14;
            button2.Text = "Edit Commitee";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(31, 39);
            button1.Name = "button1";
            button1.Size = new Size(144, 32);
            button1.TabIndex = 13;
            button1.Text = "ADD Committe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvCommittees
            // 
            dgvCommittees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCommittees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommittees.Location = new Point(0, 299);
            dgvCommittees.Name = "dgvCommittees";
            dgvCommittees.Size = new Size(635, 79);
            dgvCommittees.TabIndex = 12;
            dgvCommittees.CellContentClick += dgvCommittees_CellContentClick_1;
            // 
            // cmbItechEdition
            // 
            cmbItechEdition.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbItechEdition.FormattingEnabled = true;
            cmbItechEdition.Items.AddRange(new object[] { "2021", "2022", "2023", "2024", "2025" });
            cmbItechEdition.Location = new Point(237, 134);
            cmbItechEdition.Name = "cmbItechEdition";
            cmbItechEdition.Size = new Size(123, 23);
            cmbItechEdition.TabIndex = 11;
            // 
            // txtCommitteeName
            // 
            txtCommitteeName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCommitteeName.Location = new Point(235, 60);
            txtCommitteeName.Name = "txtCommitteeName";
            txtCommitteeName.Size = new Size(125, 23);
            txtCommitteeName.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(237, 100);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 9;
            label2.Text = "ITECH EDITION";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(235, 25);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 8;
            label1.Text = "Committe Name";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(395, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 198);
            panel1.TabIndex = 16;
            // 
            // CommitteManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(634, 376);
            Controls.Add(panel1);
            Controls.Add(dgvCommittees);
            Controls.Add(cmbItechEdition);
            Controls.Add(txtCommitteeName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CommitteManagment";
            Text = "CommitteManagment";
            Load += CommitteManagment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommittees).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dgvCommittees;
        private ComboBox cmbItechEdition;
        private TextBox txtCommitteeName;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}