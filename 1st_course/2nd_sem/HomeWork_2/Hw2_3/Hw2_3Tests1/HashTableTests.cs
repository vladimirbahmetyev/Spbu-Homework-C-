using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hw2_3.Tests
{
    [TestClass()]
    public class HashTableTests
    {
        private HashTable testHashTable;

        [TestInitialize]
        public void Initialize()
        {
            testHashTable = new HashTable();
        }

        [TestMethod()]
        public void IsElementInHashTableTest()
        {
            testHashTable.AddNewElementToHashTable("Hello");
            Assert.IsTrue(testHashTable.IsElementInHashTable("Hello"));
        }

        [TestMethod()]
        public void AddNewElementToHashTableTest()
        {
            testHashTable.AddNewElementToHashTable("Hello");
            testHashTable.AddNewElementToHashTable("World");
            testHashTable.AddNewElementToHashTable("!");
            Assert.IsTrue(testHashTable.IsElementInHashTable("Hello") && testHashTable.IsElementInHashTable("World") && testHashTable.IsElementInHashTable("!"));
        }

        [TestMethod()]
        public void DeleteElementFromHashTableTest()
        {
            testHashTable.AddNewElementToHashTable("Hello");
            testHashTable.DeleteElementFromHashTable("Hello");
            Assert.IsTrue(!testHashTable.IsElementInHashTable("Hello"));
        }

        [TestMethod()]
        public void AddElementTwiceAndDeleteElementFromHashTableTest()
        {
            testHashTable.AddNewElementToHashTable("Hello");
            testHashTable.AddNewElementToHashTable("Hello");
            testHashTable.DeleteElementFromHashTable("Hello");
            Assert.IsTrue(!testHashTable.IsElementInHashTable("Hello"));
        }
    }
}