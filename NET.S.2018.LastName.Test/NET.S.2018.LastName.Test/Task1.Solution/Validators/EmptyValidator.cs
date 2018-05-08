using System;
using Task1.Solution.Interfaces.Validator;

namespace Task1.Solution.Validators
{
    public class EmptyValidator : IPasswordValidator
    {
        public Tuple<bool, string> IsValid(string password)
        {
            if (password == string.Empty)
                return Tuple.Create(false, $"{password} is empty ");

            return Tuple.Create(true, string.Empty);
        }
    }
}