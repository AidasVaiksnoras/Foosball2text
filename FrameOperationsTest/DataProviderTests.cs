using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
namespace FrameOperationsTest
{
    [TestClass]
    public class DataProviderTests
    {
        [TestMethod]
        public void AddNewUserToList()
        {
            UsersDataProvider testDataProvider = new UsersDataProvider();
            testDataProvider.AddUser("User1");
            Assert.AreEqual(1, testDataProvider.Data.Count);
            Assert.AreEqual("User1", testDataProvider.Data[0].UserName);
        }

        [TestMethod]
        public void WontAddExistingUser()
        {
            UsersDataProvider testDataProvider = new UsersDataProvider();
            testDataProvider.AddUser("User1");
            Assert.AreEqual(1, testDataProvider.Data.Count);
            Assert.AreEqual("User1", testDataProvider.Data[0].UserName);
            User returnedUser = testDataProvider.AddUser("User1");
            Assert.AreEqual("User1", returnedUser.UserName);
            Assert.AreEqual(1, testDataProvider.Data.Count);
            Assert.AreEqual("User1", testDataProvider.Data[0].UserName);
        }

        [TestMethod]
        public void GetExistingUserInfo()
        {
            UsersDataProvider testDataProvider = new UsersDataProvider();
            testDataProvider.AddUser("User1");
            User returnedUser = testDataProvider.GetUserData("User1");
            Assert.AreEqual("User1", returnedUser.UserName);
        }

        [TestMethod]
        public void GetNotExistingUserInfo()
        {
            UsersDataProvider testDataProvider = new UsersDataProvider();
            testDataProvider.AddUser("User1");
            User returnedUser = testDataProvider.GetUserData("User2");
            Assert.IsNull(returnedUser.UserName);
        }
    }
}
