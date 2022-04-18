using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Assertions.StringChecks
{
    [TestClass]
    public class StringCheck_MSTest
    {
        [TestMethod]
        public void StringChecks()
        {
            var valueToTest = "Foo Bar Baz Bin";

            StringAssert.Contains(valueToTest, "Bar");
            StringAssert.StartsWith(valueToTest, "Foo");
            StringAssert.EndsWith(valueToTest, "Bin");
            StringAssert.Matches(valueToTest, new Regex("^Foo.*Bin$"));
            StringAssert.DoesNotMatch(valueToTest, new Regex("^Foo.*Bar$"));
        }
    }
}
