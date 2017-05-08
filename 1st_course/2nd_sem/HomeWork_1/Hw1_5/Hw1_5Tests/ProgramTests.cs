using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hw15.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        const int sizeOfString = 2;
        [TestMethod()]
        public void SwapStringTest()
        {
            int[,] testMatrix = new int[sizeOfString,sizeOfString] { { 1,2}, { 3,4 } };
            Program.SwapString(testMatrix, 0, 1);
            Assert.IsTrue(testMatrix[0, 0] == 3 && testMatrix[0, 1] == 4 && testMatrix[1, 0] == 1 && testMatrix[1, 1] == 2);
        }

        [TestMethod()]
        public void MatrixSortTest()
        {
            int[,] testMatrix = new int[3, 2] { { 5, 2 }, { 3, 4 }, { 1,2 } };
            Program.MatrixSort(testMatrix);
            bool flag = true;
            for (int i = 0; i < sizeOfString; i++)
            {
                flag = flag && (testMatrix[i, 0] <= testMatrix[i + 1, 0]);
            }
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void MatrixWithOneStringExceptionTest()
        {
            int[,] testMatrix = new int[1, 1] { { 1 } };
            Program.MatrixSort(testMatrix);
        }
    }
}