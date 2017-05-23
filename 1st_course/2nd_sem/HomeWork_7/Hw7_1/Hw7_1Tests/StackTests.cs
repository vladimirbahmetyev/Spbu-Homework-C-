using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hw71.Tests
{
    [TestClass()]
    public class StackTests
    {
        private Stack<int> testStack;

        [TestInitialize]
        public void Initialize()
        {
            testStack = new Stack<int>();
        }

        [TestMethod()]
        public void PushZeroToStackTest()
        {
            testStack.Push(0);
            Assert.AreEqual(0, testStack.Pop());
            Assert.IsTrue(testStack.IsStackEmpty());
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PopFromTheEmptyStackShouldTest()
        {
            testStack.Pop();
        }

        [TestMethod()]
        public void PushAndPopTestWithOneAndTwo()
        {
            testStack.Push(1);
            testStack.Push(2);
            Assert.AreEqual(2, testStack.Pop());
            Assert.AreEqual(1, testStack.Pop());
        }

        [TestMethod()]
        public void CheckingIfStackReallyEmpty()
        {
            Assert.IsTrue(testStack.IsStackEmpty());
        }
    }
}