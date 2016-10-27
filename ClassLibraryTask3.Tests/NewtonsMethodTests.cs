using System;
using Microsoft.Win32;
using NUnit.Framework;

namespace ClassLibraryTask3.Tests
{
    [TestFixture]
    public class NewtonsMethodTests
    {
        [TestCase(9, 3, 3)]
        [TestCase(12.487, 26, 16)]
        [TestCase(9, 2, 24, ExpectedException = typeof(Exception))]
        [TestCase(-416846, 19, 5)]
        [TestCase(-416846, 20, 5, ExpectedException = typeof(Exception))]
        [TestCase(0.745849, 0.4876, 10)]
        [TestCase(0.745849, -0.4876, 10)]
        [TestCase(0.745849, -0.4876, 10)]
        [TestCase(0, 0, 15, ExpectedException = typeof(Exception))]
        [TestCase(584569, 0, 3)]

        public void CountRootTests(double number, double degree, int precision)
        {
            var difference = Math.Abs(Math.Pow(number, 1/degree) -
                                               NewtonsMethod.CountRoot(number, degree, precision));
            var eps = Math.Pow(10, -degree);

            Assert.Less(difference, eps);
        }
    }
}
