using System;
using Xunit;

namespace Assertions.ExceptionChecks
{
    public class ExceptionCheck_xUnit
    {
        [Fact]
        public void ExceptionChecks()
        {
            void MethodThatThrows() { throw new ArgumentException(); }

            Assert.Throws<ArgumentException>(() => MethodThatThrows());

            Exception ex = Assert.Throws<Exception>((Action)(() => throw new Exception("message")));
            Assert.Equal("message", ex.Message);
        }
    }
}
