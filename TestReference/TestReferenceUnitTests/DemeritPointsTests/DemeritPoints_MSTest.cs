using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestReference.Fundamentals;

namespace DemeritPointsTests
{
    [TestClass]
    public class DemeritPoints_MSTest
    {
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(301)]
        public void SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var calculator = new DemeritPointsCalculator();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculator.CalculateDemeritPoints(speed));
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(64, 0)]
        [DataRow(65, 0)]
        [DataRow(70, 1)]
        [DataRow(75, 2)]       
        public void WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints(speed);

            Assert.AreEqual(expectedResult, points);
        }
    }

    [TestClass]
    public class DemeritPoints_MSTest_FromCsv
    {
        private TestContext testContext;
        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }
    
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @"C:\Users\Dell\Desktop\UnitTestFrameworksComparison\TestReference\TestReference\data\data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void WhenCalled_ReturnDemeritPoints()
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints((int)TestContext.DataRow["speed"]);

            var expectedResult = (int)TestContext.DataRow["expectedResult"];

            Assert.AreEqual(expectedResult, points);
        }
    }
}
