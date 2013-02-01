using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDashboard.Model.Entities;
using MyDashboard.Model.Interfaces.Entities;
using MyDashboard.Model.Interfaces.Repositories;
using System.Runtime.CompilerServices;

namespace MyDashboard.Model.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private IList<IProject> projects;
        public ProjectRepository()
        {
            projects = new List<IProject> { new Project() };
        }
        
        internal ProjectRepository(IList<IProject> listprojects)
        {
            projects = listprojects;
        }
        public IProject GetProjectbyID(int ID)
        {
            if (ID <= 0)
                return null;

            IProject project = projects.Where(p => p.ID == ID).Single();
            return project;
        }
        public IList<IProject> GetProjectsbyAdministrator(IOwner owner)
        {
            if (owner == null)
                return null;

            var listprojects = projects.Where(p => p.Owners.Any(o => o.ID == owner.ID)).ToList();
            
            return (IList<IProject>)listprojects;
        }
    }
}
