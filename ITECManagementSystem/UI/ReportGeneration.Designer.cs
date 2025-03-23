namespace ITECManagementSystem
{
    partial class ReportGeneration
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(19, 22);
            button1.Name = "button1";
            button1.Size = new Size(224, 35);
            button1.TabIndex = 0;
            button1.Text = "Event Report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(19, 235);
            button2.Name = "button2";
            button2.Size = new Size(224, 35);
            button2.TabIndex = 1;
            button2.Text = "Financial Report";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(19, 130);
            button3.Name = "button3";
            button3.Size = new Size(224, 35);
            button3.TabIndex = 2;
            button3.Text = "Participant Report";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(19, 74);
            button4.Name = "button4";
            button4.Size = new Size(224, 35);
            button4.TabIndex = 3;
            button4.Text = "Committee & Role Report";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(19, 184);
            button5.Name = "button5";
            button5.Size = new Size(224, 35);
            button5.TabIndex = 4;
            button5.Text = "Venue Allocation Report";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(219, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 294);
            panel1.TabIndex = 5;
            // 
            // ReportGeneration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 450);
            Controls.Add(panel1);
            Name = "ReportGeneration";
            Text = "ReportGeneration";
            Load += ReportGeneration_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
    }
}