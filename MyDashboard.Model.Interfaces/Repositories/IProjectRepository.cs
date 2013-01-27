using System;
using System.Collections.Generic;
using MyDashboard.Model.Interfaces.Entities;
namespace MyDashboard.Model.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        IProject GetProjectbyID(int ID);
        IList<IProject> GetProjectsbyAdministrator();
    }
}
