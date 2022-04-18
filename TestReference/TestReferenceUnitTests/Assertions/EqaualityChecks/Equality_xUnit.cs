using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Assert = Xunit.Assert;

namespace Assertions.EqaualityChecks
{
    public class Equality_xUnit
    {
        [Fact]
        public void EqualityChecks()
        {
            string valueToTest_string = "some result";
            DateTime valueToTest_datetime = new DateTime(2019, 01, 01);

            var valueToTest_obj = new { Foo = "bar", Baz = true };
            var expectedValue_obj_equal = new { Foo = "bar", Baz = true };
            var expectedValue_obj_notequal = new { Foo = "zoom", Baz = false };

            Assert.Equal("some result", valueToTest_string);
            Assert.Equal(new DateTime(2019, 01, 01), valueToTest_datetime);
            Assert.Equal(expectedValue_obj_equal, valueToTest_obj);

            Assert.NotEqual("some other result", valueToTest_string);
            Assert.NotEqual(new DateTime(2019, 12, 01), valueToTest_datetime);
            Assert.NotEqual(expectedValue_obj_notequal, valueToTest_obj);
        }
    }
}
