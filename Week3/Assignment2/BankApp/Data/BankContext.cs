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

        public DbSet<AccountHolderAccount> AccountHolderAccounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountHolderAccount>()
                .HasKey(x => new
                {
                    x.AccountHolderId,
                    x.BankAccountId
                });

            modelBuilder.Entity<AccountHolderAccount>()
                .HasOne(x => x.AccountHolder)
                .WithMany(x => x.BankAccounts)
                .HasForeignKey(x => x.AccountHolderId);

            modelBuilder.Entity<AccountHolderAccount>()
                .HasOne(x => x.BankAccount)
                .WithMany(x => x.AccountHolders)
                .HasForeignKey(x => x.BankAccountId);
        }
    }
}