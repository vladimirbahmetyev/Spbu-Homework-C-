using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hw51.Tests
{
    [TestClass()]
    public class FunctionsTests
    {
        private List<int> testList;
        private List<int> returningList;

        [TestInitialize]
        public void Initialize()
        {
            testList = new List<int> { 1, 2, 3 };
        }
        [TestMethod]
        public void MapTest1()
        {
            returningList = Functions.Map(testList, x => x * 2);

            for (var i = 0; i <= 2; ++i)
            {
                Assert.AreEqual(testList[i] * 2, returningList[i]);
            }
        }

        [TestMethod]
        public void MapTest2()
        {
            returningList = Functions.Map(testList, x => x * 2 - 5 + 11);

            for (var i = 0; i <= 2; ++i)
            {
                Assert.AreEqual(testList[i] * 2 - 5 + 11, returningList[i]);
            }
        }

        [TestMethod]
        public void FilterTest()
        {
            returningList = Functions.Filter(testList, x => (x % 2) == 0);
            Assert.AreEqual(2, returningList[0]);
        }

        [TestMethod]
        public void FoldTest()
        {
            var value = Functions.Fold(testList, 1, (acc, elem) => acc * elem);
            Assert.AreEqual(6, value);
        }
    }
}