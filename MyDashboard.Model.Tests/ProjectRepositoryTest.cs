using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyDashboard.Model.Entities;
using MyDashboard.Model.Interfaces.Entities;
using MyDashboard.Model.Interfaces.Repositories;
using MyDashboard.Model.Repositories;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private static IProjectRepository _projectsrepository = null;
        private IList<IProject> projectlist = new List<IProject>
            {
                new Project(){
                    ID=1,
                    Name="Technology Support",
                    Owners= new List<IOwner>{
                        new Owner(){
                            ID=1,
                            Name="Fernando Arean"
                        }
                    }
                },
                new Project(){
                    ID=5,
                    Name="Portal 2.0",
                       Owners= new List<IOwner>{
                        new Owner(){
                            ID=2,
                            Name="Mauricio Miraglio"
                        }
                       }
                },
                new Project(){
                    ID=2,
                    Name="Publishing",
                    Owners= new List<IOwner>{
                        new Owner(){
                            ID=3,
                            Name="Omar Guntaue"
                        }
                    }
                },
                new Project(){
                    ID=6,
                    Name="Mailer",
                    Owners= new List<IOwner>{
                        new Owner(){
                            ID=3,
                            Name="Omar Guntaue"
                        }
                    }
                }
            };

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
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {

            //var resultsmoq = new List<Project>();


            //Mock<ProjectRepository> projectrepository = new Moq.Mock<ProjectRepository>(projectlist);
            //projectrepository.Setup(m => m.GetProjectsbyAdministrator(It.IsAny<IOwner>())).Returns(IList<IProject>);


            ////projectrepository.Setup(m => m.GetProjectbyID(It.IsAny<int>())).Returns((int i) => projectlist.Where(m => m.ID == i).Single());
            //_projectsrepository = projectrepository.Object;
        }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            _projectsrepository = null;
        }
        #endregion


        [TestMethod()]
        public void GetProjectbyIDTest_WhenValuesLessOrEqualtoZero_ShouldBeNull()
        {
            ProjectRepository target = new ProjectRepository(); // TODO: Initialize to an appropriate value
            int ID = 0; // TODO: Initialize to an appropriate value
            IProject expected = null; // TODO: Initialize to an appropriate value

            IProject actual= target.GetProjectbyID(ID);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
         public void GetProjectbyIDTest_WhenValuesGreaterThanZero_ShouldBeNotNullandFindit()
        {
            ProjectRepository projectrepository = new ProjectRepository(projectlist);
            int ID = 2; // TODO: Initialize to an appropriate value

            IProject actual= _projectsrepository.GetProjectbyID(ID);
            Assert.IsNotNull(actual);
            Assert.AreEqual(ID,actual.ID);
        }
        [TestMethod]
        public void GetAllProjectsbyOwner_NotValidOwner_ShouldBeNull()
        {
            ProjectRepository projectrepository = new ProjectRepository(projectlist);
            Owner owner = new Owner
            {
                ID = 77,
                Name = "Fernando Arean"
            };
            IList<IProject> result =projectrepository.GetProjectsbyAdministrator(owner);
            Assert.AreEqual(0, result.Count);

            
        }
        /// <summary>
        ///A test for GetProjectsbyAdministrator
        ///</summary>
        [TestMethod()]
        public void GetAllProjectsbyOwner_NotValidOwner_ShouldBeFindit()
        {
            Owner owner = new Owner
            {
                ID = 3,
                Name = "Omar Guntaue"
            };
            ProjectRepository projectrepository = new ProjectRepository(projectlist);
            var result = projectrepository.GetProjectsbyAdministrator(owner);

            Assert.AreEqual(2,result.Count);
        }
    }
}
