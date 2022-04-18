using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace Assertions.ComparisonChecks
{
    [TestClass]
    public class Conditional_NUnit
    {
        [Test]
        public void ComparisonChecks()
        {
            int bigNumber = int.MaxValue;
            int smallNumber = int.MinValue;
            int zero = 0;

            double notANumber = double.NaN; // NaN == 0D / 0D
            double infinity = double.PositiveInfinity;

            bool trueValue = true;
            bool falseValue = false;

            DateTime jan1 = new DateTime(2019, 01, 01);

            Assert.That(bigNumber, Is.GreaterThan(smallNumber));
            Assert.That(bigNumber, Is.GreaterThanOrEqualTo(smallNumber));

            Assert.That(smallNumber, Is.LessThan(bigNumber));
            Assert.That(smallNumber, Is.LessThanOrEqualTo(bigNumber));

            Assert.That(trueValue, Is.True);
            Assert.That(falseValue, Is.False);

            Assert.That(bigNumber, Is.Positive);
            Assert.That(bigNumber, Is.Not.Negative);
            Assert.That(smallNumber, Is.Negative);
            Assert.That(smallNumber, Is.Not.Positive);

            Assert.That(zero, Is.Zero);
            Assert.That(bigNumber, Is.Not.Zero);

            Assert.That(notANumber, Is.NaN);
            Assert.That(infinity, Is.Not.NaN);

            Assert.That(zero, Is.InRange(-100, 5));
            Assert.That(zero, Is.Not.InRange(1, 10));
            Assert.That(jan1, Is.InRange(new DateTime(2018, 01, 01), new DateTime(2019, 12, 31)));

            //Assert.That(zero, Is.AnyOf(42, 0, 100));

            Assert.That(2.333333d, Is.EqualTo(2.3).Within(0.5));
            Assert.That(jan1, Is.EqualTo(new DateTime(2019, 01, 10)).Within(10).Days);
            Assert.That(95, Is.EqualTo(100).Within(8).Percent);
        }
    }
}
