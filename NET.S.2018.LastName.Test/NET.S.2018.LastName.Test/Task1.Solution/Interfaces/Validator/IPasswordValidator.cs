using System;

namespace Task1.Solution.Interfaces.Validator
{
    public interface IPasswordValidator
    {
        Tuple<bool, string> IsValid(string password);
    }
}