using System;
using System.Linq;
using Task1.Solution.Interfaces.Validator;

namespace Task1.Solution.Validators
{
    public class HasNumberValidator : IPasswordValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (!password.Any(char.IsNumber))
                return Tuple.Create(false, $"{password} hasn't digits");

            return Tuple.Create(true, string.Empty);
        }
    }
}