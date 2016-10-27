using System;
using NUnit.Framework;

namespace ClassLibraryTask2_1.Tests
{
    [TestFixture]
    public class BitInsertionTests
    {
        [TestCase(8, 15, 0, 0, Result = 9)]
        [TestCase(0, 54, 12, 4, ExpectedException = typeof(Exception))]
        [TestCase(0, 54, 0, 34, ExpectedException = typeof(Exception))]
        [TestCase(0, 15, 0, 30, Result = 15)]
        [TestCase(15, int.MaxValue, 3, 5, Result = 63)]
        [TestCase(0, -15, 0, 4, Result = 31)]
        [TestCase(0, 15, 30, 30, Result = 1073741824)]

        public int InsertionTests(int number1, int number2, int rightPosition, int leftPosition)
        {
            return BitsInsertion.Insertion(number1, number2, rightPosition, leftPosition);
        }
    }
}
