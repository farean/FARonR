using MyDashboard.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyDashboard.Model.Interfaces.Entities;
using System.Collections.Generic;

namespace MyDashboard.Model.Tests
{
    
    
    /// <summary>
    ///This is a test class for ProjectRepositoryTest and is intended
    ///to contain all ProjectRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProjectRepositoryTest
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
        ///A test for ProjectRepository Constructor
        ///</summary>
        [TestMethod()]
        public void ProjectRepositoryConstructorTest()
        {
            ProjectRepository target = new ProjectRepository();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }


        [TestMethod()]
        public void GetProjectbyIDTest_WhenValuesLessOrEqualtoZero_ShouldBeNull()
        {
            ProjectRepository target = new ProjectRepository(); // TODO: Initialize to an appropriate value
            int ID = 0; // TODO: Initialize to an appropriate value
            IProject expected = null; // TODO: Initialize to an appropriate value
            IProject actual;
            actual = target.GetProjectbyID(ID);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetProjectbyIDTest_WhenValuesGreaterThanZero_ShouldBeNotNull()
        {
            ProjectRepository target = new ProjectRepository(); // TODO: Initialize to an appropriate value
            int ID = 1; // TODO: Initialize to an appropriate value
            
            IProject actual;
            actual = target.GetProjectbyID(ID);
            Assert.IsNotNull(actual);
        }
        /// <summary>
        ///A test for GetProjectsbyAdministrator
        ///</summary>
        [TestMethod()]
        public void GetProjectsbyAdministratorTest()
        {
            ProjectRepository target = new ProjectRepository(); // TODO: Initialize to an appropriate value
            IList<IProject> expected = null; // TODO: Initialize to an appropriate value
            IList<IProject> actual;
            actual = target.GetProjectsbyAdministrator();
            Assert.AreEqual(expected, actual);
        }
    }
}
