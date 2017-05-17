using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        public void SumTest()
        {
            calc.AddValueToStack(15);
            calc.AddValueToStack(37);
            calc.Sum();
            Assert.AreEqual(52, calc.GetAnswer());
        }

        [TestMethod]
        public void SubstractionTest()
        {
            calc.AddValueToStack(15);
            calc.AddValueToStack(5);
            calc.Subtraction();
            Assert.AreEqual(10, calc.GetAnswer());
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            calc.AddValueToStack(12);
            calc.AddValueToStack(12);
            calc.Multiplication();
            Assert.AreEqual(144, calc.GetAnswer());
        }

        [TestMethod]
        public void DivisionTest()
        {
            calc.AddValueToStack(49);
            calc.AddValueToStack(7);
            calc.Division();
            Assert.AreEqual(7, calc.GetAnswer());
        }

        /// <summary>
        /// Выражение: " (8 + 2 * 5) / (1 + 3 * 2 - 4)".
        /// Ответ: 6
        /// </summary>
        [TestMethod]
        public void CalculationTest1()
        {
            calc.AddValueToStack(8);
            calc.AddValueToStack(2);
            calc.AddValueToStack(5);
            calc.Multiplication();
            calc.Sum();
            calc.AddValueToStack(1);
            calc.AddValueToStack(3);
            calc.AddValueToStack(2);
            calc.Multiplication();
            calc.Sum();
            calc.AddValueToStack(4);
            calc.Subtraction();
            calc.Division();
            Assert.AreEqual(6, calc.GetAnswer());
        }

        /// <summary>
        /// Выражение: "(1 + 2) * 4".
        /// Ответ: 12
        /// </summary>
        [TestMethod]
        public void CalculationTest2()
        {
            calc.AddValueToStack(1);
            calc.AddValueToStack(2);
            calc.Sum();
            calc.AddValueToStack(4);
            calc.Multiplication();
            Assert.AreEqual(12, calc.GetAnswer());
        }

        /// <summary>
        /// Выражение: "(9 - 6) * (1 + 2)".
        /// Ответ: 9
        /// </summary>
        [TestMethod]
        public void CalculationTest3()
        {
            calc.AddValueToStack(9);
            calc.AddValueToStack(6);
            calc.Subtraction();
            calc.AddValueToStack(1);
            calc.AddValueToStack(2);
            calc.Sum();
            calc.Multiplication();
            Assert.AreEqual(9, calc.GetAnswer());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetValueFromEmptyStack()
        {
            calc.GetAnswer();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TryToSumOneElement()
        {
            calc.AddValueToStack(1);
            calc.Sum();
        }
    }
}