using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw14
{
    /// <summary>
    /// Программа, которая имеет метод распечатки матрицы по спирали
    /// </summary>
    public class Program
    {
        /// <summary>
        ///Превращает матрицу в массив
        /// </summary>
        /// <returns> Spiral array</returns>
        public static int[] TransformMatrix(int[,] matrix)
        {
            int[] array = new int[matrix.Length];
            int k = 1;
            bool horizontal = true;
            bool vertical = true;
            int[] position = new int[2] { matrix.GetLength(0) / 2, matrix.GetLength(0) / 2 };
            array[0] = matrix[position[0], position[1]];
            for (int i = 1; i <= matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (horizontal)
                    {
                        position[1]++;
                        if (position[1] >= matrix.GetLength(0))
                        {
                            return array;
                        }
                        array[k] = matrix[position[0], position[1]];
                        k++;
                    }
                    else
                    {
                        position[1]--;
                        if (position[1] < 0)
                        {
                            return array;
                        }
                        array[k] = matrix[position[0], position[1]];
                        k++;
                    }
                }
                for (int j = 0; j < i; j++)
                {
                    if (vertical)
                    {
                        position[0]++;
                        if (position[0] >= matrix.GetLength(0))
                        {
                            return array;
                        }
                        array[k] = matrix[position[0], position[1]];
                        k++;
                    }
                    else
                    {
                        position[0]--;
                        if (position[0] < 0)
                        {
                            return array;
                        }
                        array[k] = matrix[position[0], position[1]];
                        k++;
                   }
                }
                horizontal = !horizontal;
                vertical = !vertical;
            }
            return array;
        }

        /// <summary>
        /// Print array
        /// </summary>
        public void PrintArray (int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        /// <summary>
        /// Print Matrix from center to edge
        /// </summary>
        public void PrintMatrix(int[,] matrix)
        {
            int[] array = TransformMatrix(matrix);
            PrintArray(array);
        }

        static void Main(string[] args)
        {        
        }
    }
}
