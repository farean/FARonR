using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDashboard.Model.Entities.Interfaces;
[assembly: CLSCompliant(true)]
namespace MyDashboard.Model.Entities
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
