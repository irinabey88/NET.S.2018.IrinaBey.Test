using System;

namespace Task1.Solution.Interfaces
{
    public interface IPasswordCreateService
    {
        Tuple<bool, string> AddPassword(string password);
    }
}