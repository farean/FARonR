using System;
using System.Collections.Generic;
using MyDashboard.Model.Interfaces.Entities;
[assembly: CLSCompliant(true)]
namespace MyDashboard.Model.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        IProject GetProjectbyID(int ID);
        IList<IProject> GetProjectsbyAdministrator();
    }
}
