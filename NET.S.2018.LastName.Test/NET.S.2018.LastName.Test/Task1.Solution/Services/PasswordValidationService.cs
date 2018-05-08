using System;
using System.Collections.Generic;
using System.Linq;
using Task1.Solution.Interfaces.Service;
using Task1.Solution.Interfaces.Validator;

namespace Task1.Solution.Services
{
    public class PasswordValidationService : IValidationService<string>
    {
        private readonly IEnumerable<IPasswordValidator> _validators;

        public PasswordValidationService(IEnumerable<IPasswordValidator> validators)
        {
            this._validators = validators ?? throw new ArgumentNullException(nameof(validators));
        }

        public IEnumerable<Tuple<bool, string>> Validate(string password)
        {
            foreach (var validator in this._validators)
            {
                yield return validator.IsValid(password);
            }
        }

        public bool IsValid(string password)
        {
            var validationData = this.Validate(password);

            if (validationData.All(x => x.Item1))
            {
                return true;
            }

            return false;
        }
    }
}