using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_operations
{
    public class ReadOperations
    {
        public static List<User> getAllUserData()
        {
            List<User> data = new List<User>(); //data to be returned

            try
            {
                using (SqlConnection connection = ConnectionProvider.GetConnection())
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * ");
                    sb.Append("FROM Users ");
                    sb.Append(";");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User emptyUser = new User();
                                emptyUser.UserName = reader.GetString(1);
                                emptyUser.GamesPlayed = reader.GetInt32(2);
                                emptyUser.GamesWon = reader.GetInt32(3);
                                emptyUser.TotalScore = reader.GetInt32(4);
                                emptyUser.MaxSpeed = reader.GetDouble(5);
                                //emptyUser.TimePlayed = reader[6].***
                                //emptyUser.RankPoints = reader[7].***
                                data.Add(emptyUser);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                new ExceptionForm(e.ToString()).Show();
            }

            return data;
        }
    }
}
