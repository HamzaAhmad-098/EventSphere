namespace ITECManagementSystem.UI
{
    partial class DutyManagement
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewDuties = new DataGridView();
            comboBoxCommittee = new ComboBox();
            comboBoxStatus = new ComboBox();
            txtTaskDescription = new TextBox();
            dateTimePickerDeadline = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblCommittee = new Label();
            lblAssignedTo = new Label();
            lblTaskDescription = new Label();
            lblDeadline = new Label();
            lblStatus = new Label();
            comboBoxAssignedTo = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDuties).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDuties
            // 
            dataGridViewDuties.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDuties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDuties.Location = new Point(1, 3);
            dataGridViewDuties.Name = "dataGridViewDuties";
            dataGridViewDuties.Size = new Size(619, 150);
            dataGridViewDuties.TabIndex = 0;
            dataGridViewDuties.CellClick += dataGridViewDuties_CellClick;
            // 
            // comboBoxCommittee
            // 
            comboBoxCommittee.FormattingEnabled = true;
            comboBoxCommittee.Location = new Point(12, 200);
            comboBoxCommittee.Name = "comboBoxCommittee";
            comboBoxCommittee.Size = new Size(180, 23);
            comboBoxCommittee.TabIndex = 1;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(220, 320);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(180, 23);
            comboBoxStatus.TabIndex = 2;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(220, 200);
            txtTaskDescription.Multiline = true;
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(180, 60);
            txtTaskDescription.TabIndex = 4;
            // 
            // dateTimePickerDeadline
            // 
            dateTimePickerDeadline.Location = new Point(12, 320);
            dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            dateTimePickerDeadline.Size = new Size(180, 23);
            dateTimePickerDeadline.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(51, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 30);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Duty";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(51, 112);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 30);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Duty";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(51, 64);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete Duty";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblCommittee
            // 
            lblCommittee.AutoSize = true;
            lblCommittee.Font = new Font("Segoe UI", 10F);
            lblCommittee.Location = new Point(12, 180);
            lblCommittee.Name = "lblCommittee";
            lblCommittee.Size = new Size(80, 19);
            lblCommittee.TabIndex = 9;
            lblCommittee.Text = "Committee:";
            // 
            // lblAssignedTo
            // 
            lblAssignedTo.AutoSize = true;
            lblAssignedTo.Font = new Font("Segoe UI", 10F);
            lblAssignedTo.Location = new Point(12, 240);
            lblAssignedTo.Name = "lblAssignedTo";
            lblAssignedTo.Size = new Size(85, 19);
            lblAssignedTo.TabIndex = 10;
            lblAssignedTo.Text = "Assigned To:";
            // 
            // lblTaskDescription
            // 
            lblTaskDescription.AutoSize = true;
            lblTaskDescription.Font = new Font("Segoe UI", 10F);
            lblTaskDescription.Location = new Point(220, 180);
            lblTaskDescription.Name = "lblTaskDescription";
            lblTaskDescription.Size = new Size(110, 19);
            lblTaskDescription.TabIndex = 11;
            lblTaskDescription.Text = "Task Description:";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Font = new Font("Segoe UI", 10F);
            lblDeadline.Location = new Point(12, 300);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(65, 19);
            lblDeadline.TabIndex = 12;
            lblDeadline.Text = "Deadline:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Location = new Point(220, 300);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 19);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status:";
            // 
            // comboBoxAssignedTo
            // 
            comboBoxAssignedTo.FormattingEnabled = true;
            comboBoxAssignedTo.Location = new Point(12, 262);
            comboBoxAssignedTo.Name = "comboBoxAssignedTo";
            comboBoxAssignedTo.Size = new Size(180, 23);
            comboBoxAssignedTo.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Location = new Point(411, 240);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 163);
            panel1.TabIndex = 15;
            // 
            // DutyManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 445);
            Controls.Add(panel1);
            Controls.Add(comboBoxAssignedTo);
            Controls.Add(lblStatus);
            Controls.Add(lblDeadline);
            Controls.Add(lblTaskDescription);
            Controls.Add(lblAssignedTo);
            Controls.Add(lblCommittee);
            Controls.Add(dateTimePickerDeadline);
            Controls.Add(txtTaskDescription);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxCommittee);
            Controls.Add(dataGridViewDuties);
            Name = "DutyManagement";
            Text = "Duty Management";
            Load += DutyManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDuties).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDuties;
        private System.Windows.Forms.ComboBox comboBoxCommittee;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCommittee;
        private System.Windows.Forms.Label lblAssignedTo;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblStatus;
        private ComboBox comboBoxAssignedTo;
        private Panel panel1;
    }
}
