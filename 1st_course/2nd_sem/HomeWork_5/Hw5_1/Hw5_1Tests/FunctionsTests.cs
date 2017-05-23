using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Hw51.Tests
{
    [TestClass()]
    public class FunctionsTests
    {
        private List<int> testList;
        private List<int> returningList;
        private List<int> emptyList;

        [TestInitialize]
        public void Initialize()
        {
            testList = new List<int> { 1, 2, 3 };
        }

        [TestMethod]
        public void MapTest1()
        {
            returningList = Functions<int>.Map(testList, x => x * 2);

            for (var i = 0; i <= 2; ++i)
            {
                Assert.AreEqual(testList[i] * 2, returningList[i]);
            }
        }

        [TestMethod]
        public void MapTest2()
        {
            returningList = Functions<int>.Map(testList, x => x * 2 - 5 + 11);

            for (var i = 0; i <= 2; ++i)
            {
                Assert.AreEqual(testList[i] * 2 - 5 + 11, returningList[i]);
            }
        }

        [TestMethod]
        public void FilterTest()
        {
            returningList = Functions<int>.Filter(testList, x => (x % 2) == 0);
            Assert.AreEqual(2, returningList[0]);
        }

        [TestMethod]
        public void FoldTest()
        {
            var value = Functions<int>.Fold(testList, 1, (acc, elem) => acc * elem);
            Assert.AreEqual(6, value);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void FilterEmptyListTest()
        {
            returningList = Functions<int>.Filter(emptyList, x => (x % 2) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void MapEmptyListTest()
        {
            returningList = Functions<int>.Map(emptyList, x => x * 2 - 5 + 11);
            Assert.AreEqual(emptyList, returningList);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void FoldEmptyListTest()
        {
            var value = Functions<int>.Fold(emptyList, 1, (acc, elem) => acc * elem);
        }
    }
}