using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Assert = Xunit.Assert;

namespace Assertions.EqaualityChecks
{
    public class ObjectEquality_xUnit
    {
        [Fact]
        public void SameObjectChecks()
        {
            var valueToTest = new { Foo = "bar", Baz = true };
            var expectedValue_same = valueToTest;
            var expectedValue_notsame = new { Foo = "bar", Baz = true };

            Assert.Same(expectedValue_same, valueToTest);
            Assert.NotSame(expectedValue_notsame, valueToTest);
        }
    }
}
