using System.Collections.Generic;
using Xunit;

namespace Assertions.TypeChecks
{
    public class TypeCheck_xUnit
    {
        [Fact]
        public void TypeChecks()
        {
            IList<string> stringList = new List<string>();
            IEnumerable<int> intEnumerable = new int[] { };

            Assert.IsAssignableFrom<string>("foo");
            Assert.IsType<List<string>>(stringList);
            Assert.IsNotType<List<int>>(intEnumerable);
        }
    }
}
