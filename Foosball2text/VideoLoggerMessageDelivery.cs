using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foosball2text
{
    class VideoLoggerMessageDelivery
    {
        public const string gameStart = "*** Start of the game ***";
        public const string gameEnd = "*** End of the game ***";
        public const string goalLeft = "Left team has scored!";
        public const string goalRight = "Right team has scored!";
        public const string dissapearedBall = "Ball has dissapeared";
        private const string pass = "Ball has been passed to ";
        private const string dissapearedString = " has dissapeared";

        static public string getPassMessage(String passedTo)
        {
            return pass + passedTo;
        }

        static public string getDisappearMessage(String disappearedObjName)
        {
            return disappearedObjName + dissapearedString;
        }
    }
}
