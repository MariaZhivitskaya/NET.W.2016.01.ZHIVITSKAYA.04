using System;
using NUnit.Framework;

namespace ClassLibraryTask2.Tests
{
    [TestFixture]
    public class StringsHandlerTest
    {
        [TestCase("xyaabbbccccdefww", "xxxxyyyyabklmopq", Result = "abcdefklmopqwxy")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", 
            Result = "abcdefghijklmnopqrstuvwxyz")]
        [TestCase(null, "", ExpectedException = typeof(ArgumentNullException))]
        [TestCase("dsf^kjhs", "fddgHr", ExpectedException = typeof(ArgumentException))]
        [TestCase("xxxxxxxx", "xxx", Result = "x")]

        public string LongestTests(string a, string b)
        {
            return StringsHandler.Longest(a, b);
        }
    }
}
