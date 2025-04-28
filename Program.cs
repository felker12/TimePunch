using System.Runtime.CompilerServices;

namespace TimePunch
{
    internal static class Program
    {
        private static readonly List<EmployeeTimePunches> employeeTimePunchesList = [];

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            PrintAllEmployeeTimePunches();

            Application.Run(Form1.MainMenu);
        }

        public static void AddEmployeeTPList(EmployeeTimePunches empTP)
        {
            employeeTimePunchesList.Add(empTP);
        }

        public static void UpdateEmployeeClockIn(int id, string ciTime)
        {
            for (int i = 0; i <  employeeTimePunchesList.Count; i++)
            {
                if (employeeTimePunchesList[i].employeeid == id)
                {
                    employeeTimePunchesList[i].employeeClockIn = ciTime;
                    break;
                }
            }
        }

        public static void UpdateEmployeeClockOut(int id, string coTime)
        {
            for (int i = 0; i < employeeTimePunchesList.Count; i++)
            {
                if (employeeTimePunchesList[i].employeeid == id)
                {
                    employeeTimePunchesList[i].employeeClockOut = coTime;
                    break;
                }
            }
        }

        public static void UpdateEmployeeStartBreak(int id, string sbTime)
        {
            for (int i = 0; i < employeeTimePunchesList.Count; i++)
            {
                if (employeeTimePunchesList[i].employeeid == id)
                {
                    employeeTimePunchesList[i].employeeBreakStart= sbTime;
                    break;
                }
            }
        }

        public static void UpdateEmployeeEndBreak(int id, string ebTime)
        {
            for (int i = 0; i < employeeTimePunchesList.Count; i++)
            {
                if (employeeTimePunchesList[i].employeeid == id)
                {
                    employeeTimePunchesList[i].employeeBreakEnd= ebTime;
                    break;
                }
            }
        }

        public static List<EmployeeTimePunches> getEmployeeTPList()
        {
            return employeeTimePunchesList;
        }
        
        //checks if employee id is already in employee time punchs list
        public static bool CheckEmployeeTPList(int id)
        {
            foreach (EmployeeTimePunches etp in Program.getEmployeeTPList())
            {
                if (etp.employeeid.Equals(id)) return true;
            }
            return false;
        }

        public static void PrintAllEmployeeTimePunches()
        {
            foreach (EmployeeTimePunches etp in Program.getEmployeeTPList())
            {
                System.Diagnostics.Debug.WriteLine(
                    $"id = {etp.employeeid}\n" +
                    $"clock in = {etp.employeeClockIn}\n" +
                    $"clock out = {etp.employeeClockOut}\n" +
                    $"break start = {etp.employeeBreakStart}\n" +
                    $"break end = {etp.employeeBreakEnd}");
            }
        }
    }
}