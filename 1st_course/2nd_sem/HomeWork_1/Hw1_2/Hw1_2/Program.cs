using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw12
{
    public class Program
    {
        /// <summary>
        /// Calculating Fibonacci number
        /// </summary>
        /// <returns> Fibonacci number n </returns>
        public static int Fibonacci(int n)
        {
            if (n < 1)
            {
                throw new InvalidOperationException();
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
