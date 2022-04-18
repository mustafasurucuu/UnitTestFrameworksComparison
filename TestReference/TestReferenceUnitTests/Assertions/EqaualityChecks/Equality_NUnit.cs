using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Assert = NUnit.Framework.Assert;

namespace Assertions.EqaualityChecks
{
    [TestFixture]
    public class Equality_NUnit
    {
        [Test]
        public void EqualityChecks()
        {
            bool valueToTest_bool = true;
            string valueToTest_string = "some result";
            DateTime valueToTest_datetime = new DateTime(2019, 01, 01);

            var valueToTest_obj = new { Foo = "bar", Baz = true };
            var expectedValue_obj_equal = new { Foo = "bar", Baz = true };
            var expectedValue_obj_notequal = new { Foo = "zoom", Baz = false };

            Assert.That(valueToTest_bool, Is.EqualTo(true));
            Assert.That(valueToTest_string, Is.EqualTo("some result"));
            Assert.That(valueToTest_datetime, Is.EqualTo(new DateTime(2019, 01, 01)));
            Assert.That(valueToTest_obj, Is.EqualTo(expectedValue_obj_equal));

            Assert.That(valueToTest_bool, Is.Not.EqualTo(false));
            Assert.That(valueToTest_string, Is.Not.EqualTo("some other result"));
            Assert.That(valueToTest_datetime, Is.Not.EqualTo(new DateTime(2019, 12, 01)));
            Assert.That(valueToTest_obj, Is.Not.EqualTo(expectedValue_obj_notequal));
        }
    }
}
