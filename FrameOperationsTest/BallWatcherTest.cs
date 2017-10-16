using Foosball2text;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace MovementCalculationsTest
{
    [TestClass]
    public class BallWatcherTest
    {
        //****************** Removed due to major changes
        //[TestMethod]
        //public void UpdateBallWatcher_BallHasMoved_Pass()
        //{
        //    Ball theBall = new Ball(50f, 50f);
        //    BallWatcher BWData = new BallWatcher(100f, 100f);

        //    theBall.ForcedMove(80f, 80f);   //Make theBall move
        //    BWData.UpdateBallWatcher();     //BW should notice the ball position changed

        //    if (BWData.PositionHasntChangedCount == 0)
        //        return;
        //    Assert.Fail("Position hasn't changed since the last update (" + BWData.PositionHasntChangedCount.ToString() + ")");
    }
}
