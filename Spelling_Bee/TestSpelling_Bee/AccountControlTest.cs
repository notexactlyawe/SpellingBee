using Spelling_Bee;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSpelling_Bee
{
    
    
    /// <summary>
    ///This is a test class for AccountControlTest and is intended
    ///to contain all AccountControlTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AccountControlTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for AccountControl Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void AccountControlConstructorTest()
        {
            AccountControl_Accessor target = new AccountControl_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for addStudent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void addStudentTest()
        {
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string pass = string.Empty; // TODO: Initialize to an appropriate value
            string stuClass = string.Empty; // TODO: Initialize to an appropriate value
            AccountControl_Accessor.addStudent(name, pass, stuClass);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for checkAccount
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void checkAccountTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            string pass = string.Empty; // TODO: Initialize to an appropriate value
            string stuteach = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = AccountControl_Accessor.checkAccount(id, pass, stuteach);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for deleteAccount
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void deleteAccountTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            string stuteach = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = AccountControl_Accessor.deleteAccount(id, stuteach);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
