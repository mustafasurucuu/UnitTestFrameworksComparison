using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestReference.Fundamentals;
using System;

namespace DivisibilityTests
{
    [TestClass]
    public class Divisibility_MSTest
    {
        [TestMethod]
        public void canDivide3and5Case()
        {
            String result = Divisibility.GetOutput(15);
            Assert.AreEqual("3and5", result);
        }

        [TestMethod]
        public void canOnlyDivide3Case()
        {
            String result = Divisibility.GetOutput(9);
            Assert.AreEqual("only3", result);
        }

        [TestMethod]
        public void canOnlyDivide5Case()
        {
            String result = Divisibility.GetOutput(10);
            Assert.AreEqual("only5", result);
        }
    }
}
