using System;
using Task1.Solution.Interfaces.Validator;

namespace Task1.Solution.Validators
{
    public class MaxLengthValidator : IPasswordValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (password.Length >= 15)
                return Tuple.Create(false, $"{password} length too long");

            return Tuple.Create(true, string.Empty);
        }
    }
}