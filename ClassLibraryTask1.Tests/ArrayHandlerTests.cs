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
            var arr = new int[] {1, 2, 3, 4, 3, 2, 1};
            var expect = 3;

            var actual = ArrayHandler.FindIndex(arr);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void FindIndex_DifferentNumbers_1Return()
        {
            var arr = new int[] { 1, 100, 50, -51, 1, 1 };
            var expect = 1;

            var actual = ArrayHandler.FindIndex(arr);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void FindIndex_DifferentNumbers_Minus1Return()
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 2, 1 };
            var expect = -1;

            var actual = ArrayHandler.FindIndex(arr);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void FindIndex_AllOnes_Minus1Return()
        {
            var arr = new int[] { 1, 1, 1, 1 };
            var expect = -1;

            var actual = ArrayHandler.FindIndex(arr);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void FindIndex_100_Minus1Return()
        {
            var arr = new int[] { 100 };
            var expect = -1;

            var actual = ArrayHandler.FindIndex(arr);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void FindIndex_AllZeroes_Minus1Return()
        {
            var arr = new int[] { 100 };
            var expect = -1;

            var actual = ArrayHandler.FindIndex(arr);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FindIndex_Empty_ExceptionReturn()
        {
            var arr = new int[] { };
            var actual = ArrayHandler.FindIndex(arr);
        }
    }
}
