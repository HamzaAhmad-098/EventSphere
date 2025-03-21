namespace ITECManagementSystem
{
    partial class AddVenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewVenues;
        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearchVenue;
        private System.Windows.Forms.Button btnSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVenu));
            dataGridViewVenues = new DataGridView();
            txtVenueName = new TextBox();
            label1 = new Label();
            txtCapacity = new TextBox();
            label2 = new Label();
            txtLocation = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtSearchVenue = new TextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenues).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewVenues
            // 
            dataGridViewVenues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVenues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVenues.Location = new Point(0, 269);
            dataGridViewVenues.Name = "dataGridViewVenues";
            dataGridViewVenues.Size = new Size(554, 100);
            dataGridViewVenues.TabIndex = 0;
            dataGridViewVenues.CellContentClick += dataGridViewVenues_CellContentClick_1;
            // 
            // txtVenueName
            // 
            txtVenueName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtVenueName.Location = new Point(60, 41);
            txtVenueName.Name = "txtVenueName";
            txtVenueName.Size = new Size(150, 23);
            txtVenueName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 2;
            label1.Text = "Venue Name";
            // 
            // txtCapacity
            // 
            txtCapacity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCapacity.Location = new Point(60, 99);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(150, 23);
            txtCapacity.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(60, 71);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 4;
            label2.Text = "Capacity";
            // 
            // txtLocation
            // 
            txtLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLocation.Location = new Point(60, 158);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(150, 23);
            txtLocation.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(60, 125);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 6;
            label3.Text = "Location";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(45, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 30);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Venue";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(45, 59);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 30);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update Venue";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(45, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Venue";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearchVenue
            // 
            txtSearchVenue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchVenue.Location = new Point(58, 231);
            txtSearchVenue.Name = "txtSearchVenue";
            txtSearchVenue.Size = new Size(150, 23);
            txtSearchVenue.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(58, 194);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(118, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search Venue";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Location = new Point(334, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 143);
            panel1.TabIndex = 12;
            // 
            // AddVenu
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(557, 369);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchVenue);
            Controls.Add(label3);
            Controls.Add(txtLocation);
            Controls.Add(label2);
            Controls.Add(txtCapacity);
            Controls.Add(label1);
            Controls.Add(txtVenueName);
            Controls.Add(dataGridViewVenues);
            Name = "AddVenu";
            Text = "Venue Management";
            Load += AddVenu_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenues).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
    }
}
