using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace Assertions.ComparisonChecks
{
    [TestFixture]
    public class NullCheck_NUnit
    {
        [Test]
        public void NullChecks()
        {
            var valueToTest = new { Foo = (object)null, Baz = new object() };

            Assert.Null(valueToTest.Foo);
            Assert.IsNull(valueToTest.Foo);
            Assert.NotNull(valueToTest.Baz);
            Assert.IsNotNull(valueToTest.Baz);
        }
    }
}
