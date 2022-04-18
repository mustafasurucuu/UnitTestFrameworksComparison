using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assertions.EqaualityChecks
{
    [TestClass]
    public class Equality_MSTest
    {
        [TestMethod]
        public void EqualityChecks()
        {
            bool valueToTest_bool = true;
            string valueToTest_string = "some result";
            DateTime valueToTest_datetime = new DateTime(2019, 01, 01);

            var valueToTest_obj = new { Foo = "bar", Baz = true };
            var expectedValue_obj_equal = new { Foo = "bar", Baz = true };
            var expectedValue_obj_notequal = new { Foo = "zoom", Baz = false }; 

            Assert.AreEqual(true, valueToTest_bool);
            Assert.AreEqual("some result", valueToTest_string);
            Assert.AreEqual(new DateTime(2019, 01, 01), valueToTest_datetime);
            Assert.AreEqual(expectedValue_obj_equal, valueToTest_obj);

            Assert.AreNotEqual(false, valueToTest_bool);
            Assert.AreNotEqual("some other result", valueToTest_string);
            Assert.AreNotEqual(new DateTime(2019, 12, 01), valueToTest_datetime);
            Assert.AreNotEqual(expectedValue_obj_notequal, valueToTest_obj);
        }
    }
}
