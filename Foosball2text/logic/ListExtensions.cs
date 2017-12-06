using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class ListExtensions
    {
        public static List<UserNONMODEL> OrderByGamesWon(this List<UserNONMODEL> list)
        {
            return list.OrderByDescending(x => x.GamesWon).ToList();
        }

        public static List<UserNONMODEL> OrderByTotalScore(this List<UserNONMODEL> list)
        {
            return list.OrderByDescending(x => x.TotalGoals).ToList();
        }

        public static List<UserNONMODEL> OrderByMaxSpeed(this List<UserNONMODEL> list)
        {
            return list.OrderByDescending(x => x.MaxSpeed).ToList();
        }

        public static List<UserNONMODEL> OrderByGamesPlayed(this List<UserNONMODEL> list)
        {
            return list.OrderByDescending(x => x.GamesPlayed).ToList();
        }
    }
}
