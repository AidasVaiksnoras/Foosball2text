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
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder("Server=tcp:universityprojects.database.windows.net,1433;Initial Catalog=foosball2text;Persist Security Info=False;User ID=warhatch;Password=Awalgato0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            return new SqlConnection(builder.ConnectionString);
        }
        

    }
}
