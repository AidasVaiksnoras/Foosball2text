using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System.Collections.Generic;
using SQL_operations;

namespace Test
{
    [TestClass]
    public class TestListExtension
    {
        [TestMethod]
        public void Test_OrderByTotalScore()
        {
            List<User> testList = new List<User>
            {
                new User { UserName = "user1", TotalGoals = 1 },
                new User { UserName = "user2", TotalGoals = 3 },
                new User { UserName = "user3", TotalGoals = 2 }
            };
            List<User> actual = testList.OrderByTotalScore();
            Assert.AreEqual(actual[0].UserName, "user2");
            Assert.AreEqual(actual[1].UserName, "user3");
            Assert.AreEqual(actual[2].UserName, "user1");
        }

        [TestMethod]
        public void Test_OrderByGamesWon()
        {
            List<User> testList = new List<User>
            {
                new User { UserName = "user1", GamesWon = 1 },
                new User { UserName = "user2", GamesWon = 3 },
                new User { UserName = "user3", GamesWon = 2 }
            };
            List<User> actual = testList.OrderByGamesWon();
            Assert.AreEqual(actual[0].UserName, "user2");
            Assert.AreEqual(actual[1].UserName, "user3");
            Assert.AreEqual(actual[2].UserName, "user1");
        }

        [TestMethod]
        public void Test_OrderByGamesPlayed()
        {
            List<User> testList = new List<User>
            {
                new User { UserName = "user1", GamesPlayed = 1 },
                new User { UserName = "user2", GamesPlayed = 3 },
                new User { UserName = "user3", GamesPlayed = 2 }
            };
            List<User> actual = testList.OrderByGamesPlayed();
            Assert.AreEqual(actual[0].UserName, "user2");
            Assert.AreEqual(actual[1].UserName, "user3");
            Assert.AreEqual(actual[2].UserName, "user1");
        }

        [TestMethod]
        public void Test_OrderByMaxSpeed()
        {
            List<User> testList = new List<User>
            {
                new User { UserName = "user1", MaxSpeed = 1 },
                new User { UserName = "user2", MaxSpeed = 3 },
                new User { UserName = "user3", MaxSpeed = 2 }
            };
            List<User> actual = testList.OrderByMaxSpeed();
            Assert.AreEqual(actual[0].UserName, "user2");
            Assert.AreEqual(actual[1].UserName, "user3");
            Assert.AreEqual(actual[2].UserName, "user1");
        }
    }
}
