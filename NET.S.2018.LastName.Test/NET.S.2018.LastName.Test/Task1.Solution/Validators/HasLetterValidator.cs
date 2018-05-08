using System;
using System.Linq;
using Task1.Solution.Interfaces.Validator;

namespace Task1.Solution.Validators
{
    public class HasLetterValidator : IPasswordValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (!password.Any(char.IsLetter))
                return Tuple.Create(false, $"{password} hasn't alphanumerical chars");

            return Tuple.Create(true, string.Empty);
        }
    }
}