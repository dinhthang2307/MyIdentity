using identity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace identity.DAL
{
    public class MyContext: DbContext
    {
        public MyContext() : base("DefaultConnection")
        {
        }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}