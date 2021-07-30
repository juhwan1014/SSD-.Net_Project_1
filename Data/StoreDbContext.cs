using Microsoft.EntityFrameworkCore;
using SSDeShopOnWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSDeShopOnWeb.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
          : base(options)
        {
        }

        //this defines my list of tables in the db
        public DbSet<Product> Products { get; set; }
    }
}
