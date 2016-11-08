using System;
using NUnit.Framework;

namespace ClassLibraryTask1.NUnit.Tests
{
    [TestFixture]
    public class ArrayHandlerNUnitTests
    {
        [TestCase(new[] {1, 2, 3, 4, 3, 2, 1}, Result = 3)]
        [TestCase(new[] { 1, 100, 50, -51, 1, 1 }, Result = 1)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 2, 1 }, Result = null)]
        [TestCase(new[] { 1, 1, 1, 1 }, Result = null)]
        [TestCase(new[] { 100 }, ExpectedException = typeof(ArgumentException))]
        [TestCase(new[] { 0, 0 }, ExpectedException = typeof(ArgumentException))]
        [TestCase(new int[] { }, ExpectedException = typeof(ArgumentOutOfRangeException))]

        public int? FindIndexTests(int[] arr)
        {
            return ArrayHandler.FindIndex(arr);
        }
    }
}
