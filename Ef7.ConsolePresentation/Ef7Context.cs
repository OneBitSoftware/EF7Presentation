using System;
using System.Linq;
using EF.Models;
using Microsoft.Data.Entity;

namespace Ef7.Console
{
    class Ef7Context : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Ef7.ConsoleApp;Trusted_Connection=True;"); 
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>()
                .Property(b => b.Name)
                .IsRequired();
             
            //Shadow Property
            //modelBuilder.Entity<Store>()
            //    .Property<DateTime?>("LastUpdated").IsRequired();

            //Shadow Property
            //modelBuilder.Entity<Store>()
            //   .Property<DateTime>("DateCreated"); 
        }

        //public override int SaveChanges()
        //{
        //    ChangeTracker.DetectChanges();

        //    var createdStoreEntry = ChangeTracker
        //        .Entries<Store>()
        //        .Where(x => x.State == EntityState.Added);

        //    foreach (var item in createdStoreEntry)
        //    {
        //        item.Property("DateCreated").CurrentValue = DateTime.Now;
        //    }

        //    var modifiedStoreEntry = ChangeTracker
        //        .Entries<Store>()
        //        .Where(x => x.State == EntityState.Modified);

        //    //foreach (var item in modifiedStoreEntry)
        //    //{
        //    //    //item.Property("LastUpdated").CurrentValue = DateTime.Now;
        //    //}

        //    return base.SaveChanges();
        //}
    }
}
