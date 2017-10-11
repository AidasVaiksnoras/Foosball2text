using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public struct BallInformation
    {
        public string X { get; set; }
        public string Y { get; set; }
        public FieldSide BallSide { get; set; }
        public string Speed { get; set; }
        public Teams TeamScored { get; set; }

        public BallInformation(string x, string y, FieldSide ballSide, string speed, Teams teamScored)
        {
            X = x;
            Y = y;
            BallSide = ballSide;
            Speed = speed;
            TeamScored = teamScored;
        }
    }
}
