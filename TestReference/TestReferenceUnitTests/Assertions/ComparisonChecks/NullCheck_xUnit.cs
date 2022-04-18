using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Assert = Xunit.Assert;

namespace Assertions.ComparisonChecks
{
    public class NullCheck_xUnit
    {
        [Fact]
        public void NullChecks()
        {
            var valueToTest = new { Foo = (object)null, Baz = new object() };

            Assert.Null(valueToTest.Foo);
            Assert.NotNull(valueToTest.Baz);
        }
    }
}
