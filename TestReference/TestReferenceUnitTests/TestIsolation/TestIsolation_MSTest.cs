using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestIsolation
{
    [TestClass]
    public class TestIsolation_MSTest
    {
        private int check = 0;

        [TestMethod]
        public void TestMethod1()
        {
            check++;
            Assert.AreEqual(1, check);
        }

        [TestMethod]
        public void TestMethod2()
        {
            check++;
            Assert.AreEqual(1, check);
        }
    }
}
