using NUnit.Framework;

namespace TestIsolation
{
    [TestFixture]
    public class TestIsolation_NUnit
    {
        private int check = 0;  

        [Test]
        public void TestMethod1()
        {
            check++;
            Assert.That(check, Is.EqualTo(1));            
        }

        [Test]
        public void TestMethod2()
        {
            check++;
            Assert.That(check, Is.EqualTo(1));
        }
    }
}
