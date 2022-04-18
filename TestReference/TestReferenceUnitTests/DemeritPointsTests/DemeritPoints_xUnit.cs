using System;
using TestReference.Fundamentals;
using Xunit;

namespace DemeritPointsTests
{   
    public class DemeritPoints_xUnit
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(301)]
        public void SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var calculator = new DemeritPointsCalculator();

            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(64, 0)]
        [InlineData(65, 0)]
        [InlineData(66, 0)]
        [InlineData(70, 1)]
        [InlineData(75, 2)]
        public void WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints(speed);

            Assert.True(expectedResult == points);
        }
    }
}
