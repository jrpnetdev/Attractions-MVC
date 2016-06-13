using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Attractions.Data
{
    public class MvcDemoContext : DbContext
    {
        public MvcDemoContext() : base("MvcDemoConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MvcDemoContext>());
        }

        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.Favourites);
             
            base.OnModelCreating(modelBuilder);
        }
    }
}