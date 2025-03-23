namespace ITECManagementSystem
{
    partial class FinancialManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialManagement));
            btnRecordTransaction = new Button();
            label4 = new Label();
            txtTransactionDescription = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtAmount = new TextBox();
            label1 = new Label();
            comboBoxItec = new ComboBox();
            label5 = new Label();
            dateTimePickerDateRecorded = new DateTimePicker();
            comboBoxEvent = new ComboBox();
            comboBoxType = new ComboBox();
            comboBoxFromEntityType = new ComboBox();
            comboBoxToEntity = new ComboBox();
            comboBoxToEntityType = new ComboBox();
            comboBoxFromEntity = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRecordTransaction
            // 
            btnRecordTransaction.Font = new Font("Segoe UI", 15F);
            btnRecordTransaction.Location = new Point(238, 469);
            btnRecordTransaction.Name = "btnRecordTransaction";
            btnRecordTransaction.Size = new Size(175, 51);
            btnRecordTransaction.TabIndex = 21;
            btnRecordTransaction.Text = "ADD Transaction";
            btnRecordTransaction.UseVisualStyleBackColor = true;
            btnRecordTransaction.Click += btnRecordTransaction_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(274, 10);
            label4.Name = "label4";
            label4.Size = new Size(159, 28);
            label4.TabIndex = 19;
            label4.Text = "From Entity Type";
            // 
            // txtTransactionDescription
            // 
            txtTransactionDescription.Location = new Point(280, 304);
            txtTransactionDescription.Name = "txtTransactionDescription";
            txtTransactionDescription.Size = new Size(148, 23);
            txtTransactionDescription.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(15, 80);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 17;
            label3.Text = "Itec Event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(21, 213);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 15;
            label2.Text = "Amount";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(15, 244);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(148, 23);
            txtAmount.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(15, 147);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 13;
            label1.Text = "Transaction Type ";
            // 
            // comboBoxItec
            // 
            comboBoxItec.FormattingEnabled = true;
            comboBoxItec.Items.AddRange(new object[] { "Sponsorships", "Ticket sales", "Other sources." });
            comboBoxItec.Location = new Point(15, 42);
            comboBoxItec.Name = "comboBoxItec";
            comboBoxItec.Size = new Size(148, 23);
            comboBoxItec.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(15, 11);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 26;
            label5.Text = "Itec Edition";
            // 
            // dateTimePickerDateRecorded
            // 
            dateTimePickerDateRecorded.Location = new Point(15, 301);
            dateTimePickerDateRecorded.Name = "dateTimePickerDateRecorded";
            dateTimePickerDateRecorded.Size = new Size(200, 23);
            dateTimePickerDateRecorded.TabIndex = 27;
            // 
            // comboBoxEvent
            // 
            comboBoxEvent.FormattingEnabled = true;
            comboBoxEvent.Items.AddRange(new object[] { "Sponsorships", "Ticket sales", "Other sources." });
            comboBoxEvent.Location = new Point(15, 111);
            comboBoxEvent.Name = "comboBoxEvent";
            comboBoxEvent.Size = new Size(148, 23);
            comboBoxEvent.TabIndex = 28;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Sponsorships", "Ticket sales", "Other sources." });
            comboBoxType.Location = new Point(15, 187);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(148, 23);
            comboBoxType.TabIndex = 29;
            // 
            // comboBoxFromEntityType
            // 
            comboBoxFromEntityType.FormattingEnabled = true;
            comboBoxFromEntityType.Items.AddRange(new object[] { "Sponsorships", "Ticket sales", "Other sources." });
            comboBoxFromEntityType.Location = new Point(280, 42);
            comboBoxFromEntityType.Name = "comboBoxFromEntityType";
            comboBoxFromEntityType.Size = new Size(148, 23);
            comboBoxFromEntityType.TabIndex = 30;
            comboBoxFromEntityType.SelectedIndexChanged += ComboBoxFromEntityType_SelectedIndexChanged;
            // 
            // comboBoxToEntity
            // 
            comboBoxToEntity.FormattingEnabled = true;
            comboBoxToEntity.Items.AddRange(new object[] { "Sponsorships", "Ticket sales", "Other sources." });
            comboBoxToEntity.Location = new Point(285, 244);
            comboBoxToEntity.Name = "comboBoxToEntity";
            comboBoxToEntity.Size = new Size(148, 23);
            comboBoxToEntity.TabIndex = 31;
            // 
            // comboBoxToEntityType
            // 
            comboBoxToEntityType.FormattingEnabled = true;
            comboBoxToEntityType.Items.AddRange(new object[] { "Sponsorships", "Ticket sales", "Other sources." });
            comboBoxToEntityType.Location = new Point(284, 183);
            comboBoxToEntityType.Name = "comboBoxToEntityType";
            comboBoxToEntityType.Size = new Size(148, 23);
            comboBoxToEntityType.TabIndex = 32;
            comboBoxToEntityType.SelectedIndexChanged += ComboBoxToEntityType_SelectedIndexChanged;
            // 
            // comboBoxFromEntity
            // 
            comboBoxFromEntity.FormattingEnabled = true;
            comboBoxFromEntity.Items.AddRange(new object[] { "Sponsorships", "Ticket sales", "Other sources." });
            comboBoxFromEntity.Location = new Point(282, 111);
            comboBoxFromEntity.Name = "comboBoxFromEntity";
            comboBoxFromEntity.Size = new Size(148, 23);
            comboBoxFromEntity.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(274, 80);
            label6.Name = "label6";
            label6.Size = new Size(119, 28);
            label6.TabIndex = 34;
            label6.Text = "Entity Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(275, 213);
            label7.Name = "label7";
            label7.Size = new Size(119, 28);
            label7.TabIndex = 35;
            label7.Text = "Entity Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(276, 145);
            label8.Name = "label8";
            label8.Size = new Size(123, 28);
            label8.TabIndex = 36;
            label8.Text = "ToEntityType";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(21, 270);
            label10.Name = "label10";
            label10.Size = new Size(53, 28);
            label10.TabIndex = 38;
            label10.Text = "Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 15F);
            label11.Location = new Point(275, 270);
            label11.Name = "label11";
            label11.Size = new Size(112, 28);
            label11.TabIndex = 39;
            label11.Text = "Description";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtTransactionDescription);
            panel1.Controls.Add(comboBoxItec);
            panel1.Controls.Add(dateTimePickerDateRecorded);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBoxToEntity);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(comboBoxToEntityType);
            panel1.Controls.Add(comboBoxEvent);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxFromEntity);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(comboBoxType);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBoxFromEntityType);
            panel1.Location = new Point(101, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 363);
            panel1.TabIndex = 40;
            // 
            // FinancialManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(645, 605);
            Controls.Add(panel1);
            Controls.Add(btnRecordTransaction);
            Name = "FinancialManagement";
            Text = "d";
            Load += FinancialManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRecordTransaction;
        private Label label4;
        private TextBox txtTransactionDescription;
        private Label label3;
        private Label label2;
        private TextBox txtAmount;
        private Label label1;
        private ComboBox comboBoxItec;
        private Label label5;
        private DateTimePicker dateTimePickerDateRecorded;
        private ComboBox comboBoxEvent;
        private ComboBox comboBoxType;
        private ComboBox comboBoxFromEntityType;
        private ComboBox comboBoxToEntity;
        private ComboBox comboBoxToEntityType;
        private ComboBox comboBoxFromEntity;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Panel panel1;
    }
}