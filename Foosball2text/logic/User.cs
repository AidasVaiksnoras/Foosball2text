using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    [Serializable()]
    public class User
    {
        public string UserName { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int MaxSpeed { get; set; }
        public int TotalScore { get; set; }

        public User()
        {
        }

        public User(string name)
        {
            UserName = name;
        }
    }
}
