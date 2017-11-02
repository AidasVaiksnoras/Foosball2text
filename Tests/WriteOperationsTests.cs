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
            Assert.Fail();
        }

        [TestMethod()]
        public void CorrectDateTimeFormatTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UserExistsTest()
        {
            Assert.Fail();
        }
    }
}