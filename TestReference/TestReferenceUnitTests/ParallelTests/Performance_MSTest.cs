using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestReference.Fundamentals;

//[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]

namespace ParallelTest_MSTest
{
    [TestClass]
    public class Performance_MSTest_X
    {
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(301)]
        public void METHOD_A(int speed)
        {
            var calculator = new DemeritPointsCalculator();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(64, 0)]
        [DataRow(65, 0)]
        [DataRow(66, 0)]
        [DataRow(70, 1)]
        [DataRow(75, 2)]       
        public void METHOD_B(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints(speed);

            Assert.AreEqual(expectedResult, points);
        }
    }

    [TestClass]
    public class Performance_MSTest_Y
    {
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(301)]
        public void METHOD_A(int speed)
        {
            var calculator = new DemeritPointsCalculator();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(64, 0)]
        [DataRow(65, 0)]
        [DataRow(66, 0)]
        [DataRow(70, 1)]
        [DataRow(75, 2)]
        public void METHOD_B(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints(speed);

            Assert.AreEqual(expectedResult, points);
        }
    }
}
