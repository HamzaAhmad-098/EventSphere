namespace ITECManagementSystem.UI
{
    partial class EventManagement
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
            dataGridViewEvents = new DataGridView();
            label1 = new Label();
            txtEventName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDescription = new TextBox();
            label6 = new Label();
            dateTimePickerEventDate = new DateTimePicker();
            label7 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            comboBoxEdition = new ComboBox();
            comboBoxVenue = new ComboBox();
            comboBoxCommittee = new ComboBox();
            comboBoxCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEvents
            // 
            dataGridViewEvents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEvents.Location = new Point(1, 298);
            dataGridViewEvents.Name = "dataGridViewEvents";
            dataGridViewEvents.Size = new Size(706, 150);
            dataGridViewEvents.TabIndex = 0;
            dataGridViewEvents.CellClick += dataGridViewEvents_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(92, 21);
            label1.TabIndex = 1;
            label1.Text = "ITEC Edition";
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(30, 130);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(150, 23);
            txtEventName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 3;
            label2.Text = "Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(210, 20);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 4;
            label3.Text = "Venue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 220);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 5;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(30, 160);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 6;
            label5.Text = "Category Name";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(30, 240);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(150, 23);
            txtDescription.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(210, 100);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 8;
            label6.Text = "Committee";
            // 
            // dateTimePickerEventDate
            // 
            dateTimePickerEventDate.Location = new Point(210, 180);
            dateTimePickerEventDate.Name = "dateTimePickerEventDate";
            dateTimePickerEventDate.Size = new Size(200, 23);
            dateTimePickerEventDate.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(210, 160);
            label7.Name = "label7";
            label7.Size = new Size(84, 21);
            label7.TabIndex = 10;
            label7.Text = "Event Date";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(210, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 26);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Event";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(350, 220);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 26);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Event";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(520, 220);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(104, 26);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete Event";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // comboBoxEdition
            // 
            comboBoxEdition.FormattingEnabled = true;
            comboBoxEdition.Location = new Point(30, 50);
            comboBoxEdition.Name = "comboBoxEdition";
            comboBoxEdition.Size = new Size(121, 23);
            comboBoxEdition.TabIndex = 14;
            // 
            // comboBoxVenue
            // 
            comboBoxVenue.FormattingEnabled = true;
            comboBoxVenue.Location = new Point(210, 50);
            comboBoxVenue.Name = "comboBoxVenue";
            comboBoxVenue.Size = new Size(121, 23);
            comboBoxVenue.TabIndex = 15;
            // 
            // comboBoxCommittee
            // 
            comboBoxCommittee.FormattingEnabled = true;
            comboBoxCommittee.Location = new Point(210, 130);
            comboBoxCommittee.Name = "comboBoxCommittee";
            comboBoxCommittee.Size = new Size(121, 23);
            comboBoxCommittee.TabIndex = 16;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(30, 190);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 17;
            // 
            // EventManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.premium_photo_1664297751296_08177be1ce96;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(705, 450);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxCommittee);
            Controls.Add(comboBoxVenue);
            Controls.Add(comboBoxEdition);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(dateTimePickerEventDate);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEventName);
            Controls.Add(label1);
            Controls.Add(dataGridViewEvents);
            Name = "EventManagement";
            Text = "Event Management";
            Load += EventManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerEventDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBoxEdition;
        private System.Windows.Forms.ComboBox comboBoxVenue;
        private System.Windows.Forms.ComboBox comboBoxCommittee;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}
