using APIWallet.Domain.Entities;

namespace APIWallet.Service.IRepository
{
    public interface IRepositoryService
    {
        User CreateUser(User user);
        Wallet CreateWallet(Wallet wallet);
    }
}
