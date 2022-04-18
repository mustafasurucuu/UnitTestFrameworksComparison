using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math = TestReference.Fundamentals.Math;

//[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]

namespace MathTests
{
    [TestClass]
    public class Math_MSTest_1
    {
        private Math math;

        [TestInitialize]
        public void TestInitialize()
        {
            math = new Math();
        }

        [TestMethod]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = math.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        //[Ignore]
        public void Max_WhenCalled_ReturnTheGreaterArgument()
        {
            var result = math.Max(2, 3);
            Assert.AreEqual(3, result);
        }
    }    
}
