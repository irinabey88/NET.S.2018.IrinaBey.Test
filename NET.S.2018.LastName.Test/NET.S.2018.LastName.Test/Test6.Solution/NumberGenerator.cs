using System;
using System.Collections.Generic;

namespace Test6.Solution
{
    public class NumberGenerator<T> where T : struct
    {
        public IEnumerable<T> Generate(int count, T elementN, T elementNm1, Func<T,T,T> calNextElement) 
        {
            if (calNextElement == null)
            {
                throw new ArgumentNullException(nameof(calNextElement));
            }

            if (count < 1)
            {
                throw new ArgumentException($"Count numbers should be greater than 0!");
            }
            
            yield return elementNm1;
            yield return elementN;

            T next = elementN;
            T previous = elementNm1;

            for (int i = 0; i < count - 2; i++)
            {
                T nextElement = calNextElement(next, previous);
                previous = next;
                next = nextElement;

                yield return nextElement;
            }
        }
    }
}