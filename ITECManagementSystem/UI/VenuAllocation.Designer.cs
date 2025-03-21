namespace ITECManagementSystem
{
    partial class VenuAllocation
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
            comboBoxEvent = new ComboBox();
            label2 = new Label();
            comboBoxVenue = new ComboBox();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            btnAllocate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridViewAllocations = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllocations).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(40, 23);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 0;
            label1.Text = "Event";
            // 
            // comboBoxEvent
            // 
            comboBoxEvent.FormattingEnabled = true;
            comboBoxEvent.Location = new Point(40, 54);
            comboBoxEvent.Name = "comboBoxEvent";
            comboBoxEvent.Size = new Size(121, 23);
            comboBoxEvent.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(40, 89);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 2;
            label2.Text = "Venu";
            // 
            // comboBoxVenue
            // 
            comboBoxVenue.FormattingEnabled = true;
            comboBoxVenue.Location = new Point(40, 125);
            comboBoxVenue.Name = "comboBoxVenue";
            comboBoxVenue.Size = new Size(121, 23);
            comboBoxVenue.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(43, 242);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.TextAlign = HorizontalAlignment.Center;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(41, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(43, 156);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 6;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(43, 216);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 7;
            label4.Text = "Time";
            // 
            // btnAllocate
            // 
            btnAllocate.Font = new Font("Segoe UI", 12F);
            btnAllocate.Location = new Point(65, 283);
            btnAllocate.Name = "btnAllocate";
            btnAllocate.Size = new Size(124, 35);
            btnAllocate.TabIndex = 8;
            btnAllocate.Text = "Allocate Venu";
            btnAllocate.UseVisualStyleBackColor = true;
            btnAllocate.Click += btnAllocate_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(233, 283);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 35);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update Venu";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(404, 283);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 35);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete Venu";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewAllocations
            // 
            dataGridViewAllocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllocations.Location = new Point(1, 324);
            dataGridViewAllocations.Name = "dataGridViewAllocations";
            dataGridViewAllocations.Size = new Size(663, 100);
            dataGridViewAllocations.TabIndex = 11;
            dataGridViewAllocations.CellContentClick += dataGridViewAllocations_CellContentClick;
            // 
            // VenuAllocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 425);
            Controls.Add(dataGridViewAllocations);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAllocate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(maskedTextBox1);
            Controls.Add(comboBoxVenue);
            Controls.Add(label2);
            Controls.Add(comboBoxEvent);
            Controls.Add(label1);
            Name = "VenuAllocation";
            Text = "VenuAllocation";
            Load += VenuAllocation_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllocations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxEvent;
        private Label label2;
        private ComboBox comboBoxVenue;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label4;
        private Button btnAllocate;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridViewAllocations;
    }
}