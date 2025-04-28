using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimePunch
{
    public partial class TimeClockForm : Form
    {
        int empID = 0;
        DateTime dt = new DateTime();
        string formattedDT = string.Empty;

        public TimeClockForm(int id)
        {
            InitializeComponent();
            empID = id;
        }

        private void TimeClockForm_Load(object sender, EventArgs e)
        {
        }

        private void ClockInButton_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            formattedDT = dt.ToString("yyyy-MM-dd H:mm:ss.fff");

            foreach (EmployeeTimePunches etp in Program.getEmployeeTPList())
            {
                if (etp.employeeid.Equals(empID))
                {
                    if (etp.employeeClockIn == string.Empty)
                    {
                        Program.UpdateEmployeeClockIn(etp.employeeid, formattedDT);

                        this.Close();
                        MessageBox.Show("You have successfully clocked in at " + formattedDT, "Clocked In");
                        Form1.MainMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("You are already clocked in", "Clocked In");
                    }
                }
            }
        }

        private void ClockOutButton_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            formattedDT = dt.ToString("yyyy-MM-dd H:mm:ss.fff");

            foreach (EmployeeTimePunches etp in Program.getEmployeeTPList())
            {
                if (etp.employeeid.Equals(empID))
                {
                    if (etp.employeeClockOut == string.Empty)
                    {
                        Program.UpdateEmployeeClockOut(etp.employeeid, formattedDT);

                        this.Close();
                        MessageBox.Show("You have successfully clocked out at " + formattedDT, "Clocked Out");
                        Form1.MainMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("You are already clocked out", "Clocked Out");
                    }
                }
            }
        }

        private void StartBreakButton_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            formattedDT = dt.ToString("yyyy-MM-dd H:mm:ss.fff");

            foreach (EmployeeTimePunches etp in Program.getEmployeeTPList())
            {
                if (etp.employeeid.Equals(empID))
                {
                    if (etp.employeeBreakStart == string.Empty)
                    {
                        Program.UpdateEmployeeStartBreak(etp.employeeid, formattedDT);

                        this.Close();
                        MessageBox.Show("You have successfully started break at " + formattedDT, "Break Started");
                        Form1.MainMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("You are already on break", "Break Started");
                    }
                }
            }
        }

        private void EndBreakButton_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            formattedDT = dt.ToString("yyyy-MM-dd H:mm:ss.fff");

            foreach (EmployeeTimePunches etp in Program.getEmployeeTPList())
            {
                if (etp.employeeid.Equals(empID))
                {
                    if (etp.employeeBreakEnd== string.Empty)
                    {
                        Program.UpdateEmployeeEndBreak(etp.employeeid, formattedDT);

                        this.Close();
                        MessageBox.Show("You have successfully ended break at " + formattedDT, "Break Ended");
                        Form1.MainMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Your break is already over", "Break Ended");
                    }
                }
            }
        }

        private void TimeClockForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.MainMenu.Show();
        }
    }
}
