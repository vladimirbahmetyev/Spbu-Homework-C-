using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hw24.Tests
{
    [TestClass()]
    public class StackOnArrayTests
    {
        private StackOnArray testStack;
        [TestInitialize]
        public void Initialize()
        {
            testStack = new StackOnArray();
        }
        [TestMethod()]
        public void PushOneToStackLengthShouldBeOne()
        {
            testStack.Push(1);
            Assert.AreEqual(1, testStack.GetLength());
        }

        [TestMethod()]
        public void PushOneAndPopShouldBeOne()
        {
            testStack.Push(1);
            Assert.AreEqual(1, testStack.Pop());
        }

        [TestMethod()]
        public void PeekTestSouldBeFve()
        {
            testStack.Push(1);
            testStack.Push(3);
            testStack.Push(5);
            Assert.AreEqual(5, testStack.Peek());
        }

        [TestMethod()]
        public void GetLengthTestShouldBeThree()
        {
            testStack.Push(1);
            testStack.Push(3);
            testStack.Push(5);
            Assert.AreEqual(3, testStack.GetLength());
        }

        [TestMethod()]
        public void IsEmptyTest()
        {
            testStack.Push(1);
            testStack.Push(3);
            testStack.Push(5);
            Assert.IsFalse(testStack.IsEmpty());
        }
    }
}