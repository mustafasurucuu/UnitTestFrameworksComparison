using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assertions.ExceptionChecks
{
    [TestClass]
    public class ExceptionCheck_MSTest
    {
        [TestMethod]
        public void ExceptionChecks() 
        {
            void MethodThatThrows() { throw new ArgumentException(); }

            Assert.ThrowsException<ArgumentException>(() => MethodThatThrows());
            Assert.ThrowsException<ArgumentException>(() => throw new ArgumentException());

            Exception ex = Assert.ThrowsException<Exception>(() => throw new Exception("message"));
            Assert.AreEqual("message", ex.Message);
        }
    }
}
