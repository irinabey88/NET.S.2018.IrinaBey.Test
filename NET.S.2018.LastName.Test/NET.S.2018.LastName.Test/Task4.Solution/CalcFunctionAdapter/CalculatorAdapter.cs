using System;
using System.Collections.Generic;

namespace Task4.Solution.CalcFunctionAdapter
{
    public class CalculatorAdapter : ICalcFunction
    {
        private Func<List<double>, double> _calcFunc;

        public CalculatorAdapter(Func<List<double>, double> calcFunc)
        {
            if (calcFunc == null)
            {
                throw new ArgumentNullException(nameof(calcFunc));
            }

            this._calcFunc = calcFunc;
        }

        public double CalcFunc(List<double> values)
        {
            return this._calcFunc(values);
        }
    }
}