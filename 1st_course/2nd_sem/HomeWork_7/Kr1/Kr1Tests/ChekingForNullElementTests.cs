using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kr1.Tests
{
    [TestClass()]
    public class ChekingForNullElementTests
    {
        private List<int> listInt;
        private List<string> listString;
        private NullElementList newList;
        private List<bool> listBool;
        private List<double> listDouble;
        private List<char> listChar;

        [TestInitialize]
        public void Initialize()
        {
            listInt = new List<int>();
            newList = new NullElementList();
            listString = new List<string>();
            listBool = new List<bool>();
            listDouble = new List<double>();
            listChar = new List<char>();
        }

        [TestMethod()]
        public void CountNullElementsTestInt()
        {
            listInt.AddValueToPosition(1, 0);
            listInt.AddValueToPosition(1, 0);
            listInt.AddValueToPosition(0, 0);
            Assert.AreEqual(1, listInt.CountNullElements(newList));
        }

        [TestMethod()]
        public void CountNullElementsTestString()
        {
            listString.AddValueToPosition("Hello", 0);
            listString.AddValueToPosition("World", 0);
            listString.AddValueToPosition("!", 0);
            listString.AddValueToPosition("", 0);
            Assert.AreEqual(1, listString.CountNullElements(newList));
        }

        [TestMethod()]
        public void CountNullElementsTestBool()
        {
            listBool.AddValueToPosition(true, 0);
            listBool.AddValueToPosition(false, 0);
            listBool.AddValueToPosition(true, 0);
            listBool.AddValueToPosition(false, 0);
            Assert.AreEqual(2, listBool.CountNullElements(newList));
        }

        [TestMethod()]
        public void CountNullElementsTestDouble()
        {
            listDouble.AddValueToPosition(-1, 0);
            listDouble.AddValueToPosition(1, 0);
            listDouble.AddValueToPosition(-1, 0);
            listDouble.AddValueToPosition(1, 0);
            Assert.AreEqual(2, listDouble.CountNullElements(newList));
        }

        [TestMethod()]
        public void CountNullElementsTestDoubleEmpty()
        {
            Assert.AreEqual(0, listDouble.CountNullElements(newList));
        }

        [TestMethod()]
        public void CountNullElementsTestChar()
        {
            listChar.AddValueToPosition('H', 0);
            listChar.AddValueToPosition('e', 0);
            listChar.AddValueToPosition('l', 0);
            listChar.AddValueToPosition('l', 0);
            listChar.AddValueToPosition('o', 0);
            listChar.AddValueToPosition('w', 0);
            listChar.AddValueToPosition(' ', 0);
            listChar.AddValueToPosition('W', 0);
            listChar.AddValueToPosition('o', 0);
            listChar.AddValueToPosition('r', 0);
            listChar.AddValueToPosition('l', 0);
            listChar.AddValueToPosition('d', 0);
            listChar.AddValueToPosition('!', 0);
            listChar.AddValueToPosition('!', 0);
            listChar.AddValueToPosition('!', 0);
            Assert.AreEqual(3, listChar.CountNullElements(newList));
        }
    }
}