using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Teste.Models;

namespace SalesWeb.Data
{
    public class SalesWebContext : DbContext
    {
        public SalesWebContext (DbContextOptions<SalesWebContext> options)
            : base(options)
        {
        }

        public DbSet<Teste.Models.Department> Department { get; set; }
    }
}
