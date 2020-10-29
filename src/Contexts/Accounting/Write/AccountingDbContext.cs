using Microsoft.EntityFrameworkCore;

namespace Accounting.Write
{
    public class AccountingDbContext : DbContext
    {
        public DbSet<Domain.Model.Account> Accounts { get; set; }
        public AccountingDbContext(DbContextOptions opts) : base(opts)
        {            
        }
    }
}