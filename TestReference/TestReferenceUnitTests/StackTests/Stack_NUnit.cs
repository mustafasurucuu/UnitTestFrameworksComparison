using NUnit.Framework;
using System;
using TestReference.Fundamentals;

namespace StackTests
{
    [TestFixture]
    public class Stack_NUnit
    {
        private Stack<string> stack;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //ClassInitialize
            stack = new Stack<string>(); 
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            //ClassCleanup
            //stack.Clear(); 
        }

        [SetUp]
        public void SetUp()
        {
            //TestInitialize
            //stack = new Stack<string>(); 
        }

        [TearDown]
        public void TearDown()
        {
            //TestCleanup
            stack.Clear(); 
        }

        [Test]
        public void Push_ArgIsNull_ThrowArgIsNullException()
        {
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArg_AddTheObjectToTheStack()
        {           
            stack.Push("m");
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackWithAFewObjects_ReturnObjectOnTheTop()
        {
            stack.Push("v");
            stack.Push("b");
            stack.Push("m");

            var result = stack.Pop();

            Assert.That(result, Is.EqualTo("m"));
        }

        [Test]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop()
        {
            stack.Push("v");
            stack.Push("b");
            stack.Push("m");

            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackWithObjects_ReturnObjectOnTopOfTheStack()
        {
            stack.Push("v");
            stack.Push("b");
            stack.Push("m");

            var result = stack.Peek();
            Assert.That(result, Is.EqualTo("m"));
        }

        [Test]
        public void Peek_StackWithObjects_DoesNotRemoveTheObjectOnTopOfTheStack()
        {
            stack.Push("v");
            stack.Push("b");
            stack.Push("m");

            stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(3));
        }
    }
}
