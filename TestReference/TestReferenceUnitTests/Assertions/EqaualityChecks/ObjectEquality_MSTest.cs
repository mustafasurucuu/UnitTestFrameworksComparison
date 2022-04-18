using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assertions.EqaualityChecks
{
    [TestClass]
    public class ObjectEquality_MSTest
    {
        [TestMethod]
        public void SameObjectChecks()
        {
            var valueToTest = new { Foo = "bar", Baz = true };
            var expectedValue_same = valueToTest;
            var expectedValue_notsame = new { Foo = "bar", Baz = true };

            Assert.AreSame(expectedValue_same, valueToTest);
            Assert.AreNotSame(expectedValue_notsame, valueToTest);
        }
    }
}
