using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MyDashboard.Data.Entities;
using System.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyDashboard.Data.Contexts
{
    public class MyDashboardContext : DbContext,IDisposable 
    {
        public MyDashboardContext()
        {
#if DEBUG
            if (Database.Exists() && !Database.CompatibleWithModel(false))
                Database.Delete();
#endif

            if (!Database.Exists())
            {
                Database.Create();
                this.Seed();
            }

            Database.Initialize(false);
        }

        private void Seed()
        {
            FillStatusProjects(this);
            this.SaveChanges();
        }

        private void FillStatusProjects(MyDashboardContext myDashboardContext)
        {
            StatusProject sp;
            List<StatusProject> lsp = new List<StatusProject>();
            lsp.Add(new StatusProject { ID = 1, Status = "Active" });
            lsp.Add(new StatusProject { ID = 0, Status = "Inactive" });
            foreach (var item in lsp)
            {
                myDashboardContext.StatusProjects.Add(item);
            }
            
        }
        public DbSet<StatusProject> StatusProjects { get; set; }
        public DbSet<Project> Projects { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            
            modelBuilder.Entity<StatusProject>().HasKey(pk => pk.ID);
            modelBuilder.Entity<StatusProject>().Property(pp => pp.Status).HasMaxLength(30).IsRequired();

            modelBuilder.Entity<Project>().HasKey(pk => pk.ID);
            modelBuilder.Entity<Project>().Property(pk => pk.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Project>().Property(pk => pk.ProjectName).HasMaxLength(255).IsRequired();
            modelBuilder.Entity<Project>().HasRequired(fk => fk.Status).WithMany().Map(fkey => fkey.MapKey("StatusProjectID"));
 
                

        }

    }
}
