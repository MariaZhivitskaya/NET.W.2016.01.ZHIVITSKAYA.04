using System;
using Microsoft.Win32;
using NUnit.Framework;

namespace ClassLibraryTask3.Tests
{
    [TestFixture]
    public class NewtonsMethodTests
    {
        [TestCase(9, 3, 0.001)]
        [TestCase(12.487, 24, 1E-16)]
        [TestCase(9, 2, 1E-548, ExpectedException = typeof(ArgumentException))]
        [TestCase(-416846, 19, 0.00001)]
        [TestCase(-416846, 20, 0.001, ExpectedException = typeof(ArgumentException))]
        [TestCase(584569, 0, 0.0001)]

        public void CountRootTests(double number, int degree, double precision)
        {
            double expect = Math.Pow(number, (double) 1/degree);
            double result = NewtonsMethod.CountRoot(number, degree, precision);

            Assert.Less(Math.Abs(expect - result), precision);
        }
    }
}
