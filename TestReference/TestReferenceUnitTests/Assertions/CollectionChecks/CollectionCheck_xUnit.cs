

using System.Linq;
using Xunit;

namespace Assertions.CollectionChecks
{
    public class CollectionCheck_xUnit
    {
        [Fact]
        public void CollectionChecks()
        {
            var objArr = new object[] { new object(), 42, "my string" };
            var stringArr = new string[] { "foo", "bar", "baz", "bin", "" };
            var intList = Enumerable.Range(0, 100);

            Assert.All(stringArr, s => Assert.IsType<string>(s));
            Assert.All(objArr, Assert.NotNull);

            Assert.Equal(Enumerable.Range(0, 100), intList);
            Assert.NotEqual(Enumerable.Range(1, 5), intList);

            Assert.Contains("foo", stringArr);
            Assert.DoesNotContain("zoom", stringArr);

            Assert.Subset(intList.ToHashSet(), Enumerable.Range(5, 20).ToHashSet());
            Assert.Superset(Enumerable.Range(5, 20).ToHashSet(), intList.ToHashSet());

            Assert.Empty(new int[] { });
            Assert.NotEmpty(new int[] { 1, 2 });
        }
    }
}
