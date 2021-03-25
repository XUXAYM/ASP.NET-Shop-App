using ShopDAL.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Text;

namespace ShopDAL.EF
{
    public class ShopEntities : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ShopEntities() : base("name=ShopConnection")
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
