using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDashboard.Data.Entities
{
    public class Project
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public StatusProject Status { get; set; }

    }
}
