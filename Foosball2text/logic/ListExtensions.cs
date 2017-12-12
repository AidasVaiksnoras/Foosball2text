using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class ListExtensions
    {
        public static List<User> OrderByGamesWon(this List<User> list)
        {
            return list.OrderByDescending(x => x.GamesWon).ToList();
        }

        public static List<User> OrderByTotalScore(this List<User> list)
        {
            return list.OrderByDescending(x => x.TotalGoals).ToList();
        }

        public static List<User> OrderByMaxSpeed(this List<User> list)
        {
            return list.OrderByDescending(x => x.MaxSpeed).ToList();
        }

        public static List<User> OrderByGamesPlayed(this List<User> list)
        {
            return list.OrderByDescending(x => x.GamesPlayed).ToList();
        }
    }
}
