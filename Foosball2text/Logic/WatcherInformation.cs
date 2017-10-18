﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public struct WatcherInformation
    {
        //In BallWatcher
        public string X { get; set; }
        public string Y { get; set; }
        public string XYSpeed { get; set; }     //XY speed  
        public string OmniSpeed { get; set; }   //Omni-directional speed
        public FieldSide BallSide { get; set; }
        public string SecondsBetweenBallCapture { get; set; }

        //In GameWatcher
        public string MaxSpeedTeamOnLeft { get; set; }
        public string MaxSpeedTeamOnRight { get; set; }
        public string TeamOnLeftGoals { get; set; }
        public string TeamOnRightGoals { get; set; }
        public List<String> NewLogs { get; set; }
    }
}
