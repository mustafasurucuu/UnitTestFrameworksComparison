using TestReference.Fundamentals;
using System;
using NUnit.Framework;

namespace DivisibilityTests
{
    [TestFixture]
    public class Divisibility_NUnit
    {
        [Test]
        public void canDivide3and5Case()
        {
            String result = Divisibility.GetOutput(15);
            Assert.That(result, Is.EqualTo("3and5"));
        }

        [Test]
        public void canOnlyDivide3Case()
        {
            String result = Divisibility.GetOutput(9);
            Assert.That(result, Is.EqualTo("only3"));
        }

        [Test]
        public void canOnlyDivide5Case()
        {
            String result = Divisibility.GetOutput(10);
            Assert.That(result, Is.EqualTo("only5"));
        }
    }
}
