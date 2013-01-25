using System;
namespace MyDashboard.Model.Entities.Interfaces
{
    interface IOwner
    {
        int ID { get; set; }
        string Name { get; set; }
    }
}
