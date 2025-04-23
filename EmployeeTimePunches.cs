using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePunch
{
    internal class EmployeeTimePunches
    {
        public int employeeid = 0;
        public string employeeClockIn = string.Empty;
        public string employeeClockOut = string.Empty;
        public string employeeBreakStart = string.Empty;
        public string employeeBreakEnd = string.Empty;

        public EmployeeTimePunches()
        {
        }

        public EmployeeTimePunches getEmployeeTimePunches()
        {
            EmployeeTimePunches employeeTP = new EmployeeTimePunches();
            employeeTP.employeeid = employeeid;
            employeeTP.employeeClockIn = employeeClockIn;
            employeeTP.employeeClockOut = employeeClockOut;
            employeeTP.employeeBreakStart = employeeBreakStart;
            employeeTP.employeeBreakEnd = employeeBreakEnd;

            return employeeTP; 
        }
    }
}
