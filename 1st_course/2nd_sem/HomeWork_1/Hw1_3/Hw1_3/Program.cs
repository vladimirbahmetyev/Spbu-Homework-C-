using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw13
{
    public class Program
    {
        /// <summary>
        /// Sorts array to increase
        /// </summary>
        public static void Sort(int[] array)
        {
            if(array.Length < 2)
            {
                throw new InvalidOperationException();
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = array[i];
                int minNumber = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minNumber = j;
                    }
                }
                array[minNumber] = array[i];
                array[i] = min;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
