using System;
using System.Collections.Generic;
namespace MyDashboard.Model.Interfaces.Entities
{
    public interface IProject
    {
        int ID { get; set; }
        string Name { get; set; }
        IList<IOwner> Owners { get; set; }
    }
}
