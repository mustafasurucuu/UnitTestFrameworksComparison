using System;
using TestReference.Fundamentals;
using Xunit;

namespace DivisibilityTests
{
    public class Divisibility_xUnit
    {
        [Fact]
        public void canDivide3and5Case()
        {
            String result = Divisibility.GetOutput(15);
            Assert.Equal("3and5", result);
        }

        [Fact]
        public void canOnlyDivide3Case()
        {
            String result = Divisibility.GetOutput(9);
            Assert.Equal("only3", result);
        }

        [Fact]
        public void canOnlyDivide5Case()
        {
            String result = Divisibility.GetOutput(10);
            Assert.Equal("only5", result);
        }
    }
}
