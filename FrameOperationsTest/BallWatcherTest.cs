using Foosball2text;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MovementCalculationsTest
{
    [TestClass]
    public class BallWatcherTest
    {
        [TestMethod]
        public void UpdateBallWatcher_BallHasMoved_Pass()
        {
            Ball theBall = new Ball(50f, 50f, new Emgu.CV.Structure.CircleF());
            BallWatcher BWData = new BallWatcher(ref theBall, 100f, 100f);

            theBall.ForcedMove(80f, 80f);   //Make theBall move
            BWData.UpdateBallWatcher();     //BW should notice the ball position changed

            if (BWData.PositionHasntChangedCount == 0)
                return;
            Assert.Fail("Position hasn't changed since the last update (" + BWData.PositionHasntChangedCount.ToString() + ")");
        }

        [TestMethod]
        // Same as above but ball doesn't move
        public void UpdateBallWatcher_BallHasMoved_Fail()
        {
            Ball theBall = new Ball(50f, 50f, new Emgu.CV.Structure.CircleF());
            BallWatcher BWData = new BallWatcher(ref theBall, 100f, 100f);

            //Ball doesn't move
            BWData.UpdateBallWatcher(); //Call for update

            if (BWData.PositionHasntChangedCount == 0)
                return;
            Assert.Fail("Position hasn't changed since the last update (" + BWData.PositionHasntChangedCount.ToString() + ")");
        }
    }
}
