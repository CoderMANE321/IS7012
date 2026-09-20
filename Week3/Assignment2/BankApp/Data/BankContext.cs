using Microsoft.EntityFrameworkCore;

namespace BankApp.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {
        }

        public DbSet<AccountHolder> AccountHolders { get; set; }

        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}