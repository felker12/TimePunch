using System.Data.SqlClient;

namespace TimePunch
{
    public static class TimeClockDataLayer
    {
        public static string GetConnectionString()
        {
            return "data source=ANTHONYSLAPTOP;initial catalog=LogIn;trusted_connection=true";
        }

        public static void AddTimePunch(int id, string clockIn, string clockOut, string breakStart, string breakEnd)
        {
            using (SqlConnection conn = new(GetConnectionString()))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    //exec dbo.spTimePunches_AddTimePunch 2,'2023-06-08 12:35:29.123','2023-06-08 20:35:29.123', null, null
                    string commandString = $"exec dbo.spTimePunches_AddTimePunch {2},{clockIn},{clockOut}, {breakStart}, {breakEnd}";

                    cmd.CommandText = commandString;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public static bool IsUser(int id, int pass) 
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    //search contract manager database for matching username and password
                    string commandString = "SELECT ID, EmployeePass FROM dbo.Employees";
                    cmd.CommandText = commandString;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetInt32(0).Equals(id) && reader.GetInt32(1).Equals(pass))
                            {
                                conn.Close();
                                return true;
                            }
                        }
                    }
                    conn.Close();
                }
            }
            return false; 
        }
    }
}
