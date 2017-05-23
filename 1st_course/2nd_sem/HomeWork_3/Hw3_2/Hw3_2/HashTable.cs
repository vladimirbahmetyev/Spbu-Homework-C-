using System;

namespace Hw32
{
    /// <summary>
    /// Класс Хэш Таблица
    /// </summary>
    public class HashTable
    {
        /// <summary>
        /// Размер Хэш Таблицы
        /// </summary>
        private const int sizeOfHashTable = 10000;

        /// <summary>
        /// Конструктор Хэш Таблицы
        /// </summary>
        private List[] hashTableElements;

        private IHashFunction hashFunction;

        public HashTable(IHashFunction hashFunction)
        {
            this.hashFunction = hashFunction;
            hashTableElements = new List[sizeOfHashTable];

            for (var i = 0; i < sizeOfHashTable; ++i)
            {
                hashTableElements[i] = new List();
            }
        }
        
        /// <summary>
        /// Преобразует хэш в новый, который подходит для данной таблицы
        /// </summary>
        /// <param name="value">Слово для ключа</param>
        /// <returns>Новый ключ</returns>
        private int HashTableHash(string value)
        {
            return Math.Abs(hashFunction.GetHash(value)) % sizeOfHashTable;
        }

        /// <summary>
        /// Проверяет, есть ли данное слово в Хэш Таблице
        /// </summary>
        /// <param name="inputString">Слово, для проверки</param>
        /// <returns>Логический ответ на данный вопрос</returns>
        public bool IsElementInHashTable(string inputString) => hashTableElements[HashTableHash(inputString)].IsElementInList(inputString);

        /// <summary>
        /// Добавляет новые элемент в Хэш Таблицу
        /// </summary>
        /// <param name="inputString">Новый элемент</param>
        public void AddNewElementToHashTable(string inputString)
        {
            if (!IsElementInHashTable(inputString))
            {
                hashTableElements[HashTableHash(inputString)].AddValueToPosition(inputString, 0);
            }
        }

        /// <summary>
        /// Удаляет элемент из Хэш Таблицы
        /// </summary>
        /// <param name="deleteString">Елемент, который нужно удалить</param>
        public void DeleteElementFromHashTable(string deleteString)
        {
            if (IsElementInHashTable(deleteString))
            {
                hashTableElements[HashTableHash(deleteString)].DeleteElementFromList(deleteString);
            }
        }
    }
}
