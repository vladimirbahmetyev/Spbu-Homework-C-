using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hw71.Tests
{
    [TestClass()]
    public class ListTests
    {
        private List<int> list;

        [TestInitialize]
        public void Initialize()
        {
            list = new List<int>();
        }

        [TestMethod()]
        public void AddFiveToSecondPositionTest()
        {
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(5, 2);
            Assert.AreEqual(list.GetValueByPosition(2), 5);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddFiveToEmptyListOnSecondPositionExceptionTest()
        {
            list.AddValueToPosition(5, 2);
        }

        [TestMethod()]
        public void GetValueByZeroPositionTest()
        {
            list.AddValueToPosition(1, 0);
            Assert.AreEqual(1, list.GetValueByPosition(0));
        }

        [TestMethod()]
        public void ChangeFiveBySecondPositionTest()
        {
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(5, 2);
            list.ChangeValueByPosition(1, 2);
            bool flag = true;
            for (int i = 0; i < list.GetLength(); i++)
            {
                flag = flag && (1 == list.GetValueByPosition(i));
            }
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void RemoveFiveFromListTest()
        {
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(1, 0);
            list.AddValueToPosition(5, 2);
            list.RemoveElementFromPosition(2);
            for (int i = 0; i < list.GetLength(); i++)
            {
                Assert.AreEqual(1, list.GetValueByPosition(i));
            }
        }

        [TestMethod]
        public void EnumeratorForEmptyListTest()
        {
            foreach (var element in list)
            {

            }
        }

        [TestMethod]
        public void EnumeratorForListOfOneElementTest()
        {
            list.AddValueToPosition(1, 0);
            foreach (var element in list)
            {
                Assert.AreEqual(1, element);
            }
        }

        [TestMethod]
        public void EnumeratorForListOfFiftyOneElementsTest()
        {
            for (int i = 0; i <= 50; i++)
            {
                list.AddValueToPosition(50 - i, i);
            }

            bool[] chekValue = new bool[51];
            for (int i = 0; i <= 50; i++)
            {
                chekValue[i] = false;
            }

            foreach (int element in list)
            {
                chekValue[element] = true;
            }
            for (int i = 0; i <= 50; i++)
            {
                Assert.IsTrue(chekValue[i]);
            }
        }
    }
}