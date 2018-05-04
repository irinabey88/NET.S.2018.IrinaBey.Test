using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Test6.Solution;

namespace Task6.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};
            NumberGenerator<int> number = new NumberGenerator<int>();

            CollectionAssert.AreEqual(number.Generate(10, 1, 1, (x, y) => x + y), expected);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            NumberGenerator<int> number = new NumberGenerator<int>();

            CollectionAssert.AreEqual(number.Generate(10, 2, 1, (x,y) => 6*x - 8*y), expected);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            NumberGenerator<double> number = new NumberGenerator<double>();

            CollectionAssert.AreEqual(number.Generate(10, 2, 1, (x, y) => y + x/y), expected);
        }
    }
}
