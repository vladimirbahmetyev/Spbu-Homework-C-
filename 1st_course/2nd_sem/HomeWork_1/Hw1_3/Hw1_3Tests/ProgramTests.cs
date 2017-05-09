using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hw13.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        /// <summary>
        /// Проверяет, отсротрирована ли правильно матрица
        /// </summary>
        /// <returns> Ответ на этот вопрос</returns>
        private bool IsArrayAlreadySorted (int[] array)
        {
            bool flag = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                flag = flag && (array[i] <= array[i + 1]);
            }
            return flag;
        }

        [TestMethod()]
        public void SortToIncreaseArrayOf10ElemnetsTest()
        {
            const int sizeOfArray = 10;
            int[] testArray = new int[sizeOfArray] { 1, 6, 7, 3, 7, 2, 1, 8, 17, 0 };
            Program.Sort(testArray);
            Assert.IsTrue(IsArrayAlreadySorted(testArray));
        }

        [TestMethod()]
        public void SortToIncreaseArrayOf3EqualElemnetsTest()
        {
            const int sizeOfArray = 3;
            int[] testArray = new int[sizeOfArray] { 1, 1, 1};
            Program.Sort(testArray);
            Assert.IsTrue(IsArrayAlreadySorted(testArray));
        }

        [TestMethod()]
        public void SortToIncreaseAlreadeSortedArrayOf3ElemnetsTest4()
        {
            const int sizeOfArray = 3;
            int[] testArray = new int[sizeOfArray] { 1, 2, 3 };
            Program.Sort(testArray);
            Assert.IsTrue(IsArrayAlreadySorted(testArray));
        }
    }
}