using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hw32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw32.Tests
{
    [TestClass()]
    public class ListTests
    {
        private List list;

        [TestInitialize]
        public void Initialize()
        {
            list = new List();
        }

        [TestMethod()]
        public void AddFiveToSecondPositionTest()
        {
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("5", 2);
            Assert.AreEqual(list.GetValueByPosition(2), "5");
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddFiveToEmptyListOnSecondPositionExceptionTest()
        {
            list.AddValueToPosition("5", 2);
        }

        [TestMethod()]
        public void GetValueByZeroPositionTest()
        {
            list.AddValueToPosition("1", 0);
            Assert.AreEqual("1", list.GetValueByPosition(0));
        }

        [TestMethod()]
        public void ChangeFiveBySecondPositionTest()
        {
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("5", 2);
            list.ChangeValueByPosition("1", 2);
            bool flag = true;
            for (int i = 0; i < list.GetLength(); i++)
            {
                flag = flag && ("1" == list.GetValueByPosition(i));
            }
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void RemoveFiveFromListTest()
        {
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("1", 0);
            list.AddValueToPosition("5", 2);
            list.RemoveElementFromPosition(2);
            for (int i = 0; i < list.GetLength(); i++)
            {
                Assert.AreEqual("1", list.GetValueByPosition(i));
            }
        }
    }
}