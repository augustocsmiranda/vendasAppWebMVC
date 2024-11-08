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

        public DbSet<AppVendas.Models.Department> Department { get; set; }
    }
}
