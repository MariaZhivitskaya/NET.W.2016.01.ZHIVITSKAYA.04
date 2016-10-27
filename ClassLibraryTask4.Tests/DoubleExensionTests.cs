using System;

using NUnit.Framework;

namespace ClassLibraryTask4.Tests
{
    [TestFixture]
    public class DoubleExensionTests
    {
        [TestCase(14.548914, Result = "0100000000101101000110010000101101000001011111001010001000010010")]
        [TestCase(-5154.2166816, Result = "1100000010110100001000100011011101111000011100100000000110100101")]
        [TestCase(10, Result = "0100000000100100000000000000000000000000000000000000000000000000")]

        public string DoubleToIEEE754Tests(double number)
        {
            return DoubleExtension.DoubleToIEEE754(number);
        }
    }
}
