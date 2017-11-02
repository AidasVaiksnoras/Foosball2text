using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;
using SQL_operations;

namespace Test
{
    [TestClass]
    public class DataProviderTests
    {
        /* Does not reflect how the code works
        [TestMethod]
        public void AddNewUserToList()
        {
            UsersDataProvider testDataProvider = new UsersDataProvider();
            testDataProvider.AddUser("User1");
            Assert.AreEqual(1, testDataProvider.UserList.Count);
            Assert.AreEqual("User1", testDataProvider.UserList[0].UserName);
        }

        [TestMethod]
        public void WontAddExistingUser()
        {
            UsersDataProvider testDataProvider = new UsersDataProvider();
            testDataProvider.AddUser("User1");
            Assert.AreEqual(1, testDataProvider.UserList.Count);
            Assert.AreEqual("User1", testDataProvider.UserList[0].UserName);
            User returnedUser = testDataProvider.AddUser("User1");
            Assert.AreEqual("User1", returnedUser.UserName);
            Assert.AreEqual(1, testDataProvider.UserList.Count);
            Assert.AreEqual("User1", testDataProvider.UserList[0].UserName);
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
        [ExpectedException(typeof(UserNotFoundException))]
        public void GetNotExistingUserInfo()
        {
            UsersDataProvider testDataProvider = new UsersDataProvider();
            testDataProvider.AddUser("User1");
            User returnedUser = testDataProvider.GetUserData("User2");
            Assert.IsNull(returnedUser.UserName);
        }
        */
    }
}
