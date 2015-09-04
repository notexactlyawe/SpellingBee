using Spelling_Bee;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestSpelling_Bee
{
    
    
    /// <summary>
    ///This is a test class for formTestAddTest and is intended
    ///to contain all formTestAddTest Unit Tests
    ///</summary>
    [TestClass()]
    public class formTestAddTest
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
        ///A test for formTestAdd Constructor
        ///</summary>
        [TestMethod()]
        public void formTestAddConstructorTest()
        {
            string teclass = string.Empty; // TODO: Initialize to an appropriate value
            formTestAdd target = new formTestAdd(teclass);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void DisposeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void InitializeComponentTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnAdd_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void btnAdd_ClickTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnAdd_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnClear_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void btnClear_ClickTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnClear_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnDelete_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void btnDelete_ClickTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnDelete_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnRand_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void btnRand_ClickTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnRand_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnSave_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void btnSave_ClickTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnSave_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnWordAdd_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void btnWordAdd_ClickTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnWordAdd_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for lblDesc_DoubleClick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void lblDesc_DoubleClickTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.lblDesc_DoubleClick(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for lstResults_SelectedIndexChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void lstResults_SelectedIndexChangedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.lstResults_SelectedIndexChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for lstTest_SelectedIndexChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void lstTest_SelectedIndexChangedTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.lstTest_SelectedIndexChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for txtDesc_KeyDown
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void txtDesc_KeyDownTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            KeyEventArgs e = null; // TODO: Initialize to an appropriate value
            target.txtDesc_KeyDown(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for txtSearch_KeyUp
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Spelling_Bee.exe")]
        public void txtSearch_KeyUpTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            formTestAdd_Accessor target = new formTestAdd_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            KeyEventArgs e = null; // TODO: Initialize to an appropriate value
            target.txtSearch_KeyUp(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
