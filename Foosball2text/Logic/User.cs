using System;

namespace Logic
{
    public class User : IEquatable<User>
    {
        public string UserName { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public double MaxSpeed { get; set; }
        public int TotalGoals { get; set; }
        public int RankPoints { get; set; }

        public User() {}

        public User(string name)
        {
            UserName = name;
        }

        public User(string userName, int gamesPlayed, int gamesWon, double maxSpeed, int totalGoals, string allTimePlayed, int rankPoints) //Got data from SQL constructor
        {
            UserName = userName;
            GamesPlayed = gamesPlayed;
            GamesWon = gamesWon;
            MaxSpeed = maxSpeed;
            TotalGoals = totalGoals;
            RankPoints = rankPoints;
        }

        public void UpdateData(bool addGamePlayed, bool addGameWon, double gamesMaxSpeed, int addScore, TimeSpan gameTime , int rankChange)
        {
            GamesPlayed++;
            if (addGameWon)
                GamesWon++;
            if (gamesMaxSpeed > MaxSpeed)
                MaxSpeed = gamesMaxSpeed;
            TotalGoals += addScore;
            RankPoints += rankChange;
        }

        public bool Equals(User other)
        {
            return (UserName == other.UserName &&
                GamesPlayed == other.GamesPlayed &&
                GamesWon == other.GamesWon &&
                MaxSpeed == other.MaxSpeed &&
                TotalGoals == other.TotalGoals &&
                RankPoints == other.RankPoints);
        }
    }
}
