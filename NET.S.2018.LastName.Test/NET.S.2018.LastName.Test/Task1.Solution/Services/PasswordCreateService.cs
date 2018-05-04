using System;
using System.Runtime.CompilerServices;
using Task1.Solution.Interfaces;
using Task1.Solution.Interfaces.Repository;
using Task1.Solution.Interfaces.Service;

namespace Task1.Solution.Services
{
    public class PasswordCreateService : IPasswordCreateService
    {
        private readonly IRepository _paswswordRepository;

        private readonly IPasswordCheckService _passwordCheckService;

        public PasswordCreateService(IRepository repository, IPasswordCheckService checkService)
        {
            this._paswswordRepository = repository ?? throw new ArgumentNullException(nameof(repository));
            this._passwordCheckService = checkService ?? throw new ArgumentNullException(nameof(repository));
        }

        public Tuple<bool, string> AddPassword(string password)
        {
            var isValid = this._passwordCheckService.VerifyPassword(password);

            if (isValid.Item1)
            {
                this._paswswordRepository.Create(password);
            }

            return isValid;
        }
    }
}