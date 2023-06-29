using APIWallet.Domain.Entities;
using APIWallet.Infrastructure.Data.Context;
using APIWallet.Service.IRepository;

namespace APIWallet.Service.Repository
{
    public class RepositoryService : IRepository.IRepositoryService
    {
        private readonly DatabaseContext dbContext;

        public RepositoryService()
        {
            
        }

        public RepositoryService(DatabaseContext db)
        {
            this.dbContext = db;
        }

        public User CreateUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }
        public Wallet CreateWallet(Wallet wallet)
        {
            dbContext.Wallets.Add(wallet);
            dbContext.SaveChanges();
            return wallet;
        }
        public List<Wallet> GetWalletsByUserId(int userId)
        {
            return dbContext.Wallets.Where(x => x.UserID == userId).Any() ? dbContext.Wallets.Where(x => x.UserID == userId).ToList() : new List<Wallet>();
        }
    }
}
