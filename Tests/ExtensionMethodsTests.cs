using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestListExtension
    {
        [TestMethod]
        public void Test_OrderByTotalScore()
        {
            List<UserNONMODEL> testList = new List<UserNONMODEL>
            {
                new UserNONMODEL { UserName = "user1", TotalGoals = 1 },
                new UserNONMODEL { UserName = "user2", TotalGoals = 3 },
                new UserNONMODEL { UserName = "user3", TotalGoals = 2 }
            };
            List<UserNONMODEL> actual = testList.OrderByTotalScore();
            Assert.AreEqual(actual[0].UserName, "user2");
            Assert.AreEqual(actual[1].UserName, "user3");
            Assert.AreEqual(actual[2].UserName, "user1");
        }

        [TestMethod]
        public void Test_OrderByGamesWon()
        {
            List<UserNONMODEL> testList = new List<UserNONMODEL>
            {
                new UserNONMODEL { UserName = "user1", GamesWon = 1 },
                new UserNONMODEL { UserName = "user2", GamesWon = 3 },
                new UserNONMODEL { UserName = "user3", GamesWon = 2 }
            };
            List<UserNONMODEL> actual = testList.OrderByGamesWon();
            Assert.AreEqual(actual[0].UserName, "user2");
            Assert.AreEqual(actual[1].UserName, "user3");
            Assert.AreEqual(actual[2].UserName, "user1");
        }

        [TestMethod]
        public void Test_OrderByGamesPlayed()
        {
            List<UserNONMODEL> testList = new List<UserNONMODEL>
            {
                new UserNONMODEL { UserName = "user1", GamesPlayed = 1 },
                new UserNONMODEL { UserName = "user2", GamesPlayed = 3 },
                new UserNONMODEL { UserName = "user3", GamesPlayed = 2 }
            };
            List<UserNONMODEL> actual = testList.OrderByGamesPlayed();
            Assert.AreEqual(actual[0].UserName, "user2");
            Assert.AreEqual(actual[1].UserName, "user3");
            Assert.AreEqual(actual[2].UserName, "user1");
        }

        [TestMethod]
        public void Test_OrderByMaxSpeed()
        {
            List<UserNONMODEL> testList = new List<UserNONMODEL>
            {
                new UserNONMODEL { UserName = "user1", MaxSpeed = 1 },
                new UserNONMODEL { UserName = "user2", MaxSpeed = 3 },
                new UserNONMODEL { UserName = "user3", MaxSpeed = 2 }
            };
            List<UserNONMODEL> actual = testList.OrderByMaxSpeed();
            Assert.AreEqual(actual[0].UserName, "user2");
            Assert.AreEqual(actual[1].UserName, "user3");
            Assert.AreEqual(actual[2].UserName, "user1");
        }
    }
}
