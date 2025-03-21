namespace ITECManagementSystem.UI
{
    partial class SponsorManagement
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
            dataGridViewSponsors = new DataGridView();
            txtSponsorName = new TextBox();
            label1 = new Label();
            txtContact = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSponsors).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSponsors
            // 
            dataGridViewSponsors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSponsors.Location = new Point(1, -2);
            dataGridViewSponsors.Name = "dataGridViewSponsors";
            dataGridViewSponsors.Size = new Size(701, 142);
            dataGridViewSponsors.TabIndex = 0;
            // 
            // txtSponsorName
            // 
            txtSponsorName.Location = new Point(12, 192);
            txtSponsorName.Name = "txtSponsorName";
            txtSponsorName.Size = new Size(111, 23);
            txtSponsorName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 158);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 2;
            label1.Text = "Sponsor name";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(12, 266);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(111, 23);
            txtContact.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 229);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 4;
            label2.Text = "Sponsor contact";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(73, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add sponsor ";
            btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);


            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(453, 322);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 46);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete sponsor ";
            btnDelete.UseVisualStyleBackColor = true;

            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(263, 322);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 46);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update sponsor ";
            btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // SponsorManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 413);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(txtContact);
            Controls.Add(label1);
            Controls.Add(txtSponsorName);
            Controls.Add(dataGridViewSponsors);
            Name = "SponsorManagement";
            Text = "SponsorManagement";
            Load += SponsorManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSponsors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSponsors;
        private TextBox txtSponsorName;
        private Label label1;
        private TextBox txtContact;
        private Label label2;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
    }
}