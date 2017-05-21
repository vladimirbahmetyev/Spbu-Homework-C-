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
        public void AddValueTest()
        {
            set.AddValue(1);
            Assert.IsTrue(set.IsElementInSet(1));
        }

        [TestMethod()]
        public void IsElementInSetTest()
        {
            set.AddValue(1);
            set.AddValue(2);
            set.AddValue(3);
            Assert.IsTrue(set.IsElementInSet(2));
        }

        [TestMethod()]
        public void removeElementFromSetTest()
        {
            set.AddValue(1);
            set.AddValue(2);
            set.AddValue(3);
            set.RemoveElementFromSet(2);
            Assert.IsFalse(set.IsElementInSet(2));
        }

        [TestMethod()]
        public void UnionTest()
        {
            firstSet.AddValue(1);
            firstSet.AddValue(2);
            firstSet.AddValue(3);
            secondSet.AddValue(4);
            secondSet.AddValue(5);
            secondSet.AddValue(6);
            var resultSet = Set<int>.UnionSet(firstSet, secondSet);
            for (int i = 1; i < 7; i++)
            {
                Assert.IsTrue(resultSet.IsElementInSet(i));
            }
        }

        [TestMethod()]
        public void IntersectionTest()
        {
            firstSet.AddValue(1);
            firstSet.AddValue(2);
            firstSet.AddValue(3);
            secondSet.AddValue(2);
            secondSet.AddValue(3);
            secondSet.AddValue(4);
            var resultSet = Set<int>.Intersection(firstSet, secondSet);
            Assert.IsTrue(resultSet.IsElementInSet(2));
            Assert.IsTrue(resultSet.IsElementInSet(3));
            Assert.IsFalse(resultSet.IsElementInSet(1));
            Assert.IsFalse(resultSet.IsElementInSet(4));
        }

        [TestMethod]
        public void EqualsTest()
        {
            firstSet.AddValue(1);
            firstSet.AddValue(2);
            firstSet.AddValue(3);
            secondSet.AddValue(1);
            secondSet.AddValue(2);
            secondSet.AddValue(3);
            Assert.IsTrue(Set<int>.AreEqual(firstSet, secondSet));
        }

        [TestMethod]
        public void AddOneElementToSetTwiceTest()
        {
            firstSet.AddValue(1);
            firstSet.AddValue(1);
            Assert.AreEqual(1, firstSet.GetSize());
        }
    }
}