using APIWallet.Domain.Entities;
using APIWallet.Infrastructure.Data.Context;
using APIWallet.Service.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIWallet.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WalletController : ControllerBase
    {

        private readonly ILogger<Wallet> _logger;
        private readonly RepositoryService _repositoryService = null;

        public WalletController(ILogger<Wallet> logger, DatabaseContext repository)
        {
            _logger = logger;
            _repositoryService = new RepositoryService(repository);
        }


        [HttpGet(Name = "wallet")]
        public List<Wallet> Get(int userId)
        {
            return _repositoryService.GetWalletsByUserId(userId);
        }
        [HttpPost(Name = "wallet/create")]
        public Wallet Create(Wallet wallet)
        {
            Wallet newWallet = _repositoryService.CreateWallet(new Wallet
            {
                UserID = wallet.UserID,
                ValorAtual = wallet.ValorAtual,
                Banco = wallet.Banco,
                UltimaAtualizacao = DateTime.Now
            });
            return newWallet;
        }
    }
}