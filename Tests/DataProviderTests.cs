using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Logic;

namespace Test
{
    [TestClass]
    public class DataProviderTests
    {
        [TestMethod]
        public void GetNotExistingUserInfo()
        {
            UsersDataProvider testDataProvider = new UsersDataProvider();
            User testUser = new User();
            testUser.UserName = "User1";
            testDataProvider.UserList = new List<User>();
            testDataProvider.UserList.Add(testUser);
            bool exceptionThrown = false;
            try
            {
                User returnedUser = testDataProvider.GetUserData("User");
            }
            catch (UserNotFoundException e)
            {
                exceptionThrown = true;
            }
            Assert.IsTrue(exceptionThrown);
        }

        [TestMethod]
        public void GetExistingUserInfo()
        {
            UsersDataProvider testDataProvider = new UsersDataProvider();
            User testUser = new User();
            testUser.UserName = "User1"; ;
            testDataProvider.UserList = new List<User>();
            testDataProvider.UserList.Add(testUser);
            User returnedUser = testDataProvider.GetUserData("User1");
            Assert.AreEqual(testUser.UserName, returnedUser.UserName);
        }
    }
}
