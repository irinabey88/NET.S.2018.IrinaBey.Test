using System;
using System.Collections.Generic;

namespace Task4.Solution
{
    public static class Calculator
    {
        public static double CalculateAverage(List<double> values, ICalcFunction calcFunction)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (calcFunction == null)
            {
                throw new ArgumentNullException(nameof(calcFunction));
            }

            return calcFunction.CalcFunc(values);
        }

        public static double CalculateAverage(List<double> values, Func<List<double>, double> calcFunction)
        {

            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (calcFunction == null)
            {
                throw new ArgumentNullException(nameof(calcFunction));
            }

            return calcFunction(values);
        }
    }
}