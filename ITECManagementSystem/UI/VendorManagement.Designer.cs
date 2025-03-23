namespace ITECManagementSystem.UI
{
    partial class VendorManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewVendors = new DataGridView();
            txtVendorName = new TextBox();
            txtContact = new TextBox();
            txtServiceType = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblVendorName = new Label();
            lblContact = new Label();
            lblServiceType = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendors).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVendors
            // 
            dataGridViewVendors.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVendors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendors.Location = new Point(-1, -2);
            dataGridViewVendors.Name = "dataGridViewVendors";
            dataGridViewVendors.Size = new Size(625, 150);
            dataGridViewVendors.TabIndex = 0;
            dataGridViewVendors.CellClick += dataGridViewVendors_CellClick;
            // 
            // txtVendorName
            // 
            txtVendorName.Location = new Point(12, 190);
            txtVendorName.Name = "txtVendorName";
            txtVendorName.Size = new Size(200, 23);
            txtVendorName.TabIndex = 1;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(12, 240);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(200, 23);
            txtContact.TabIndex = 2;
            // 
            // txtServiceType
            // 
            txtServiceType.Location = new Point(12, 290);
            txtServiceType.Name = "txtServiceType";
            txtServiceType.Size = new Size(200, 23);
            txtServiceType.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 340);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(93, 340);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 340);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblVendorName
            // 
            lblVendorName.AutoSize = true;
            lblVendorName.Location = new Point(12, 170);
            lblVendorName.Name = "lblVendorName";
            lblVendorName.Size = new Size(82, 15);
            lblVendorName.TabIndex = 7;
            lblVendorName.Text = "Vendor Name:";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(12, 220);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(52, 15);
            lblContact.TabIndex = 8;
            lblContact.Text = "Contact:";
            // 
            // lblServiceType
            // 
            lblServiceType.AutoSize = true;
            lblServiceType.Location = new Point(12, 270);
            lblServiceType.Name = "lblServiceType";
            lblServiceType.Size = new Size(74, 15);
            lblServiceType.TabIndex = 9;
            lblServiceType.Text = "Service Type:";
            // 
            // VendorManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.premium_photo_1664297751296_08177be1ce96;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(624, 391);
            Controls.Add(lblServiceType);
            Controls.Add(lblContact);
            Controls.Add(lblVendorName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtServiceType);
            Controls.Add(txtContact);
            Controls.Add(txtVendorName);
            Controls.Add(dataGridViewVendors);
            Name = "VendorManagement";
            Text = "Vendor Management";
            Load += VendorManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewVendors;
        private TextBox txtVendorName;
        private TextBox txtContact;
        private TextBox txtServiceType;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblVendorName;
        private Label lblContact;
        private Label lblServiceType;
    }
}
