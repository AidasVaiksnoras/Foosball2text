using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foosball2text
{
    class VideoLoggerMessageDelivery
    {
        public readonly string gameStart = "*** Start of the game ***";
        public readonly string gameEnd = "*** End of the game ***";
        public readonly string goalLeft = "Left team has scored!";
        public readonly string goalRight = "Right team has scored!";
        public readonly string dissapearedBall = "Ball has dissapeared";
        private readonly string pass = "Ball has been passed to ";
        private readonly string dissapearedString = " has dissapeared";

        public string getPassMessage(String passedTo)
        {
            return pass + passedTo;
        }

        public string getDisappearMessage(String disappearedObjName)
        {
            return disappearedObjName + dissapearedString;
        }
    }
}
