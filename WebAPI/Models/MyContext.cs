using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class MyContext : DbContext
    {
        public DbSet<Admin_list> Admins { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Klient> Klients { get; set; }
        public DbSet<Obj> Objs { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Template> Templates { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}