﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hw21.Tests
{
    [TestClass()]
    public class StackTests
    {
        private Stack testStack;

        [TestInitialize]
        public void Initialize()
        {
           testStack = new Stack();
        }

        [TestMethod()]
        public void PushZeroToStackTest()
        { 
            testStack.Push(0);
            Assert.IsTrue(0 == testStack.Pop());
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