using System;
namespace MyDashboard.Model.Interfaces.Entities
{
    public interface IOwner
    {
        int ID { get; set; }
        string Name { get; set; }
    }
}
