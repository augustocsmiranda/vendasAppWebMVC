using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AppVendas.Models
{
    public class AppVendasContext : DbContext
    {
        public AppVendasContext (DbContextOptions<AppVendasContext> options)
            : base(options)
        {
        }

        //public DbSet<AppVendas.Models.Department> Department { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }


    }
}
