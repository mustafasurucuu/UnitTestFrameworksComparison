using System;
using TestReference.Fundamentals;
using Xunit;
//[assembly: CollectionBehavior(CollectionBehavior.CollectionPerAssembly)]
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace ParallelTests_xUnit
{
    public class Performance_xUnit_X
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(301)]
        public void METHOD_A(int speed)
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
        public void METHOD_B(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints(speed);

            Assert.True(expectedResult == points);
        }
    }
    public class Performance_xUnit_Y
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(301)]
        public void METHOD_A(int speed)
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
        public void METHOD_B(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints(speed);

            Assert.True(expectedResult == points);
        }
    }
}
