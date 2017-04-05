using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hw11.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FactorialOf5ShouldBe120Test()
        {
            Assert.AreEqual(120, Program.Factorial(5));
        }

        [TestMethod()]
        public void FactorialOf1ShouldBe1Test()
        {
            Assert.AreEqual(1, Program.Factorial(1));
        }

        [TestMethod()]
        public void FactorialOf3ShouldBe6Test()
        {
            Assert.AreEqual(6, Program.Factorial(3));
        }

        [TestMethod()]
        public void FactorialOf7ShouldBe5040Test()
        {
            Assert.AreEqual(5040, Program.Factorial(7));
        }
    }
}