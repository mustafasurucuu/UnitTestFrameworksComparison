using System;
using TestReference.Fundamentals;
using Xunit;
using Assert = Xunit.Assert;

namespace StackTests
{
    public class StackFixture : IDisposable
    {
        public Stack<string> stack;
        public StackFixture()
        {
            //Here is ClassInitialize
            stack = new Stack<string>(); 
        }

        public void Dispose()
        {
            //stack.Clear(); //Here is ClassCleanup
        }
    }
    public class Stack_xUnit : IClassFixture<StackFixture>, IDisposable
    {        

        StackFixture fixture;

        public Stack_xUnit(StackFixture fixture)
        {
            this.fixture = fixture; //Here is TestInitialize
        }

        public void Dispose()
        {
            fixture.stack.Clear(); //Here is TestCleanup
        }

        [Fact]
        public void Push_ArgIsNull_ThrowArgIsNullException()
        {
            Assert.Throws<ArgumentNullException>(() => fixture.stack.Push(null));
        }

        [Fact]
        public void Push_ValidArg_AddTheObjectToTheStack()
        {
            fixture.stack.Push("m");
            Assert.Equal(1, fixture.stack.Count);
        }

        [Fact]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.Equal(0, fixture.stack.Count);
        }


        [Fact]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => fixture.stack.Pop());
        }

        [Fact]
        public void Pop_StackWithAFewObjects_ReturnObjectOnTheTop()
        {
            fixture.stack.Push("v");
            fixture.stack.Push("b");
            fixture.stack.Push("m");

            var result = fixture.stack.Pop();

            Assert.Equal("m", result);
        }

        [Fact]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop()
        {
            fixture.stack.Push("v");
            fixture.stack.Push("b");
            fixture.stack.Push("m");

            fixture.stack.Pop();

            Assert.Equal(2, fixture.stack.Count);
        }

        [Fact]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => fixture.stack.Peek());
        }

        [Fact]
        public void Peek_StackWithObjects_ReturnObjectOnTopOfTheStack()
        {
            fixture.stack.Push("v");
            fixture.stack.Push("b");
            fixture.stack.Push("m");

            var result = fixture.stack.Peek();
           Assert.Equal("m", result);
        }

        [Fact]
        public void Peek_StackWithObjects_DoesNotRemoveTheObjectOnTopOfTheStack()
        {
            fixture.stack.Push("v");
            fixture.stack.Push("b");
            fixture.stack.Push("m");

            fixture.stack.Peek();

            Assert.Equal(3, fixture.stack.Count);
        }       
    }
}
