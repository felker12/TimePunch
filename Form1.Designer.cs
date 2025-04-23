namespace TimePunch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ClockInButton = new Button();
            EmployeeIDTextBox = new TextBox();
            EmployeeIDLabel = new Label();
            EmployeePassLabel = new Label();
            EmployeePassTextBox = new TextBox();
            SuspendLayout();
            // 
            // ClockInButton
            // 
            ClockInButton.Location = new Point(224, 229);
            ClockInButton.Name = "ClockInButton";
            ClockInButton.Size = new Size(75, 23);
            ClockInButton.TabIndex = 0;
            ClockInButton.Text = "Clock In";
            ClockInButton.UseVisualStyleBackColor = true;
            ClockInButton.Click += ClockInButton_Click;
            // 
            // EmployeeIDTextBox
            // 
            EmployeeIDTextBox.Location = new Point(210, 171);
            EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            EmployeeIDTextBox.Size = new Size(100, 23);
            EmployeeIDTextBox.TabIndex = 1;
            // 
            // EmployeeIDLabel
            // 
            EmployeeIDLabel.AutoSize = true;
            EmployeeIDLabel.Location = new Point(131, 174);
            EmployeeIDLabel.Name = "EmployeeIDLabel";
            EmployeeIDLabel.Size = new Size(73, 15);
            EmployeeIDLabel.TabIndex = 2;
            EmployeeIDLabel.Text = "Employee ID";
            // 
            // EmployeePassLabel
            // 
            EmployeePassLabel.AutoSize = true;
            EmployeePassLabel.Location = new Point(149, 200);
            EmployeePassLabel.Name = "EmployeePassLabel";
            EmployeePassLabel.Size = new Size(57, 15);
            EmployeePassLabel.TabIndex = 3;
            EmployeePassLabel.Text = "Password";
            // 
            // EmployeePassTextBox
            // 
            EmployeePassTextBox.Location = new Point(212, 200);
            EmployeePassTextBox.Name = "EmployeePassTextBox";
            EmployeePassTextBox.Size = new Size(100, 23);
            EmployeePassTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 461);
            Controls.Add(EmployeePassTextBox);
            Controls.Add(EmployeePassLabel);
            Controls.Add(EmployeeIDLabel);
            Controls.Add(EmployeeIDTextBox);
            Controls.Add(ClockInButton);
            Name = "Form1";
            Text = "Time Clock";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClockInButton;
        private TextBox EmployeeIDTextBox;
        private Label EmployeeIDLabel;
        private Label EmployeePassLabel;
        private TextBox EmployeePassTextBox;
    }
}
