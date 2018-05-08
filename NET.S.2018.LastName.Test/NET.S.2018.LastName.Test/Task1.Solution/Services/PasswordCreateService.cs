using System;
using System.Collections.Generic;
using System.Linq;
using Task1.Solution.Interfaces.Repository;
using Task1.Solution.Interfaces.Service;

namespace Task1.Solution.Services
{
    public class PasswordCreateService : IPasswordCreateService
    {
        private readonly IRepository _paswswordRepository;

        private readonly IValidationService<string> _passwordValidationService;

        public PasswordCreateService(IRepository repository, IValidationService<string> checkService)
        {
            this._paswswordRepository = repository ?? throw new ArgumentNullException(nameof(repository));
            this._passwordValidationService = checkService ?? throw new ArgumentNullException(nameof(repository));
        }

        public Tuple<bool, IEnumerable<string>> AddPassword(string password)
        {         
            if (this._passwordValidationService.IsValid(password))
            {
                this._paswswordRepository.Create(password);

                return new Tuple<bool, IEnumerable<string>>(true, new List<string>{string.Empty});
            }

            return new Tuple<bool, IEnumerable<string>>(false, this._passwordValidationService.Validate(password).Where(x => !x.Item1).Select(x => x.Item2));
        }
    }
}