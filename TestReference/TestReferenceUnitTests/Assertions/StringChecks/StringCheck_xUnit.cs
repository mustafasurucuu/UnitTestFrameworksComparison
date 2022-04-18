using System;
using System.Text.RegularExpressions;
using Xunit;
using Assert = Xunit.Assert;

namespace Assertions.StringChecks
{
    public class StringCheck_xUnit
    {
        [Fact]
        public void StringChecks()
        {
            var valueToTest = "Foo Bar Baz Bin";

            Assert.Contains("Bar", valueToTest);
            Assert.DoesNotContain("Bang", valueToTest);
            Assert.StartsWith("Foo", valueToTest);
            Assert.EndsWith("Bin", valueToTest);
            Assert.Equal("foo bar baz bin", valueToTest, ignoreCase: true);
            Assert.NotEqual("something else", valueToTest, StringComparer.InvariantCultureIgnoreCase);
            Assert.Matches("^Foo.*Bin$", valueToTest); 
            Assert.Matches(new Regex("^Foo.*Bin$"), valueToTest);
            Assert.DoesNotMatch("^Foo.*Bar$", valueToTest); 
            Assert.DoesNotMatch(new Regex("^Foo.*Bar$"), valueToTest);
        }
    }
}
