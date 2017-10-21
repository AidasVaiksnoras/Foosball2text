using System;
using System.Collections.Generic;

namespace Logic
{
    public struct WatcherInformation
    {
        //In BallWatcher
        public float X { get; set; }
        public float Y { get; set; }
        public double XSpeed { get; set; }
        public double YSpeed { get; set; }
        public double OmniSpeed { get; set; }   //Omni-directional speed
        public FieldSide BallSide { get; set; }
        public double SecondsBetweenBallCapture { get; set; }

        //In GameWatcher
        public double MaxSpeedTeamOnLeft { get; set; }
        public double MaxSpeedTeamOnRight { get; set; }
        public int TeamOnLeftGoals { get; set; }
        public int TeamOnRightGoals { get; set; }
        public List<String> NewLogs { get; set; }
    }
}
