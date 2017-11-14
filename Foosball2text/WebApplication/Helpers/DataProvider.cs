using System.Data.SqlClient;
using System.Text;
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
                            game.LeftScore = reader.GetInt32(4);
                            return game;
                        }
                    }
                }
                return new Game();
            }
        }
    }
}