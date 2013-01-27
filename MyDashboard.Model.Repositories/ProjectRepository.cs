using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDashboard.Model.Interfaces.Entities;
using MyDashboard.Model.Entities;
[assembly: CLSCompliant(true)]
namespace MyDashboard.Model.Repositories
{
    public class ProjectRepository
    {
        private ProjectRepository()
        {

        }
        public static IProject GetProjectbyID(int ID)
        {
            Project project = new Project();
            return project;
        }
        public static IList<IProject> GetProjectsbyAdministrator()
        {
            var projects = new List<Project>();
            return (IList<IProject>)projects;
        }
    }
}
