using System;
using System.Collections.Generic;

namespace Task1.Solution.Interfaces.Service
{
    public interface IValidationService<in T>
    {
        IEnumerable<Tuple<bool,string>> Validate(T password);

        bool IsValid(T password);
    }
}