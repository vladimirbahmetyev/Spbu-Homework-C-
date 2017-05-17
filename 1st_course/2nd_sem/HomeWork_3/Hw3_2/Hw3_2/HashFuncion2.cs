namespace Hw32
{
    /// <summary>
    /// Функция для получения ключа
    /// </summary>
    public class HashFunction2 : IHashFunction
    {
        /// <summary>
        /// Получить ключ по значению
        /// </summary>
        /// <param name="word">Значение, по которому получают ключ</param>
        /// <returns>Ключ</returns>
        public int GetHash(string word)
        {
            int hash = 0;

            foreach (var symbol in word)
            {
                hash = hash * 666 + symbol + 1701;
            }

            return hash;
        }
    }
}
