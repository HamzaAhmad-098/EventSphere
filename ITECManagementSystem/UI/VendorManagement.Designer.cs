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
            this.dataGridViewVendors = new System.Windows.Forms.DataGridView();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVendors
            // 
            this.dataGridViewVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendors.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewVendors.Name = "dataGridViewVendors";
            this.dataGridViewVendors.Size = new System.Drawing.Size(600, 150);
            this.dataGridViewVendors.TabIndex = 0;
            this.dataGridViewVendors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVendors_CellClick);
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(12, 190);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(200, 23);
            this.txtVendorName.TabIndex = 1;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(12, 240);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(200, 23);
            this.txtContact.TabIndex = 2;
            // 
            // txtServiceType
            // 
            this.txtServiceType.Location = new System.Drawing.Point(12, 290);
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(200, 23);
            this.txtServiceType.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(93, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(12, 170);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(88, 15);
            this.lblVendorName.TabIndex = 7;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(12, 220);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(55, 15);
            this.lblContact.TabIndex = 8;
            this.lblContact.Text = "Contact:";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(12, 270);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(80, 15);
            this.lblServiceType.TabIndex = 9;
            this.lblServiceType.Text = "Service Type:";
            // 
            // VendorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 391);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtServiceType);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.dataGridViewVendors);
            this.Name = "VendorManagement";
            this.Text = "Vendor Management";
            this.Load += new System.EventHandler(this.VendorManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
