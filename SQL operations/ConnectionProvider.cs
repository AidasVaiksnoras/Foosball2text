using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SQL_operations
{
    public class ConnectionProvider
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = Properties.Settings.Default.DatabaseConnectionString;
            return new SqlConnection(connectionString);
        }

    }
}
