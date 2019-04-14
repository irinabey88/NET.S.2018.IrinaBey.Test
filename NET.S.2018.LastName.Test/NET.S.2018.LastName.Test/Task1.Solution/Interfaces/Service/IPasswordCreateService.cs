using System;
using System.Collections.Generic;

namespace Task1.Solution.Interfaces.Service
{
    public interface IPasswordCreateService
    {
        Tuple<bool, IEnumerable<string>> AddPassword(string password);
    }
}