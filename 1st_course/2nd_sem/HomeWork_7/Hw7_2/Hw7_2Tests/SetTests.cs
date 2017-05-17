using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hw72.Tests
{
    [TestClass()]
    public class SetTests
    {
        private Set<int> set;
        private Set<int> firstSet;
        private Set<int> secondSet;

        [TestInitialize]
        public void Initialize()
        {
            set = new Set<int>();
            firstSet = new Set<int>();
            secondSet = new Set<int>();
        }

        [TestMethod()]
        public void AddValueToSetTest()
        {
            set.AddValueToSet(1);
            Assert.IsTrue(set.IsElementInSet(1));
        }

        [TestMethod()]
        public void IsElementInSetTest()
        {
            set.AddValueToSet(1);
            set.AddValueToSet(2);
            set.AddValueToSet(3);
            Assert.AreEqual(true, set.IsElementInSet(2));
        }

        [TestMethod()]
        public void removeElementFromSetTest()
        {
            set.AddValueToSet(1);
            set.AddValueToSet(2);
            set.AddValueToSet(3);
            set.RemoveElementFromSet(2);
            Assert.IsFalse(set.IsElementInSet(2));
        }

        [TestMethod()]
        public void UnionTest()
        {
            firstSet.AddValueToSet(1);
            firstSet.AddValueToSet(2);
            firstSet.AddValueToSet(3);
            secondSet.AddValueToSet(4);
            secondSet.AddValueToSet(5);
            secondSet.AddValueToSet(6);
            var resultSet = Set<int>.SetOperations.UnionSet(firstSet, secondSet);
            for (int i = 1; i < 7; i++)
            {
                Assert.IsTrue(resultSet.IsElementInSet(i));
            }
        }

        [TestMethod()]
        public void IntersectionTest()
        {
            firstSet.AddValueToSet(1);
            firstSet.AddValueToSet(2);
            firstSet.AddValueToSet(3);
            secondSet.AddValueToSet(2);
            secondSet.AddValueToSet(3);
            secondSet.AddValueToSet(4);
            var resultSet = Set<int>.SetOperations.Intersection(firstSet, secondSet);
            Assert.IsTrue(resultSet.IsElementInSet(2));
            Assert.IsTrue(resultSet.IsElementInSet(3));
            Assert.IsFalse(resultSet.IsElementInSet(1));
            Assert.IsFalse(resultSet.IsElementInSet(4));
        }

        [TestMethod]
        public void EqualsTest()
        {
            firstSet.AddValueToSet(1);
            firstSet.AddValueToSet(2);
            firstSet.AddValueToSet(3);
            secondSet.AddValueToSet(1);
            secondSet.AddValueToSet(2);
            secondSet.AddValueToSet(3);
            Assert.IsTrue(Set<int>.SetOperations.AreEqual(firstSet, secondSet));
        }
    }
}