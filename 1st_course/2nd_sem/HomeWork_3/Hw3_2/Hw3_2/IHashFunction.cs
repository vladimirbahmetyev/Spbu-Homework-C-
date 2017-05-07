namespace Hw32
{
    /// <summary>
    /// Interface of hash function
    /// </summary>
    public interface IHashFunction
    {
        /// <summary>
        /// Getting hash value
        /// </summary>
        /// <param name="word">Value for hashing</param>
        /// <returns>Hash</returns>
        uint GetHash(string word);
    }
}
