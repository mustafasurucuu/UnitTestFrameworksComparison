using NUnit.Framework;
using System.Linq;

namespace Assertions.CollectionChecks
{
    [TestFixture]
    public class CollectionCheck_NUnit
    {
        [Test]
        public void CollectionChecks()
        {
            var objArr = new object[] { new object(), 42, "my string" };
            var stringArr = new object[] { "foo", "bar", "baz", "bin", "" };
            var intList = Enumerable.Range(0, 100);

            Assert.That(stringArr, Is.All.TypeOf<string>());
            Assert.That(intList, Is.All.GreaterThanOrEqualTo(0));
            Assert.That(objArr, Is.All.Not.Null);

            Assert.That(intList, Is.Unique);

            Assert.That(intList, Is.EqualTo(Enumerable.Range(0, 100)));
            Assert.That(intList, Is.Not.EqualTo(Enumerable.Range(1, 5)));

            Assert.That(stringArr, Is.EquivalentTo(new string[] { "bar", "baz", "", "bin", "foo" }));
            Assert.That(stringArr, Is.Not.EquivalentTo(new string[] { "bar", "baz" }));

            Assert.That(stringArr, Has.Member("foo"));
            Assert.That(stringArr, Does.Contain("foo"));
            Assert.That(stringArr, Contains.Item("foo"));

            Assert.That(stringArr, Has.No.Member("zoom"));
            Assert.That(stringArr, Does.Not.Contain("zoom"));

            Assert.That(Enumerable.Range(5, 20), Is.SubsetOf(intList));
            Assert.That(Enumerable.Range(-1, 1), Is.Not.SubsetOf(intList));

            Assert.That(intList, Is.SupersetOf(Enumerable.Range(5, 20)));
            Assert.That(intList, Is.Not.SupersetOf(Enumerable.Range(-1, 1)));

            Assert.That(new int[] { }, Is.Empty);
            Assert.That(intList, Is.Not.Empty);

            Assert.That(new int[] { 1, 2, 3 }, Is.Ordered);
            Assert.That(new int[] { 2, 1, 3 }, Is.Not.Ordered);

            string[] sarray = new string[] { "a", "aa", "aaa" };
            Assert.That(sarray, Is.Ordered.By("Length"));
            Assert.That(sarray, Is.Ordered.Ascending.By("Length"));

            Assert.That(intList, Has.Exactly(100).Items);
            Assert.That(intList, Has.Exactly(50).Items.GreaterThanOrEqualTo(50));

            Assert.That(intList, Has.None.LessThan(0));
            Assert.That(objArr, Has.Some.TypeOf<string>());
            Assert.That(intList, Has.All.GreaterThanOrEqualTo(0));
        }
    }
}
