using Microsoft.VisualStudio.TestTools.UnitTesting;
using C969___Scheduling_Software;
using System;

namespace Grimoire_Unit_Tests
{
    [TestClass]
    public class GrimoireTests
    {
        mySQLDB mySQLDB = new mySQLDB();
        string user = "test";
        string pass = "test";
        int expectedUserId = 1;
        int returnedUserId = 0;
        Exception exception;

        [TestMethod]
        public void TestValidLogin() //Will test that when supplied with valid credentials the login window will appropriately provide access to the application
        {
            try
            {
                returnedUserId = mySQLDB.LoginDBUser(user, pass);
            }
            catch (Exception e)
            {
                exception = e;
            }
            Assert.AreEqual(expectedUserId, returnedUserId); //Credentials supplied map to userId 1 in the database, so we expect the return from the login method to be 1
            Assert.IsNull(exception); //It should not throw an exception
        }
    }
}
