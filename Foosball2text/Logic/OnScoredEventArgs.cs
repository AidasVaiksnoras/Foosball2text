﻿using System;
using WebApplication.Models;

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
