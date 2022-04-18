using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assertions.ComparisonChecks
{
    [TestClass]
    public class NullCheck_MSTest
    {
        [TestMethod]
        public void NullChecks()
        {
            var valueToTest = new { Foo = (object)null, Baz = new object() };

            Assert.IsNull(valueToTest.Foo);
            Assert.IsNotNull(valueToTest.Baz);
        }
    }
}
