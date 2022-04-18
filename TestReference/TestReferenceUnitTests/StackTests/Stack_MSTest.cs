using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestReference.Fundamentals;

namespace StackTests
{   
    [TestClass]
    public class Stack_MSTest
    {
        private static TestContext context;
        public static Stack<string> stack;   

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            context = testContext;
            stack = new Stack<string>();    
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            stack.Clear();
            Console.WriteLine(stack.Count.ToString());
        }

        [TestInitialize]
        public void TestInitialize()
        {
            //something..
            //stack = new Stack<string>();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            stack.Clear();
        }

        [TestMethod]
        public void Push_ArgIsNull_ThrowArgIsNullException()
        {
           Assert.ThrowsException<ArgumentNullException>(() => stack.Push(null));           
        }

        [TestMethod]
        public void Push_ValidArg_AddTheObjectToTheStack()
        {
            stack.Push("m");
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.AreEqual(0, stack.Count);
        }

        [TestMethod]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.ThrowsException<InvalidOperationException>(() => stack.Pop());
        }

        [TestMethod]
        public void Pop_StackWithAFewObjects_ReturnObjectOnTheTop()
        {
            stack.Push("v");
            stack.Push("b");
            stack.Push("m");

            var result = stack.Pop();

            Assert.AreEqual("m", result);
        }


        [TestMethod]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop()
        {
            stack.Push("v");
            stack.Push("b");
            stack.Push("m");

            stack.Pop();

            Assert.AreEqual(2, stack.Count);
        }

        [TestMethod]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.ThrowsException<InvalidOperationException>(() => stack.Peek());
        }

        [TestMethod]
        public void Peek_StackWithObjects_ReturnObjectOnTopOfTheStack()
        {
            stack.Push("v");
            stack.Push("b");
            stack.Push("m");

            var result = stack.Peek();

            Assert.AreEqual("m", result);
        }

        [TestMethod]
        public void Peek_StackWithObjects_DoesNotRemoveTheObjectOnTopOfTheStack()
        {
            stack.Push("v");
            stack.Push("b");
            stack.Push("m");

            stack.Peek();

            Assert.AreEqual(3, stack.Count);
        }
    }
}
