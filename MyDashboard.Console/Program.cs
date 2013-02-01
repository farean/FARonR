using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyDashboard.Data.Contexts;

namespace MyDashboard.Consoles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyDashboardContext context = new MyDashboardContext())
            {
                var listado = context.StatusProjects;
                foreach (var item in listado)
                {
                    Console.Write(item.ID.ToString());
                    Console.Write(" - ");
                    Console.WriteLine(item.Status);
                }
               
            }
            Console.ReadKey();
        }
    }
}
