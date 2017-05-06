using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw32
{
    // <summary>
    /// Function for hashing
    /// </summary>
    public class HashFunction1 : IHashFunction
    {
        /// <summary>
        /// Getting hash value
        /// </summary>
        /// <param name="word">Word for hashing</param>
        /// <returns>Hash value</returns>
        public uint GetHash(string word)
        {
            uint hash = 1701;

            foreach (var symbol in word)
            {
                hash = 2402 * hash + symbol;
            }

            return hash;
        }
    }
}
