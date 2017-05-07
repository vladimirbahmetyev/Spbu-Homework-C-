using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hw42;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw42.Tests
{  
    [TestClass()]
    public class UniqueListTests
    {
        private UniqueList testHead = new UniqueList();

        [TestInitialize]
        public void Initialize()
        {
            UniqueList testHead = new UniqueList();
        }

        [TestMethod()]
        public void AddNewValueToUniqueListTest()
        {
            testHead.AddNewValueToUniqueList(1,0);
            Assert.IsTrue(testHead.IsContainedElementInList(1));
        }

        [TestMethod()]
        public void DeleteElementFromUniqueListTest()
        {
            testHead.AddNewValueToUniqueList(1, 0);
            testHead.DeleteElementFromList(1);
            Assert.IsFalse(testHead.IsContainedElementInList(1));
        }
    }
}