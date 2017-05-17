namespace Hw32
{
    // <summary>
    ///Функция для получения ключа
    /// </summary>
    public class HashFunction1 : IHashFunction
    {
        /// <summary>
        /// Получить ключ по значению
        /// </summary>
        /// <param name="word">Значение, по которому получают ключ</param>
        /// <returns>Ключ</returns>
        public int GetHash(string word)
        {
            int hash = 1701;

            foreach (var symbol in word)
            {
                hash = 2402 * hash + symbol;
            }

            return hash;
        }
    }
}
