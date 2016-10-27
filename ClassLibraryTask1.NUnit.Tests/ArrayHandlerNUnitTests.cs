using System;
using NUnit.Framework;

namespace ClassLibraryTask1.NUnit.Tests
{
    [TestFixture]
    public class ArrayHandlerNUnitTests
    {
        [TestCase(new int[] {1, 2, 3, 4, 3, 2, 1}, Result = 3)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, Result = 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 2, 1 }, Result = -1)]
        [TestCase(new int[] { 1, 1, 1, 1 }, Result = -1)]
        [TestCase(new int[] { 100 }, Result = -1)]
        [TestCase(new int[] { 0, 0 }, Result = -1)]
        [TestCase(new int[] { }, ExpectedException = typeof(Exception))]

        public int FindIndexTests(int[] arr)
        {
            return ArrayHandler.FindIndex(arr);
        }
    }
}
