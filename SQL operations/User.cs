using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_operations
{
    public class User
    {
        public string UserName { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public double MaxSpeed { get; set; }
        public int TotalScore { get; set; }

        public User()
        {
        }

        public User(string name)
        {
            UserName = name;
        }

        public void UpdateData(bool addGamePlayed, bool addGameWon, double gamesMaxSpeed, int addScore)
        {
            if (addGamePlayed)
                GamesPlayed++;
            if (addGameWon)
                GamesWon++;
            if (gamesMaxSpeed > MaxSpeed)
                MaxSpeed = gamesMaxSpeed;
            TotalScore += addScore;
        }
    }
}
