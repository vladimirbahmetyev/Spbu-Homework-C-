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
        [ExpectedException(typeof(PushException))]
        public void PushExceptionTest()
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
    }
}