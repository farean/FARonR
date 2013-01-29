using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MyDashboard.Data.Entities;
namespace MyDashboard.Data.Contexts
{
    public class MyDashboardContext : DbContext
    {
        DbSet<StatusProject> StatusProjects { get; set; }
        DbSet<Project> Projects { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            
            modelBuilder.Entity<StatusProject>().HasKey(pk => pk.ID);
            modelBuilder.Entity<StatusProject>().Property(pp => pp.Status).HasMaxLength(30).IsRequired();
 
                

        }

    }
}
