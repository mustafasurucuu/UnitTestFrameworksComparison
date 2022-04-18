using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Assert = Xunit.Assert;

namespace Assertions.ComparisonChecks
{
    public class Contiditonal_xUnit
    {
        [Fact]
        public void ComparisonChecks()
        {
            int bigNumber = int.MaxValue;
            int smallNumber = int.MinValue;
            int zero = 0;
            
            bool trueValue = true;
            bool falseValue = false;

            DateTime jan1 = new DateTime(2019, 01, 01);

            // Constraint-style asserts:
            Assert.True(bigNumber > smallNumber);
            Assert.True(bigNumber >= smallNumber);

            Assert.True(smallNumber < bigNumber);
            Assert.True(smallNumber <= bigNumber);

            Assert.True(trueValue);
            Assert.False(falseValue);

            Assert.InRange(zero, -100, 5);
            Assert.NotInRange(zero, 1, 10);
            Assert.InRange(jan1, new DateTime(2018, 01, 01), new DateTime(2019, 12, 31));
        }
    }
}
