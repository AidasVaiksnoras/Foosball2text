using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Helpers.Tests
{
    [TestClass()]
    public class DataProviderEFTests
    {
        DataProviderEF DataProviderEF = new DataProviderEF();

        [TestMethod()]
        public void GetCurrentGameTest_ExceptionThrown()
        {
            //UNDONE wrong exceptions thrown
            try
            {
                DataProviderEF.GetCurrentGame("", "");
                Assert.Fail("No exception thrown when passing empty team names");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(true, "Exception thrown is: " + ex.ToString());
            }
        }
    }
}