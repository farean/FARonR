using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDashboard.Model.Entities.Interfaces;
namespace MyDashboard.Model.Entities
{
    public class Owner : IOwner
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
