using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Assertions.TypeChecks
{
    [TestClass]
    public class TypeCheck_MSTest
    {
        [TestMethod]
        public void TypeChecks()
        {
            IList<string> stringList = new List<string>();
            IEnumerable<int> intEnumerable = new int[] { };

            Assert.IsInstanceOfType(stringList, typeof(List<string>));
            Assert.IsNotInstanceOfType(intEnumerable, typeof(List<int>));
        }
    }
}
