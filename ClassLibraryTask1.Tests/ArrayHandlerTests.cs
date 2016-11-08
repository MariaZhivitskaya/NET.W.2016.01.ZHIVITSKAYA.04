using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTask1.Tests
{
    [TestClass]
    public class ArrayHandlerTests
    {
        [TestMethod]
        public void FindIndex_AllPositiveNumbers_3Return()
        {
            var arr = new[] {1, 2, 3, 4, 3, 2, 1};
            int expect = 3;

            int? actual = ArrayHandler.FindIndex(arr);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void FindIndex_DifferentNumbers_1Return()
        {
            var arr = new[] { 1, 100, 50, -51, 1, 1 };
            int expect = 1;

            int? actual = ArrayHandler.FindIndex(arr);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void FindIndex_DifferentNumbers_Minus1Return()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 2, 1 };

            int? actual = ArrayHandler.FindIndex(arr);

            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        public void FindIndex_AllOnes_Minus1Return()
        {
            var arr = new[] { 1, 1, 1, 1 };

            int? actual = ArrayHandler.FindIndex(arr);

            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindIndex_100_Minus1Return()
        {
            var arr = new[] { 100 };
            ArrayHandler.FindIndex(arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindIndex_AllZeroes_Minus1Return()
        {
            var arr = new[] { 100 };
            ArrayHandler.FindIndex(arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FindIndex_Empty_ExceptionReturn()
        {
            var arr = new int[] { };
            ArrayHandler.FindIndex(arr);
        }
    }
}
