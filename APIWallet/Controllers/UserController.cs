using APIWallet.Domain.Entities;
using APIWallet.Infrastructure.Data.Context;
using APIWallet.Service.IRepository;
using APIWallet.Service.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIWallet.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<User> _logger;
        private readonly RepositoryService _repositoryService = null;

        public UserController(ILogger<User> logger, DatabaseContext repository)
        {
            _logger = logger;
            _repositoryService = new RepositoryService(repository);
        }

        [HttpPost]
        public User Create(User user)
        {

            User newUser = _repositoryService.CreateUser(new Domain.Entities.User
            {
                CPF = user.CPF,
                Nascimento = user.Nascimento,
                Nome = user.Nome
            });
            return newUser;
        }
    }
}