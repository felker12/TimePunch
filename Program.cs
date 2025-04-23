using System.Runtime.CompilerServices;

namespace TimePunch
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        private static List<EmployeeTimePunches> employeeTimePunchesList = new List<EmployeeTimePunches>();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(Form1.MainMenu);
        }

        public static void addEmployeeTPList(EmployeeTimePunches empTP)
        {
            employeeTimePunchesList.Add(empTP);
        }

        public static void updateEmployeeClockIn(int id, string ciTime)
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

        public static void updateEmployeeClockOut(int id, string coTime)
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

        public static void updateEmployeeStartBreak(int id, string sbTime)
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

        public static void updateEmployeeEndBreak(int id, string ebTime)
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
        public static bool checkEmployeeTPList(int id)
        {
            foreach (EmployeeTimePunches etp in Program.getEmployeeTPList())
            {
                if (etp.employeeid.Equals(id)) return true;
            }
            return false;
        }


        //TODO temp
        /*
        public static void printAllEmployeeTimePunches()
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
        */



    }
}