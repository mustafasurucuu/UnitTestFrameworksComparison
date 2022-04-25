using System;
using Xunit;
using Math = TestReference.Fundamentals.Math;

namespace MathTests.xUnit
{    
    //[Collection("sequential")]
    public class Math_xUnit_1 : IDisposable
    {
        private Math math;

        public Math_xUnit_1()
        {
            math = new Math();
        }

        public void Dispose()
        {
            //Dispose
        }

        [Fact]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = math.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact/*(Skip = "gösterim")*/]
        public void Max_WhenCalled_ReturnTheGreaterArgument()
        {
            var result = math.Max(2, 3);
            Assert.Equal(3, result);
        }

    }

    public class Math_xUnit_2 : IDisposable
    {
        private Math math;

        public Math_xUnit_2()
        {
            math = new Math();
        }

        public void Dispose()
        {
            //Dispose
        }

        [Fact]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = math.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact/*(Skip = "gösterim")*/]
        public void Max_WhenCalled_ReturnTheGreaterArgument()
        {
            var result = math.Max(2, 3);
            Assert.Equal(3, result);
        }

    }
}
