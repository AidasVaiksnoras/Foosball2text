using System;

namespace Logic
{
    public class User : IEquatable<User>
    {
        public string UserName { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int TotalGoals { get; set; }
        public double MaxSpeed { get; set; }
        TimeSpan TimePlayed { get; set; }
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
            TotalGoals = totalGoals;
            MaxSpeed = maxSpeed;
            //UNDONE TimePlayed saving not implemented
            RankPoints = rankPoints;
        }

        public void UpdateData(bool addGameWon, double gamesMaxSpeed, int addScore, GameTime gameTime)
        {
            GamesPlayed++;
            if (addGameWon)
                GamesWon++;
            if (gamesMaxSpeed > MaxSpeed)
                MaxSpeed = gamesMaxSpeed;
            TotalGoals += addScore;
            TimeSpan gameTimeSpan = new TimeSpan(0, gameTime.min, gameTime.sec);
            TimePlayed += gameTimeSpan;
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
