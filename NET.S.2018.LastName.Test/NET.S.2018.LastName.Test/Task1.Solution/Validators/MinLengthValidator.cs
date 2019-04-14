using System;
using Task1.Solution.Interfaces.Validator;

namespace Task1.Solution.Validators
{
    public class MinLengthValidator : IPasswordValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (password.Length <= 7)
                return Tuple.Create(false, $"{password} length too short");

            return Tuple.Create(true, string.Empty);
        }
    }
}