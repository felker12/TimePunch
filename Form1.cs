using Microsoft.VisualBasic;

namespace TimePunch
{
    public partial class Form1 : Form
    {
        private static Form1 _mainMenu = new Form1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //TODO this is a temp thing
            //Program.printAllEmployeeTimePunches();
        }

        public static Form1 MainMenu
        {
            get
            {
                _mainMenu ??= new Form1();
                return _mainMenu;
            }
        }
        private void ClockInButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(EmployeeIDTextBox.Text);
                int pass = int.Parse(EmployeePassTextBox.Text);

                //validate id and pass exist in the DB
                if (TimeClockDataLayer.IsUser(id, pass))
                {
                    EmployeeIDTextBox.Text = String.Empty;
                    EmployeePassTextBox.Text = String.Empty;

                    EmployeeTimePunches employeeTP = new();
                    employeeTP.employeeid = id;

                    if (Program.CheckEmployeeTPList(id) == false)
                    {
                        Program.AddEmployeeTPList(employeeTP);
                    }

                    TimeClockForm ClockIn = new(id);
                    ClockIn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password", "Invalid ID or Password");
                }
            }
            catch
            {
                MessageBox.Show("ID and Password must be numbers", "Invalid ID or Password");
            }
        }
    }
}
