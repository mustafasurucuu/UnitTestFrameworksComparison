using NUnit.Framework;

namespace Assertions.MultipleCriteria
{
    [TestFixture]
    public class MultipleCondition_NUnit
    {
        
        //+1 point for NUnit
        [Test]
        public void MultipleCriteriaChecks_1()
        {
            object aNumber = 5.0;

            Assert.That(aNumber, Is.AssignableTo<int>().Or.AssignableTo<double>());
            Assert.That(aNumber, Is.GreaterThanOrEqualTo(0).And.LessThanOrEqualTo(10));
        }
        
        //+1 point for NUnit
        [Test]
        public void MultipleCriteriaChecks_2()
        {
            object aNumber = 5.0;

            Assert.Multiple(() =>
            {
                Assert.That(aNumber, Is.AssignableTo<double>());
                Assert.That(aNumber, Is.InRange(0.0, 10.0));
            }
            );
        }
    }
}
