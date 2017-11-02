using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace Test
{
    [TestClass]
    public class LoggerMessageDeliveryTests
    {
        [TestMethod]
        public void GetPassMessage()
        {
            LoggerMessageDelivery testLogger = new LoggerMessageDelivery();
            Assert.AreEqual(testLogger.getPassMessage("test"), "Ball has been passed to test");
        }
        [TestMethod]
        public void GetDisappearMessage()
        {
            LoggerMessageDelivery testLogger = new LoggerMessageDelivery();
            Assert.AreEqual(testLogger.getDisappearMessage("test"), "test has dissapeared");
        }
        [TestMethod]
        public void GetScoreMessage()
        {
            LoggerMessageDelivery testLogger = new LoggerMessageDelivery();
            Assert.AreEqual(testLogger.getScoreMessage(100, 200), "Score is: Team A: 100; Team B: 200");
        }
    }
}
