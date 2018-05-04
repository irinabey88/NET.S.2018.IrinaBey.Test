using System;

namespace Task1.Solution.Interfaces.Service
{
    public interface IPasswordCheckService
    {
        Tuple<bool, string> VerifyPassword(string password);
    }
}