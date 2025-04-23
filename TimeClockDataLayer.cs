using System.Data.SqlClient;



namespace TimePunch
{
    public static class TimeClockDataLayer
    {
        public static string getConnectionString()
        {
            return "data source=LAPTOP-4NOAT39B;initial catalog=LogIn;trusted_connection=true";
        }

        public static void addTimePunch(int id, string clockIn, string clockOut, string breakStart, string breakEnd)
        {
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
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



        public static bool isUser(int id, int pass) 
        {
            using (SqlConnection conn = new SqlConnection(getConnectionString()))
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

        /*
        public static void testMethod()
        {
            List<string> contents = new List<string>();

            using (SqlConnection conn = new SqlConnection(getConnectionString()))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    string commandString = "SELECT * FROM dbo.TimePunches";
                    cmd.CommandText = commandString;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {

                                if (reader[i] != null) {
                                    contents.Add(reader[i].ToString());
                                }
                            }//End of for loop
                        } //End of while loop

                        System.Diagnostics.Debug.WriteLine(contents);

                        foreach (string str in contents)
                        {
                            System.Diagnostics.Debug.WriteLine(str);
                        }
                    }
                    conn.Close();
                }
            }
        */
        }
















    }
}
