using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hw41;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw41.Tests
{
    [TestClass()]
    public class CalculationTreeTests
    {
        private CalculationTree tree;

        [TestInitialize]
        public void Initialize()
        {
            tree = new CalculationTree();
        }

        [TestMethod()]
        public void CalculationTreeTestOne()
        {
            Assert.AreEqual(4, tree.Calculate("(* (+ 1 1 ) 2 )"));
        }

        [TestMethod]
        public void PrintTest()
        {
            tree.Build("(* (+ 1 1 ) 2 )");
            string testString = tree.PrintTree();

            Assert.AreEqual("(* (+ 1 1 ) 2 )", testString);
        }

        [TestMethod()]
        public void CalculationTreeTestTwo()
        {
            Assert.AreEqual(2, tree.Calculate("(/ (- 8 (* (+ 1 1 ) 2 ) ) 2 )"));
        }

        [TestMethod()]
        public void CalculationTreeTestThree()
        {
            Assert.AreEqual(16, tree.Calculate("(* (* 2 (* (+ 1 1 ) 2 ) ) 2 )"));
        }
    }
}