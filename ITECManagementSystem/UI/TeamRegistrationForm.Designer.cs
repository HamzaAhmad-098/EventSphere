namespace ITECManagementSystem.UI
{
    partial class TeamRegistrationForm
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
            comboBoxEvent = new ComboBox();
            comboBoxParticipants = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtTeamName = new TextBox();
            label3 = new Label();
            listBoxParticipants = new ListBox();
            btnAddParticipant = new Button();
            btnSaveTeam = new Button();
            SuspendLayout();
            // 
            // comboBoxEvent
            // 
            comboBoxEvent.FormattingEnabled = true;
            comboBoxEvent.Location = new Point(36, 68);
            comboBoxEvent.Name = "comboBoxEvent";
            comboBoxEvent.Size = new Size(121, 23);
            comboBoxEvent.TabIndex = 0;
            // 
            // comboBoxParticipants
            // 
            comboBoxParticipants.FormattingEnabled = true;
            comboBoxParticipants.Location = new Point(36, 134);
            comboBoxParticipants.Name = "comboBoxParticipants";
            comboBoxParticipants.Size = new Size(121, 23);
            comboBoxParticipants.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 2;
            label1.Text = "Event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(36, 98);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 3;
            label2.Text = "Participants";
            // 
            // txtTeamName
            // 
            txtTeamName.Location = new Point(36, 212);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.Size = new Size(121, 23);
            txtTeamName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(36, 176);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 5;
            label3.Text = "Team Name";
            // 
            // listBoxParticipants
            // 
            listBoxParticipants.FormattingEnabled = true;
            listBoxParticipants.ItemHeight = 15;
            listBoxParticipants.Location = new Point(37, 251);
            listBoxParticipants.Name = "listBoxParticipants";
            listBoxParticipants.Size = new Size(120, 94);
            listBoxParticipants.TabIndex = 6;
            // 
            // btnAddParticipant
            // 
            btnAddParticipant.Font = new Font("Segoe UI", 12F);
            btnAddParticipant.Location = new Point(36, 368);
            btnAddParticipant.Name = "btnAddParticipant";
            btnAddParticipant.Size = new Size(126, 35);
            btnAddParticipant.TabIndex = 7;
            btnAddParticipant.Text = "Add Participant";
            btnAddParticipant.UseVisualStyleBackColor = true;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
            // 
            // btnSaveTeam
            // 
            btnSaveTeam.Font = new Font("Segoe UI", 12F);
            btnSaveTeam.Location = new Point(215, 368);
            btnSaveTeam.Name = "btnSaveTeam";
            btnSaveTeam.Size = new Size(126, 35);
            btnSaveTeam.TabIndex = 8;
            btnSaveTeam.Text = "Save team";
            btnSaveTeam.UseVisualStyleBackColor = true;
            this.btnSaveTeam.Click += new System.EventHandler(this.btnSaveTeam_Click);
            // 
            // TeamRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(btnSaveTeam);
            Controls.Add(btnAddParticipant);
            Controls.Add(listBoxParticipants);
            Controls.Add(label3);
            Controls.Add(txtTeamName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxParticipants);
            Controls.Add(comboBoxEvent);
            Name = "TeamRegistrationForm";
            Text = "TeamRegistrationForm";
            Load += TeamRegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxEvent;
        private ComboBox comboBoxParticipants;
        private Label label1;
        private Label label2;
        private TextBox txtTeamName;
        private Label label3;
        private ListBox listBoxParticipants;
        private Button btnAddParticipant;
        private Button btnSaveTeam;
    }
}