using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using IgnoreAttribute = NUnit.Framework.IgnoreAttribute;
using Math = TestReference.Fundamentals.Math;

[assembly: Parallelizable(ParallelScope.Fixtures)]

namespace MathTests.NUnit
{
    [TestFixture]
    //[Parallelizable(ParallelScope.Children)]
    public class Math_NUnit_1
    {
        private Math math;

        [SetUp]
        public void SetUp()
        {
            math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = math.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        //[Ignore("gösterim")]
        public void Max_WhenCalled_ReturnTheGreaterArgument()
        {
            var result = math.Max(2, 3);
            Assert.That(result, Is.EqualTo(3));
        }
    }

    [TestFixture]
    public class Math_NUnit_2
    {
        private Math math;

        [SetUp]
        public void SetUp()
        {
            math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = math.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        //[Ignore("gösterim")]
        public void Max_WhenCalled_ReturnTheGreaterArgument()
        {
            var result = math.Max(2, 3);
            Assert.That(result, Is.EqualTo(3));
        }
    }
}
