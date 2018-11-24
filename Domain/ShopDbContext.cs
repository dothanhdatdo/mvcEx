using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;


namespace Domain
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext() : base("ShopDbContext")
        {

        }

        public DbSet <Product> Products{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet <Supplier> Suppliers{ get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

    }
}
