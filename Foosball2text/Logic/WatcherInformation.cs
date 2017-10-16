using System;
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
        public string Speed { get; set; }
        public string OmniSpeed { get; set; } //Overall speed
        public FieldSide BallSide { get; set; }
        public Teams TeamScored { get; set; }
        public string SecondsBetweenBallCapture { get; set; }

        //In GameWatcher
        public string MaxSpeed { get; set; }
    }
}
