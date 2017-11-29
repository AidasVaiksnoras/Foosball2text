using System;

namespace Logic
{
    public class OnScoredEventArgs : EventArgs
    {
        public GameEntity Game { get; set; }

        public OnScoredEventArgs(GameEntity game)
        {
            Game = game;
        }
    }
}
