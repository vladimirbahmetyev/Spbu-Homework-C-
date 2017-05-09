using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw11
{
    public class Program
    {
    /// <summary>
    /// Calculating factorial
    /// </summary>
    /// <returns>Factorial of a number</returns>
        public static int Factorial(int n)
        {

            if (n < 1)
            {
                throw new InvalidOperationException();
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}