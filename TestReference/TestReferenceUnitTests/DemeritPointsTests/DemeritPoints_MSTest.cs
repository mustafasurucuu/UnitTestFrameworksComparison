﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
}
