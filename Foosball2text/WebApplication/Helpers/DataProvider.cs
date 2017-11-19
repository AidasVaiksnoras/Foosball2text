using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using WebApplication.Models;

namespace WebApplication.Helpers
{
    public class DataProvider
    {
        public void InsertNewGame(Game game)
        {
            using (SqlConnection connection = ConnectionProvider.GetConnection())
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT dbo.CurrentGame (LeftUserName, RightUserName, LeftScore, RightScore)");
                sb.Append("VALUES (");
                sb.Append("'" + game.LeftUserName + "', '" + game.RightUserName + "', " + game.LeftScore + ", " + game.RightScore + "");
                sb.Append(");");
                string sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateGame(Game game)
        {
            using (SqlConnection connection = ConnectionProvider.GetConnection())
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("Update CurrentGame ");
                sb.Append("SET LeftScore = " + game.LeftScore + ", RightScore = " + game.RightScore );
                sb.Append(" Where (Id = (SELECT TOP 1 Id FROM CurrentGame ORDER BY Id DESC))");
                string sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public Game GetCurrentGameData()
        {
            using (SqlConnection connection = ConnectionProvider.GetConnection())
            {
                connection.Open();
                string sql = "SELECT TOP 1 * FROM CurrentGame ORDER BY Id DESC";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Game game = new Game();
                            game.LeftUserName = reader.GetString(1);
                            game.RightUserName = reader.GetString(2);
                            game.LeftScore = reader.GetInt32(3);
                            game.RightScore = reader.GetInt32(4);
                            return game;
                        }
                    }
                }
                throw new EmptyGameListExeption();
            }
        }

        public void InsertUser(User user)
        {
            if (!UserExists(user.UserName))
                using (SqlConnection connection = ConnectionProvider.GetConnection())
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT Users (Username) ");
                    sb.Append("VALUES (");
                    sb.Append("'" + user.UserName + "'");
                    sb.Append(");");
                    string sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
        }

        public void UpdateUser(User userToUpdate)
        {
            using (SqlConnection connection = ConnectionProvider.GetConnection())
            {
                connection.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Users SET");
                sb.Append(" GamesPlayed = " + userToUpdate.GamesPlayed);
                sb.Append(", GamesWon = " + userToUpdate.GamesWon);
                sb.Append(", TotalGoals = " + userToUpdate.TotalGoals);
                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberDecimalSeparator = ".";
                sb.Append(", MaxSpeed = " + Math.Round(userToUpdate.MaxSpeed, 6).ToString(nfi));
                sb.Append(", RankPoints = " + userToUpdate.RankPoints);
                sb.Append(" WHERE Username = '" + userToUpdate.UserName + "';");
                string sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool UserExists(string username)
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
                    command.CommandTimeout = 0;
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
            return false;
        }

        public List<User> GetUsers()
        {
            List<User> data = new List<User>();

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
                            emptyUser.RankPoints = reader.GetInt32(6);
                            data.Add(emptyUser);
                        }
                    }
                }
            }
            return data;
        }
    }
}