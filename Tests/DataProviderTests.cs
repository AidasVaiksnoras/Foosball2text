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
            UserNONMODEL testUser = new UserNONMODEL();
            testUser.UserName = "User1";
            testDataProvider.UserList = new List<UserNONMODEL>();
            testDataProvider.UserList.Add(testUser);
            bool exceptionThrown = false;
            try
            {
                UserNONMODEL returnedUser = testDataProvider.GetUserData("User");
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
            UserNONMODEL testUser = new UserNONMODEL();
            testUser.UserName = "User1"; ;
            testDataProvider.UserList = new List<UserNONMODEL>();
            testDataProvider.UserList.Add(testUser);
            UserNONMODEL returnedUser = testDataProvider.GetUserData("User1");
            Assert.AreEqual(testUser.UserName, returnedUser.UserName);
        }
    }
}
