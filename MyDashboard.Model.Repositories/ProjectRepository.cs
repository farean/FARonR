﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDashboard.Model.Entities;
using MyDashboard.Model.Interfaces.Entities;
using MyDashboard.Model.Interfaces.Repositories;
[assembly: CLSCompliant(true)]
namespace MyDashboard.Model.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public IProject GetProjectbyID(int ID)
        {
            Project project = new Project();
            return (IProject)project;
        }
        public IList<IProject> GetProjectsbyAdministrator()
        {
            var projects = new List<Project>();
            return (IList<IProject>)projects;
        }
    }
}