namespace Hw32
{
    /// <summary>
    /// Интерфейс хэш функции
    /// </summary>
    public interface IHashFunction
    {
        /// <summary>
        /// Получить ключ по значению
        /// </summary>
        /// <param name="word">Значение, по которому получают ключ</param>
        /// <returns>Ключ</returns>
        int GetHash(string word);
    }
}
