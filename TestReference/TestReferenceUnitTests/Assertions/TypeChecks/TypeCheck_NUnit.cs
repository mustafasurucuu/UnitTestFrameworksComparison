using NUnit.Framework;
using System.Collections.Generic;

namespace Assertions.TypeChecks
{
    [TestFixture]
    public class TypeCheck_NUnit
    {
        [Test]
        public void TypeChecks()
        {
            IList<string> stringList = new List<string>();
            IEnumerable<int> intEnumerable = new int[] { };

            Assert.That("foo", Is.AssignableFrom(typeof(string)));
            Assert.That("foo", Is.AssignableFrom<string>());

            Assert.That("foo", Is.Not.AssignableFrom(typeof(int)));
            Assert.That("foo", Is.Not.AssignableFrom<int>());


            Assert.That(stringList, Is.InstanceOf(typeof(List<string>)));
            Assert.That(stringList, Is.InstanceOf<List<string>>());

            Assert.That(intEnumerable, Is.Not.InstanceOf(typeof(List<int>)));
            Assert.That(intEnumerable, Is.Not.InstanceOf<List<int>>());

            Assert.That(stringList, Is.AssignableTo(typeof(IEnumerable<string>)));
            Assert.That(stringList, Is.AssignableTo<IEnumerable<string>>());

            Assert.That(stringList, Is.Not.AssignableTo(typeof(string[])));
            Assert.That(stringList, Is.Not.AssignableTo<string[]>());


            Assert.That(intEnumerable, Is.TypeOf(typeof(int[])));
            Assert.That(intEnumerable, Is.TypeOf<int[]>());


            Assert.That(stringList, Is.Not.TypeOf(typeof(IEnumerable<string>))); 
            Assert.That(stringList, Is.Not.TypeOf<IEnumerable<string>>()); 

        }
    }
}
