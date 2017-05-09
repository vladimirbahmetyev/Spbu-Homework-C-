using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hw14.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TransformMatrixTest3x3()
        {
            int[,] matrix = new int[3, 3] { { 7, 8, 9 }, { 6, 1, 2 }, { 5, 4, 3 } };
            int[] array = new int[matrix.Length];
            array = Program.TransformMatrix(matrix);
            bool flag = true;
            for (int i = 0; i < array.Length - 2; i++)
            {
                flag = flag && (array[i] < array[i + 1]);
            }
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void TransformMatrixTest5x5()
        {
            int[,] matrix = new int[5, 5] { { 21, 22, 23, 24, 25 }, { 20, 7, 8, 9, 10 }, { 19, 6, 1, 2, 11}, { 18, 5, 4, 3,12 }, { 17, 16, 15, 14, 13 } };
            int[] array = new int[matrix.Length];
            array = Program.TransformMatrix(matrix);
            bool flag = true;
            for (int i = 0; i < array.Length - 2; i++)
            {
                flag = flag && (array[i] < array[i + 1]);
            }
            Assert.IsTrue(flag);
        }

        [TestMethod()]
        public void TransformMatrixTest1x1()
        {
            int[,] matrix = new int[1, 1] { { 1 } };
            int[] array = new int[matrix.Length];
            array = Program.TransformMatrix(matrix);
            bool flag = true;
            for (int i = 0; i < array.Length - 2; i++)
            {
                flag = flag && (array[i] < array[i + 1]);
            }
            Assert.IsTrue(flag);
        }
    }
}