using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Globalization;
using WebApplication.Models;
using System.Linq;

namespace WebApplication.Helpers
{
    public class DataProvider
    {
        //string connectionStr = System.Configuration.ConfigurationManager.ConnectionStrings["EFModel"].ConnectionString;

        public void InsertNewGame(Game game)
        {
            using (var db = new EFModel())
            {
                db.Games.Add(game);
                db.SaveChanges();
            }
        }

        public Game FindGame(int Id) //TODO make sure Id and User'sName's is read only in logic
        {
            Game game;
            using (var db = new EFModel())
            {
                game = db.Games.Where(g => g.Id == Id).First();
            }

            return game;
        }

        public Game GetCurrentGame(string leftTeam, string rightTeam)
        {
            Game activeGame;
            using (var db = new EFModel())
            {
                activeGame = db.Games.Where(g => g.LeftUserName == leftTeam && g.RightUserName == rightTeam && g.InProgress == true).First();
            }

            return activeGame;
        }

        public Game FindGame() //TODO switch this to Table Adapter for efficiency?
        {
            Game game;
            using (var db = new EFModel())
            {
                var result = db.Games.ToList().Last();
                game = result;
            }

            return game;
        }

        public void UpdateGame(Game game)
        /// Updates InProgress and Scores
        {
            Game GameToUpdate = FindGame(game.Id);
            
            if (GameToUpdate != null)
            {
                GameToUpdate.InProgress = game.InProgress;
                GameToUpdate.LeftScore = game.LeftScore;
                GameToUpdate.RightScore = game.RightScore;
            }

            using (var db = new EFModel())
            {
                db.Entry(GameToUpdate).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
            }
        }

        //TODO: Change the other methods in places too
        public void InsertUser(User user)
        {
            if (!UserExists(user.Username))
                using (SqlConnection connection = ConnectionProvider.GetConnection())
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT Users (Username) ");
                    sb.Append("VALUES (");
                    sb.Append("'" + user.Username + "'");
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
                sb.Append(" WHERE Username = '" + userToUpdate.Username + "';");
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
                            emptyUser.Username = reader.GetString(0);
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