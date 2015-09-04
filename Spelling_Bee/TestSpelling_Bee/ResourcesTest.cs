using Spelling_Bee.Properties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestSpelling_Bee
{
    
    
    /// <summary>
    ///This is a test class for ResourcesTest and is intended
    ///to contain all ResourcesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ResourcesTest
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
        ///A test for Resources Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void ResourcesConstructorTest()
        {
            // Private Accessor for Spelling_Bee.Properties.Resources is not found. Please rebuild the containing project or run the Publicize.exe manually.
            Assert.Inconclusive("Private Accessor for Spelling_Bee.Properties.Resources is not found. Please rebui" +
                    "ld the containing project or run the Publicize.exe manually.");
        }

        /// <summary>
        ///A test for Culture
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void CultureTest()
        {
            // Private Accessor for Spelling_Bee.Properties.Resources is not found. Please rebuild the containing project or run the Publicize.exe manually.
            Assert.Inconclusive("Private Accessor for Spelling_Bee.Properties.Resources is not found. Please rebui" +
                    "ld the containing project or run the Publicize.exe manually.");
        }

        /// <summary>
        ///A test for ResourceManager
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void ResourceManagerTest()
        {
            // Private Accessor for Spelling_Bee.Properties.Resources is not found. Please rebuild the containing project or run the Publicize.exe manually.
            Assert.Inconclusive("Private Accessor for Spelling_Bee.Properties.Resources is not found. Please rebui" +
                    "ld the containing project or run the Publicize.exe manually.");
        }
    }
}
