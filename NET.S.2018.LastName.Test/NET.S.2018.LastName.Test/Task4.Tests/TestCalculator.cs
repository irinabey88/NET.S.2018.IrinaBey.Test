using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Task4;
using Task4.Solution;

namespace Task4.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {           

            double expected = 8.3636363;

            Assert.AreEqual(expected, Calculator.CalculateAverage(values, x => x.Sum() / x.Count), 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {            

            double expected = 8.0;
            Func<List<double>, double> calcFunc = (listValue) =>
            {
                var sortedValues = listValue.OrderBy(x => x).ToList();

                int n = sortedValues.Count;

                if (n % 2 == 1)
                {
                    return sortedValues[(n - 1) / 2];
                }

                return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
            };

            Assert.AreEqual(expected, Calculator.CalculateAverage(values, calcFunc));
        }
    }
}