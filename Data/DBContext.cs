using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp2.Models;

namespace WebApp2.Data
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp2.Models.Customer> Customers { get; set; } = default!;
        public DbSet<WebApp2.Models.Employee> Employees { get; set; } = default!;
        public DbSet<WebApp2.Models.Order> Orders { get; set; } = default!;
        public DbSet<WebApp2.Models.Item> Items { get; set; } = default!;

        public DbSet<WebApp2.Models.OrderLine> OrderLines { get; set; } = default!;
    }
}
