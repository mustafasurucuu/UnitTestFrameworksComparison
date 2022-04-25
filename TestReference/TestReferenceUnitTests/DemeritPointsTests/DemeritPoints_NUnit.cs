using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using TestReference.Fundamentals;

namespace DemeritPointsTests
{
    [TestFixture]
    public class DemeritPoints_NUnit
    {
        //[Parallelizable]
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(speed),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        //[Parallelizable]
        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints(speed);

            Assert.That(points, Is.EqualTo(expectedResult));
        }
    }

    [TestFixture]
    public class DemeritPoints_NUnit_FromIEnum
    {
        [Test, TestCaseSource("GetDataFromIEnum")]
        public void WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints(speed);

            Assert.That(points, Is.EqualTo(expectedResult));
        }

        private static IEnumerable<TestCaseData> GetDataFromIEnum()
        {
            yield return new TestCaseData(0, 0);
            yield return new TestCaseData(64, 0);
            yield return new TestCaseData(65, 0);
            yield return new TestCaseData(70, 1);
            yield return new TestCaseData(75, 2);
        }
    }   
 
}
