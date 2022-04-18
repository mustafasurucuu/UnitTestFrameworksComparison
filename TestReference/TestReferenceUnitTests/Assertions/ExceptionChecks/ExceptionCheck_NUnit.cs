using NUnit.Framework;
using System;

namespace Assertions.ExceptionChecks
{
    [TestFixture]
    public class ExceptionCheck_NUnit
    {
        [Test]
        public void ExceptionChecks()
        {
            void MethodThatThrows() { throw new ArgumentException(); }

            Assert.That(() => { return; }, Throws.Nothing);

            Assert.That(MethodThatThrows, Throws.ArgumentException);
            Assert.That(MethodThatThrows, Throws.TypeOf<ArgumentException>());

            Assert.That(() => throw new Exception("message"),
                Throws.InstanceOf<Exception>()
                    .And.With.Property(nameof(Exception.Message)).EqualTo("message"));

            Assert.That(() => throw new ApplicationException("message"),
                Throws.TypeOf<ApplicationException>());

            Assert.That(() => throw new ApplicationException("message"),
                Throws.InstanceOf<Exception>());

        }
    }
}
