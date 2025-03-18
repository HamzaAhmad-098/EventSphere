namespace ITECManagementSystem
{
    partial class AddVenu
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
            label1 = new Label();
            txtVenueName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLocation = new TextBox();
            txtCapacity = new TextBox();
            dataGridViewVenues = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearchVenue = new TextBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenues).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(43, 36);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "Venu Name";
            // 
            // txtVenueName
            // 
            txtVenueName.Location = new Point(43, 73);
            txtVenueName.Name = "txtVenueName";
            txtVenueName.Size = new Size(100, 23);
            txtVenueName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(43, 115);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 2;
            label2.Text = "Venu Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(43, 184);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 3;
            label3.Text = "Venu Location";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(43, 217);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(100, 23);
            txtLocation.TabIndex = 4;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(43, 148);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 23);
            txtCapacity.TabIndex = 5;
            // 
            // dataGridViewVenues
            // 
            dataGridViewVenues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVenues.Location = new Point(4, 255);
            dataGridViewVenues.Name = "dataGridViewVenues";
            dataGridViewVenues.Size = new Size(694, 131);
            dataGridViewVenues.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(180, 202);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 47);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add venu";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(357, 202);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 47);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update venue";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(525, 202);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 47);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Venue";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(258, 115);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(162, 47);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchVenue
            // 
            txtSearchVenue.Location = new Point(268, 73);
            txtSearchVenue.Name = "txtSearchVenue";
            txtSearchVenue.Size = new Size(152, 23);
            txtSearchVenue.TabIndex = 11;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // AddVenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 389);
            Controls.Add(txtSearchVenue);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewVenues);
            Controls.Add(txtCapacity);
            Controls.Add(txtLocation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtVenueName);
            Controls.Add(label1);
            Name = "AddVenu";
            Text = "AddVenu";
            Load += AddVenu_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVenues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVenueName;
        private Label label2;
        private Label label3;
        private TextBox txtLocation;
        private TextBox txtCapacity;
        private DataGridView dataGridViewVenues;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearchVenue;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}