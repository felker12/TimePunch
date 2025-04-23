namespace TimePunch
{
    partial class TimeClockForm
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
            ClockInButton = new Button();
            ClockOutButton = new Button();
            StartBreakButton = new Button();
            EndBreakButton = new Button();
            SuspendLayout();
            // 
            // ClockInButton
            // 
            ClockInButton.Location = new Point(130, 168);
            ClockInButton.Name = "ClockInButton";
            ClockInButton.Size = new Size(75, 23);
            ClockInButton.TabIndex = 0;
            ClockInButton.Text = "Clock In";
            ClockInButton.UseVisualStyleBackColor = true;
            ClockInButton.Click += ClockInButton_Click;
            // 
            // ClockOutButton
            // 
            ClockOutButton.Location = new Point(318, 168);
            ClockOutButton.Name = "ClockOutButton";
            ClockOutButton.Size = new Size(75, 23);
            ClockOutButton.TabIndex = 1;
            ClockOutButton.Text = "Clock Out";
            ClockOutButton.UseVisualStyleBackColor = true;
            ClockOutButton.Click += ClockOutButton_Click;
            // 
            // StartBreakButton
            // 
            StartBreakButton.Location = new Point(130, 233);
            StartBreakButton.Name = "StartBreakButton";
            StartBreakButton.Size = new Size(75, 23);
            StartBreakButton.TabIndex = 2;
            StartBreakButton.Text = "Start Break";
            StartBreakButton.UseVisualStyleBackColor = true;
            StartBreakButton.Click += StartBreakButton_Click;
            // 
            // EndBreakButton
            // 
            EndBreakButton.Location = new Point(318, 233);
            EndBreakButton.Name = "EndBreakButton";
            EndBreakButton.Size = new Size(75, 23);
            EndBreakButton.TabIndex = 3;
            EndBreakButton.Text = "End Break";
            EndBreakButton.UseVisualStyleBackColor = true;
            EndBreakButton.Click += EndBreakButton_Click;
            // 
            // TimeClockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 461);
            Controls.Add(EndBreakButton);
            Controls.Add(StartBreakButton);
            Controls.Add(ClockOutButton);
            Controls.Add(ClockInButton);
            Name = "TimeClockForm";
            Text = "TimeClockForm";
            FormClosing += TimeClockForm_FormClosing;
            Load += TimeClockForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ClockInButton;
        private Button ClockOutButton;
        private Button StartBreakButton;
        private Button EndBreakButton;
    }
}