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
        public static void InsertNewUser(User userToInsert)
        {
            try
            {
                using (SqlConnection connection = ConnectionProvider.GetConnection())
                {
                    connection.Open();
                    //TODO check if not creating duplicate
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT Users (Username, GamesPlayed, GamesWon, TotalGoals, MaxSpeed, TimePlayed, RankPoints) ");
                    sb.Append("VALUES (");
                    sb.Append("'" + userToInsert.UserName + "'");
                    sb.Append(", " + userToInsert.GamesPlayed);
                    sb.Append(", " + userToInsert.GamesWon);
                    sb.Append(", " + userToInsert.TotalGoals);
                    sb.Append(", " + userToInsert.MaxSpeed);
                    //UNDONE temp values
                    string dateTimeStr = "0000-00-00T00:00:01Z"; //temp cange in seconds
                    if (!CorrectDateTimeFormat(dateTimeStr))
                        throw new FormatException(dateTimeStr);
                    sb.Append(", '" + dateTimeStr + "'");
                    sb.Append(", " + 0);

                    sb.Append(")");
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

        private static bool CorrectDateTimeFormat(string dateTimeString)
        {
            return Regex.IsMatch(dateTimeString,
                @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}Z$");
        }


    }
}
