﻿using System;
using System.Data;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTask1.TestsDDT
{
    [TestClass]
    public class ArrayHandlerTestsDDT
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\TestsInfo.xml",
            "TestCase",
            DataAccessMethod.Sequential)]

        [DeploymentItem("ClassLibraryTask1.TestsDDT\\TestsInfo.xml")]

        [TestMethod]
        public void FindIndexTests()
        {
            var exceptionName = string.Empty;
            var expectedException = TestContext.DataRow["ExpectedException"].GetType()
                    != typeof(System.DBNull) ?
                    Convert.ToString(TestContext.DataRow["ExpectedException"]) : string.Empty; ;

            try
            {
                var info = Convert.ToString(TestContext.DataRow["Array"]);
                var tokens = info.Split(new char[] {' '});
                var size = Convert.ToInt32(TestContext.DataRow["Count"]);
                var arr = new int[size];
                var i = 0;
                if (size > 0)
                {
                    foreach (var element in tokens)
                    {
                        arr[i++] = int.Parse(element);
                    }
                }

                var actual = ArrayHandler.FindIndex(arr);

                var expect = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);

                Assert.AreEqual(expect, actual);
            }
            catch (Exception ex)
            {
                exceptionName = ex.GetType().ToString();

                expectedException = TestContext.DataRow["ExpectedException"].GetType() 
                    != typeof (System.DBNull) ? 
                    Convert.ToString(TestContext.DataRow["ExpectedException"]) : string.Empty;

                Assert.AreEqual(expectedException, exceptionName);
            }

            if (expectedException.Length > 0 && exceptionName.Length == 0)
            {
                Assert.Fail($"{expectedException} was expected, but was not thrown!");
            }
        }
    }
}
