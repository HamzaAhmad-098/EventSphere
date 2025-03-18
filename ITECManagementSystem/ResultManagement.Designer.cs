namespace ITECManagementSystem
{
    partial class ResultManagement
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
            comboBoxEvent = new ComboBox();
            comboBoxParticipant = new ComboBox();
            comboBoxTeam = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDownPosition = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxScore = new TextBox();
            textBoxRemarks = new TextBox();
            btnSaveResult = new Button();
            btnUpdateResult = new Button();
            btnDeleteResult = new Button();
            dataGridViewResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // comboBoxEvent
            // 
            comboBoxEvent.FormattingEnabled = true;
            comboBoxEvent.Location = new Point(31, 60);
            comboBoxEvent.Name = "comboBoxEvent";
            comboBoxEvent.Size = new Size(121, 23);
            comboBoxEvent.TabIndex = 0;
            // 
            // comboBoxParticipant
            // 
            comboBoxParticipant.FormattingEnabled = true;
            comboBoxParticipant.Location = new Point(31, 130);
            comboBoxParticipant.Name = "comboBoxParticipant";
            comboBoxParticipant.Size = new Size(121, 23);
            comboBoxParticipant.TabIndex = 1;
            // 
            // comboBoxTeam
            // 
            comboBoxTeam.FormattingEnabled = true;
            comboBoxTeam.Location = new Point(291, 60);
            comboBoxTeam.Name = "comboBoxTeam";
            comboBoxTeam.Size = new Size(121, 23);
            comboBoxTeam.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(61, 86);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(31, 22);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 4;
            label2.Text = "Event";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(291, 22);
            label3.Name = "label3";
            label3.Size = new Size(46, 21);
            label3.TabIndex = 5;
            label3.Text = "Team";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(31, 97);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 6;
            label4.Text = "Participant";
            // 
            // numericUpDownPosition
            // 
            numericUpDownPosition.Location = new Point(292, 130);
            numericUpDownPosition.Name = "numericUpDownPosition";
            numericUpDownPosition.Size = new Size(120, 23);
            numericUpDownPosition.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(291, 178);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 8;
            label5.Text = "Enter remarks";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(31, 178);
            label6.Name = "label6";
            label6.Size = new Size(87, 21);
            label6.TabIndex = 9;
            label6.Text = "Enter score";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(291, 97);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 10;
            label7.Text = "Position";
            // 
            // textBoxScore
            // 
            textBoxScore.Location = new Point(31, 219);
            textBoxScore.Name = "textBoxScore";
            textBoxScore.Size = new Size(119, 23);
            textBoxScore.TabIndex = 11;
            // 
            // textBoxRemarks
            // 
            textBoxRemarks.Location = new Point(291, 219);
            textBoxRemarks.Name = "textBoxRemarks";
            textBoxRemarks.Size = new Size(119, 23);
            textBoxRemarks.TabIndex = 12;
            // 
            // btnSaveResult
            // 
            btnSaveResult.Font = new Font("Segoe UI", 12F);
            btnSaveResult.Location = new Point(78, 272);
            btnSaveResult.Name = "btnSaveResult";
            btnSaveResult.Size = new Size(139, 43);
            btnSaveResult.TabIndex = 13;
            btnSaveResult.Text = "ADD Result";
            btnSaveResult.UseVisualStyleBackColor = true;
            btnSaveResult.Click += btnSaveResult_Click;
            // 
            // btnUpdateResult
            // 
            btnUpdateResult.Font = new Font("Segoe UI", 12F);
            btnUpdateResult.Location = new Point(259, 272);
            btnUpdateResult.Name = "btnUpdateResult";
            btnUpdateResult.Size = new Size(139, 43);
            btnUpdateResult.TabIndex = 14;
            btnUpdateResult.Text = "Edit Result";
            btnUpdateResult.UseVisualStyleBackColor = true;
            // 
            // btnDeleteResult
            // 
            btnDeleteResult.Font = new Font("Segoe UI", 12F);
            btnDeleteResult.Location = new Point(453, 272);
            btnDeleteResult.Name = "btnDeleteResult";
            btnDeleteResult.Size = new Size(139, 43);
            btnDeleteResult.TabIndex = 15;
            btnDeleteResult.Text = "Delete Result";
            btnDeleteResult.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(2, 336);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new Size(667, 157);
            dataGridViewResults.TabIndex = 16;
            // 
            // ResultManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 493);
            Controls.Add(dataGridViewResults);
            Controls.Add(btnDeleteResult);
            Controls.Add(btnUpdateResult);
            Controls.Add(btnSaveResult);
            Controls.Add(textBoxRemarks);
            Controls.Add(textBoxScore);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numericUpDownPosition);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxTeam);
            Controls.Add(comboBoxParticipant);
            Controls.Add(comboBoxEvent);
            Name = "ResultManagement";
            Text = "ResultManagement";
            Load += ResultManagement_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxEvent;
        private ComboBox comboBoxParticipant;
        private ComboBox comboBoxTeam;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownPosition;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxScore;
        private TextBox textBoxRemarks;
        private Button btnSaveResult;
        private Button btnUpdateResult;
        private Button btnDeleteResult;
        private DataGridView dataGridViewResults;
    }
}