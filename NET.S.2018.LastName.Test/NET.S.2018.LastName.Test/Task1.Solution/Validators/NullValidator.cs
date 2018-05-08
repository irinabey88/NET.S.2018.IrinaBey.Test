using System;
using Task1.Solution.Interfaces.Validator;

namespace Task1.Solution.Validators
{
    public class NullValidator : IPasswordValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (password == null)
                return Tuple.Create(false, $"password is null arg");

            return Tuple.Create(true, string.Empty);
        }
    }
}