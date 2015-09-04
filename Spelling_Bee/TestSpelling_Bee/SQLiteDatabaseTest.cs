using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TestSpelling_Bee
{
    
    
    /// <summary>
    ///This is a test class for SQLiteDatabaseTest and is intended
    ///to contain all SQLiteDatabaseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SQLiteDatabaseTest
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
        ///A test for SQLiteDatabase Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void SQLiteDatabaseConstructorTest()
        {
            SQLiteDatabase_Accessor target = new SQLiteDatabase_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ExecuteNonQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void ExecuteNonQueryTest()
        {
            SQLiteDatabase_Accessor target = new SQLiteDatabase_Accessor(); // TODO: Initialize to an appropriate value
            string sql = string.Empty; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.ExecuteNonQuery(sql);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExecuteScalar
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void ExecuteScalarTest()
        {
            SQLiteDatabase_Accessor target = new SQLiteDatabase_Accessor(); // TODO: Initialize to an appropriate value
            string sql = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ExecuteScalar(sql);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetDataTable
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void GetDataTableTest()
        {
            SQLiteDatabase_Accessor target = new SQLiteDatabase_Accessor(); // TODO: Initialize to an appropriate value
            string sql = string.Empty; // TODO: Initialize to an appropriate value
            DataTable expected = null; // TODO: Initialize to an appropriate value
            DataTable actual;
            actual = target.GetDataTable(sql);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
