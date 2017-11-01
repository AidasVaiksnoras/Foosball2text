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
        public List<User> GetAllUserData()
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
                                emptyUser.UserName = reader.GetString(0);
                                emptyUser.GamesPlayed = reader.GetInt32(1);
                                emptyUser.GamesWon = reader.GetInt32(2);
                                emptyUser.TotalGoals = reader.GetInt32(3);
                                emptyUser.MaxSpeed = reader.GetDouble(4);
                                string timePassedString = reader.GetString(5);
                                emptyUser.AllTimePlayed = new TimePassed(timePassedString);
                                emptyUser.RankPoints = reader.GetInt32(6);
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

        public User GetUsersData(string username)
        {
            try
            {
                using (SqlConnection connection = ConnectionProvider.GetConnection())
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * ");
                    sb.Append("FROM Users ");
                    sb.Append("WHERE Username = '" + username + "'");
                    sb.Append(";");
                    String sql = sb.ToString();

                    //TODO add multiple found exception
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User foundUser = new User();
                                foundUser.UserName = reader.GetString(0);
                                foundUser.GamesPlayed = reader.GetInt32(1);
                                foundUser.GamesWon = reader.GetInt32(2);
                                foundUser.TotalGoals = reader.GetInt32(3);
                                foundUser.MaxSpeed = reader.GetDouble(4);
                                string timePassedString = reader.GetString(5);
                                foundUser.AllTimePlayed = new TimePassed(timePassedString);
                                foundUser.RankPoints = reader.GetInt32(6);
                                return foundUser;
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                new ExceptionForm(e.ToString()).Show();
            }

            return null;
        }

    }
}
