using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQL_operations
{
    public class WriteOperations
    {
        public void InsertNewUser(string newUsersName)
        {
            if (!UserExists(newUsersName))
                try
                {
                    using (SqlConnection connection = ConnectionProvider.GetConnection())
                    {
                        connection.Open();
                        StringBuilder sb = new StringBuilder();
                        sb.Append("INSERT Users (Username) ");
                        sb.Append("VALUES (");
                        sb.Append("'" + newUsersName + "'");
                        sb.Append(");");
                        string sql = sb.ToString();

                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (FormatException e)
                {
                    new ExceptionForm(e.ToString()).Show();
                }
                catch (SqlException e)
                {
                    new ExceptionForm(e.ToString()).Show();
                }
        }

        public void UpdateUserPlayData(User userToUpdate)
        {
            try
            {
                using (SqlConnection connection = ConnectionProvider.GetConnection())
                {
                    connection.Open();
                    
                    StringBuilder sb = new StringBuilder();
                    sb.Append("UPDATE Users SET");
                    sb.Append(" GamesPlayed = " + userToUpdate.GamesPlayed);
                    sb.Append(", GamesWon = " + userToUpdate.GamesWon);
                    sb.Append(", TotalGoals = " + userToUpdate.TotalGoals);
                    sb.Append(", MaxSpeed = " + userToUpdate.MaxSpeed);
                    string dateTimeStr = userToUpdate.AllTimePlayedISO8601;
                    if (!CorrectDateTimeFormat(dateTimeStr))
                        throw new FormatException(dateTimeStr);
                    sb.Append(", TimePlayed = '" + dateTimeStr + "'");
                    sb.Append(", RankPoints = " + userToUpdate.RankPoints);

                    sb.Append(" WHERE Username = '" + userToUpdate.UserName + "';");
                    string sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (FormatException e)
            {
                new ExceptionForm(e.ToString()).Show();
            }
            catch (SqlException e)
            {
                new ExceptionForm(e.ToString()).Show();
            }
        }

        public static bool CorrectDateTimeFormat(string dateTimeString)
        {
            return Regex.IsMatch(dateTimeString,
                @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}Z$");
        }

        public bool UserExists(string username)
        {
            try
            {
                using (SqlConnection connection = ConnectionProvider.GetConnection())
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT Username ");
                    sb.Append("FROM Users ");
                    sb.Append("WHERE Username = '" + username + "'");
                    sb.Append(";");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string foundUserName = reader[0].ToString();
                                if (foundUserName != null)
                                    return true;
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                new ExceptionForm(e.ToString()).Show();
            }

            return false;
        }

    }
}
