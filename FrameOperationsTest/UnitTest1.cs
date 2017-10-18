using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using System.Collections.Generic;
namespace FrameOperationsTest
{
    [TestClass]
    public class TestListExtension
    {

        [TestMethod]
        public void TestOrderByTotalScore()
        {
            List<User> testList = new List<User>();
            testList.Add(new User { UserName = "user1", TotalScore = 1 });
            testList.Add(new User { UserName = "user2", TotalScore = 3 });
            testList.Add(new User { UserName = "user3", TotalScore = 2 });
            List<User> actual = testList.OrderByTotalScore();
            Assert.AreEqual(actual[0].UserName, "user2");
            Assert.AreEqual(actual[1].UserName, "user3");
            Assert.AreEqual(actual[2].UserName, "user1");
        }
    }
}
