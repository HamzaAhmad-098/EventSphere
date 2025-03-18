namespace ITECManagementSystem
{
    partial class FeeTrackingAdmin
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
            dataGridViewPayments = new DataGridView();
            comboBoxPaymentStatus = new ComboBox();
            btnUpdatePayment = new Button();
            label1 = new Label();
            txtSearchParticipant = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayments.Location = new Point(2, 192);
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.Size = new Size(679, 150);
            dataGridViewPayments.TabIndex = 0;
            dataGridViewPayments.CellContentClick += dataGridViewPayments_CellContentClick;
            // 
            // comboBoxPaymentStatus
            // 
            comboBoxPaymentStatus.FormattingEnabled = true;
            comboBoxPaymentStatus.Location = new Point(25, 63);
            comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            comboBoxPaymentStatus.Size = new Size(121, 23);
            comboBoxPaymentStatus.TabIndex = 1;
            // 
            // btnUpdatePayment
            // 
            btnUpdatePayment.Font = new Font("Segoe UI", 12F);
            btnUpdatePayment.Location = new Point(25, 132);
            btnUpdatePayment.Name = "btnUpdatePayment";
            btnUpdatePayment.Size = new Size(129, 36);
            btnUpdatePayment.TabIndex = 2;
            btnUpdatePayment.Text = "Save Changes";
            btnUpdatePayment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 3;
            label1.Text = "Status";
            // 
            // txtSearchParticipant
            // 
            txtSearchParticipant.Location = new Point(264, 63);
            txtSearchParticipant.Name = "txtSearchParticipant";
            txtSearchParticipant.Size = new Size(100, 23);
            txtSearchParticipant.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(252, 132);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(129, 36);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // FeeTrackingAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 344);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchParticipant);
            Controls.Add(label1);
            Controls.Add(btnUpdatePayment);
            Controls.Add(comboBoxPaymentStatus);
            Controls.Add(dataGridViewPayments);
            Name = "FeeTrackingAdmin";
            Load += FeeTrackingAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPayments;
        private ComboBox comboBoxPaymentStatus;
        private Button btnUpdatePayment;
        private Label label1;
        private TextBox txtSearchParticipant;
        private Button btnSearch;
    }
}