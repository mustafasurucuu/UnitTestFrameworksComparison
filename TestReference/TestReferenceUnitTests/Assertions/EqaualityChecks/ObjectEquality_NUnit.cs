using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace Assertions.EqaualityChecks
{
    [TestFixture]
    public class ObjectEquality_NUnit
    {
        [Test]
        public void SameObjectChecks()
        {
            var valueToTest = new { Foo = "bar", Baz = true };
            var expectedValue_same = valueToTest;
            var expectedValue_notsame = new { Foo = "bar", Baz = true }; ;

            Assert.That(valueToTest, Is.SameAs(expectedValue_same));
            Assert.That(valueToTest, Is.Not.SameAs(expectedValue_notsame));
        }
    }
}
