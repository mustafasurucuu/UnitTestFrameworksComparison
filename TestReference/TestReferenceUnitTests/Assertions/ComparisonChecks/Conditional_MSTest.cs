using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assertions.ComparisonChecks
{
    [TestClass]
    public class Conditional_MSTest
    {
        [TestMethod]
        public void ComparisonChecks()
        {
            int bigNumber = int.MaxValue;
            int smallNumber = int.MinValue;

            bool trueValue = true;
            bool falseValue = false;

            Assert.IsTrue(bigNumber > smallNumber);
            Assert.IsTrue(bigNumber >= smallNumber);

            Assert.IsTrue(smallNumber < bigNumber);
            Assert.IsTrue(smallNumber <= bigNumber);

            Assert.IsTrue(trueValue);
            Assert.IsFalse(falseValue);
        }
    }
}
