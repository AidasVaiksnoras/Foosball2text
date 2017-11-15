using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class OnScoredEventArgs : EventArgs
    {
        public Game Game { get; set; }

        public OnScoredEventArgs(Game game)
        {
            Game = game;
        }
    }
}
