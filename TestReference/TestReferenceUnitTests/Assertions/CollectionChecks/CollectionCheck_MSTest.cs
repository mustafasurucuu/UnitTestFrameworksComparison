using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Assertions.CollectionChecks
{
    [TestClass]
    public class CollectionCheck_MSTest
    {      
        [TestMethod]
        public void CollectionChecks()
        {
            var objArr = new object[] { new object(), 42, "my string" };
            var stringArr = new object[] { "foo", "bar", "baz", "bin", "" };
            var intList = Enumerable.Range(0, 100).ToList();

            CollectionAssert.AllItemsAreInstancesOfType(stringArr, typeof(string));
            CollectionAssert.AllItemsAreNotNull(objArr);

            CollectionAssert.AllItemsAreUnique(intList);

            CollectionAssert.AreEqual(Enumerable.Range(0, 100).ToList(), intList);
            CollectionAssert.AreNotEqual(Enumerable.Range(1, 5).ToList(), intList);

            CollectionAssert.AreEquivalent(new string[] { "bar", "baz", "", "bin", "foo" }, stringArr);
            CollectionAssert.AreNotEquivalent(new string[] { "bar", "baz" }, stringArr);

            CollectionAssert.Contains(stringArr, "foo");
            CollectionAssert.DoesNotContain(stringArr, "zoom");

            CollectionAssert.IsSubsetOf(Enumerable.Range(5, 20).ToList(), intList);
            CollectionAssert.IsNotSubsetOf(Enumerable.Range(-1, 1).ToList(), intList);

        }
    }
}
