using System;

namespace Hw15
{
    public class Program
    {
        /// <summary>
        /// Swap all elements of two strings in Matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        public static void SwapString(int[,] matrix, int firstString, int secondString)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int timeNumber = matrix[firstString, i];
                matrix[firstString, i] = matrix[secondString, i];
                matrix[secondString, i] = timeNumber;
            }
        }

        /// <summary>
        /// Sort Strings in matrix on first elements
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="sizeOfString"></param>
        /// <param name="countOfString"></param>
        public static void MatrixSort(int[,] matrix)
        {
            if (matrix.GetLength(0) == 1)
            {
                throw new InvalidOperationException();
            }
            const int firstElement = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = matrix[i,firstElement];
                int minNumber = i;
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, firstElement] < min)
                    {
                        min = matrix[j, firstElement];
                        minNumber = j;
                    }
                }
                SwapString(matrix, i, minNumber);
            }
        }
            static void Main(string[] args)
        {
        }
    }
}
