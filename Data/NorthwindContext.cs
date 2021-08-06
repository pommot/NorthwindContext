using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Northwind.Models;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Data
{
    public class NorthwindContext : DbContext

    {
        public DbSet<Produtos> Produtos { get; set; }

        public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
        {
        }

    }
}

