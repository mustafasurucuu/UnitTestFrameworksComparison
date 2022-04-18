using Xunit;

namespace TestIsolation
{

    public class TestIsolatıon_xUnit
    {
        private int check = 0;

        [Fact]
        public void TestMethod1()
        {
            check++;
            Assert.Equal(1, check);
        }

        [Fact]
        public void TestMethod2()
        {
            check++;
            Assert.Equal(1, check);
        }
    }
}
