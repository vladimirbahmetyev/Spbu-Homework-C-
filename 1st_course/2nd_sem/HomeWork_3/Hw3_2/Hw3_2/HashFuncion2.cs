using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw32
{
    /// <summary>
    /// Function for hashing
    /// </summary>
    public class HashFunction2 : IHashFunction
    {
        /// <summary>
        /// Getting hash value
        /// </summary>
        /// <param name="word">Word for hashing</param>
        /// <returns>Hash value</returns>
        public uint GetHash(string word)
        {
            uint hash = 0;

            foreach (var symbol in word)
            {
                hash = hash * 666 + symbol + 1701;
            }

            return hash;
        }
    }
}
