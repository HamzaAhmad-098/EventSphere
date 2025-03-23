namespace ITECManagementSystem
{
    partial class EditionManagment
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dgvEditions = new DataGridView();
            cmbItechEdition = new ComboBox();
            txtCommitteeName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEditions).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(453, 252);
            button3.Name = "button3";
            button3.Size = new Size(153, 32);
            button3.TabIndex = 23;
            button3.Text = "Delete Edition";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(271, 252);
            button2.Name = "button2";
            button2.Size = new Size(132, 32);
            button2.TabIndex = 22;
            button2.Text = "Edit Edition";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(86, 252);
            button1.Name = "button1";
            button1.Size = new Size(135, 32);
            button1.TabIndex = 21;
            button1.Text = "ADD Edition";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvEditions
            // 
            dgvEditions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEditions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditions.GridColor = Color.AliceBlue;
            dgvEditions.Location = new Point(0, 308);
            dgvEditions.Name = "dgvEditions";
            dgvEditions.Size = new Size(683, 79);
            dgvEditions.TabIndex = 20;
            dgvEditions.CellContentClick += dgvEditions_CellContentClick;
            // 
            // cmbItechEdition
            // 
            cmbItechEdition.FormattingEnabled = true;
            cmbItechEdition.Items.AddRange(new object[] { "2021", "2022", "2023", "2024", "2025" });
            cmbItechEdition.Location = new Point(30, 56);
            cmbItechEdition.Name = "cmbItechEdition";
            cmbItechEdition.Size = new Size(144, 23);
            cmbItechEdition.TabIndex = 19;
            // 
            // txtCommitteeName
            // 
            txtCommitteeName.Location = new Point(30, 129);
            txtCommitteeName.Name = "txtCommitteeName";
            txtCommitteeName.Size = new Size(162, 23);
            txtCommitteeName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 20);
            label2.Name = "label2";
            label2.Size = new Size(40, 21);
            label2.TabIndex = 17;
            label2.Text = "Year";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 93);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 16;
            label1.Text = "Theme";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(30, 166);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 26;
            label3.Text = "Description";
            // 
            // EditionManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_1521811628991_7a3ea581f7d11;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(681, 388);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvEditions);
            Controls.Add(cmbItechEdition);
            Controls.Add(txtCommitteeName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditionManagment";
            Text = "EditionManagment";
            Load += EditionManagment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dgvEditions;
        private ComboBox cmbItechEdition;
        private TextBox txtCommitteeName;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label3;
    }
}