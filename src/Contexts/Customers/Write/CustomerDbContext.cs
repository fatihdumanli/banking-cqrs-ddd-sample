using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Customers.Write
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Domain.Models.Customer> Customers { get; set; }

        public CustomerDbContext(DbContextOptions opts) : base(opts)
        {
        }
    }
}
