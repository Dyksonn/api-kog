using APIWallet.Domain.Entities;
using APIWallet.Infrastructure.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace APIWallet.Infrastructure.Data.Context
{
    public class DatabaseContext : DbContext
    {
        protected readonly IConfiguration Config;

        public DatabaseContext(IConfiguration configuration, DbContextOptions<DatabaseContext> options) : base(options)
        {
            Config = configuration;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Wallet> Wallets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string test3 = Config.GetConnectionString("APIWalletDatabase");
            options.UseSqlite(Config.GetConnectionString("APIWalletDatabase"));
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<Wallet>(new WalletMap().Configure);
        }
    }
}
