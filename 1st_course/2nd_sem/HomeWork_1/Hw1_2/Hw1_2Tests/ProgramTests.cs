using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hw12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw12.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Fibonacci1ShouldBe1Test()
        {
            Assert.AreEqual(1, Program.Fibonacci(1));
        }

        [TestMethod()]
        public void Fibonacci2ShouldBe1Test()
        {
            Assert.AreEqual(1, Program.Fibonacci(2));
        }

        [TestMethod()]
        public void Fibonacci6ShouldBe8Test()
        {
            Assert.AreEqual(8, Program.Fibonacci(6));
        }

        [TestMethod()]
        public void Fibonacci10ShouldBe55Test()
        {
            Assert.AreEqual(55, Program.Fibonacci(10));
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Fibonacci0ShouldBeExceptionTest()
        {
            Assert.AreEqual(0, Program.Fibonacci(0));
        }
    }
}