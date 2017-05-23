using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Hw42.Tests
{  
    [TestClass()]
    public class ListTest
    {
        private UniqueList testHead;

        [TestInitialize]
        public void Initialize()
        {
            testHead = new UniqueList();
        }

        [TestMethod()]
        public void AddNewValueToUniqueListTest()
        {
            testHead.AddValueToPosition(1,0);
            Assert.IsTrue(testHead.IsContainedElementInList(1));
        }

        [TestMethod()]
        public void DeleteElementFromUniqueListTest()
        {
            testHead.AddValueToPosition(1, 0);
            testHead.DeleteElementFromList(1);
            Assert.IsFalse(testHead.IsContainedElementInList(1));
        }

        [TestMethod()]
        [ExpectedException(typeof(AddException))]
        public void AddExceptionTest()
        {
            testHead.AddValueToPosition(1, 0);
            testHead.AddValueToPosition(1, 0);
        }

        [TestMethod()]
        [ExpectedException(typeof(DeleteException))]
        public void DeleteExceptionTest()
        {
            testHead.AddValueToPosition(1, 0);
            testHead.DeleteElementFromUniqueList(2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ChangeException))]
        public void ChangeValueByPositionExceptionTest()
        {
            testHead.AddValueToPosition(2, 0);
            testHead.AddValueToPosition(1, 0);
            testHead.ChangeValueByPosition(1, 1);
        }
    }
}