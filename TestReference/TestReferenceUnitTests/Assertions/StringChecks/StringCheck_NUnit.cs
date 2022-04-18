using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Assertions.StringChecks
{
    [TestFixture]
    public class StringCheck_NUnit
    {
        [Test]
        public void StringChecks()
        {
            var valueToTest = "Foo Bar Baz Bin";

            Assert.That("", Is.Empty);
            Assert.That(valueToTest, Is.Not.Empty);
            Assert.That(valueToTest, Does.Contain("Bar"));
            Assert.That(valueToTest, Does.Not.Contain("Bang"));
            Assert.That(valueToTest, Does.StartWith("Foo"));
            Assert.That(valueToTest, Does.Not.StartWith("Bar"));
            Assert.That(valueToTest, Does.EndWith("Bin"));
            Assert.That(valueToTest, Does.Not.EndWith("Baz"));
            Assert.That(valueToTest, Is.EqualTo("foo bar baz bin").IgnoreCase);
            Assert.That(valueToTest, Is.Not.EqualTo("something else").IgnoreCase);
            Assert.That(valueToTest, Does.Match("^Foo.*Bin$"));
            Assert.That(valueToTest, Does.Not.Match("^Foo.*Bar$"));

        }
    }
}
