using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hw24.Tests
{
    [TestClass]
    public class StackCalcTest
    {
        private StackCalc calc;

        [TestInitialize]
        public void Initialize()
        {
            calc = new StackCalc(new StackOnArray());
        }

        [TestMethod]
        public void CalculationWithEmptyLineTest()
        {
            Assert.AreEqual(0, calc.Calculation(""));
        }

        [TestMethod]
        public void SumTest()
        {
            Assert.AreEqual(52, calc.Calculation("15 37 +"));
        }

        [TestMethod]
        public void SubstractionTest()
        {
            Assert.AreEqual(10, calc.Calculation("15 5 -"));
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Assert.AreEqual(144, calc.Calculation("12 12 *"));
        }

        [TestMethod]
        public void DivisionTest()
        {
            Assert.AreEqual(7, calc.Calculation("49 7 /"));
        }

        /// <summary>
        /// Expression: " (8 + 2 * 5) / (1 + 3 * 2 - 4)".
        /// The result should be 6
        /// </summary>
        [TestMethod]
        public void CalculationTest1()
        {
            Assert.AreEqual(6, calc.Calculation("8 2 5 * + 1 3 2 * + 4 - /"));
        }

        /// <summary>
        /// Expression: "(1 + 2) * 4".
        /// The result should be 12
        /// </summary>
        [TestMethod]
        public void CalculationTest2()
        {
            Assert.AreEqual(12, calc.Calculation("1 2 + 4 *"));
        }

        /// <summary>
        /// Expression: "(9 - 6) * (1 + 2)".
        /// The result should be 9
        /// </summary>
        [TestMethod]
        public void CalculationTest3()
        {
            Assert.AreEqual(9, calc.Calculation("9 6 - 1 2 + *"));
        }
    }
}