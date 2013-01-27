using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDashboard.Model.Interfaces.Entities;
namespace MyDashboard.Model.Entities
{
    public class Owner : IOwner
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
