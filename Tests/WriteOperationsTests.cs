using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQL_operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_operations.Tests
{
    [TestClass()]
    public class WriteOperationsTests
    {
        WriteOperations wo = new WriteOperations();

        [TestMethod]
        public void InsertNewUserTest()
        {
            string newUserName = "UnitTest NewUser";

            wo.InsertNewUser(newUserName);

            ReadOperations ro = new ReadOperations();
            User InsertedUser = ro.GetUsersData(newUserName);

            Assert.IsNotNull(InsertedUser);
        }

        [TestMethod()]
        public void UpdateUserPlayDataTest()
        {
            string userName = "UnitTest Inserted to be updated";

            wo.InsertNewUser(userName);

            ReadOperations ro = new ReadOperations();
            User oldDataUser = ro.GetUsersData(userName);

            Random rng = new Random(); //Used to generate new/unused user data
            User newDataUser = new User(userName, rng.Next(0,999), rng.Next(0, 999), 5.55, rng.Next(0, 5000), "0000-00-00T00:22:34Z", rng.Next(0, 5000));
            wo.UpdateUserPlayData(newDataUser);

            User updatedDataUser = ro.GetUsersData(userName);

            Assert.AreNotEqual(oldDataUser, updatedDataUser);
        }

        [TestMethod()]
        public void CorrectDateTimeFormatTest_FalseTimeFormats()
        {
            if (WriteOperations.CorrectDateTimeFormat("T10:10:10Z"))
                Assert.Fail();
            if (WriteOperations.CorrectDateTimeFormat("'2016-10-21T10:10:10Z"))
                Assert.Fail();
            if (WriteOperations.CorrectDateTimeFormat(@"'2016-10-21T10:10:10Z'"))
                Assert.Fail();
            if (WriteOperations.CorrectDateTimeFormat(@"2016-10-21T10:10:10Z'"))
                Assert.Fail();
            if (WriteOperations.CorrectDateTimeFormat("2016-10-21T10:10:10Z;"))
                Assert.Fail();
            Assert.IsTrue(WriteOperations.CorrectDateTimeFormat("2016-10-21T10:10:10Z"));
        }
    }
}