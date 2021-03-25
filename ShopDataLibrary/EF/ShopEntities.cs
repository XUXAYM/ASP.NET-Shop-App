using ShopDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ShopDataLibrary.EF
{
    public class ShopEntities : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ShopEntities() : base("name=ShopConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ShopEntities, Migrations.Configuration>()); 
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
