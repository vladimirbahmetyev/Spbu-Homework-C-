using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hw41.Tests
{
    [TestClass]
    public class CalculateTreeTest
    {
        [TestMethod]
        public void BuildTreeTestFromTask()
        {
            CalculationTree tree = new CalculationTree();
            CalculationTree.TreeElement root = tree.BuildTree("( * 1 2 )");

            Assert.AreEqual('*', root.OperatorType);
            Assert.AreEqual(1, root.leftSon.Value);
            Assert.AreEqual(2, root.rigthSon.Value);
        }

        [TestMethod]
        public void PrintTestFromTask()
        {
            CalculationTree tree = new CalculationTree();
            tree.root = tree.BuildTree("(* (+ 1 1 ) 2 )");

            string str = tree.PrintTree();

            Assert.AreEqual("(* (+ 1 1 ) 2 )", str);
        }

        [TestMethod]
        public void CountTestFromTask()
        {
            CalculationTree tree = new CalculationTree();
            tree.root = tree.BuildTree("(* (+ 1 1 ) 2 )");

            Assert.AreEqual(4, tree.CountTree());
        }

        [TestMethod]
        public void CountTestOwnExample()
        {
            CalculationTree tree = new CalculationTree();
            tree.root = tree.BuildTree("(/ (- 8 (* (+ 1 1 ) 2 ) ) 2 )");

            Assert.AreEqual(2, tree.CountTree());
        }
    }
}