using System;

namespace Hw2_3
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
        public HashTable()
        {
            hashTableElements = new List[sizeOfHashTable];

            for (var i = 0; i < sizeOfHashTable; ++i)
            {
                hashTableElements[i] = new List();
            }
        }

        /// <summary>
        /// Функция, создающая ключ по элементу
        /// </summary>
        /// <param name="inputString">Элемент, по которому создается ключ</param>
        /// <returns>Ключ</returns>
        private int HashFunction(string inputString)
        {
            int hash = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                hash = hash + inputString[i] * i + 1701;
            }
            return Math.Abs(hash) % sizeOfHashTable;
        }

        /// <summary>
        /// Проверяет, есть ли данное слово в Хэш Таблице
        /// </summary>
        /// <param name="inputString">Слово, для проверки</param>
        /// <returns>Логический ответ на данный вопрос</returns>
        public bool IsElementInHashTable(string inputString)
        {
            return hashTableElements[HashFunction(inputString)].IsElementInList(inputString);
        }

        /// <summary>
        /// Добавляет новые элемент в Хэш Таблицу
        /// </summary>
        /// <param name="inputString">Новый элемент</param>
        public void AddNewElementToHashTable(string inputString)
        {
            if (!IsElementInHashTable(inputString))
            {
                hashTableElements[HashFunction(inputString)].AddValueToPosition(inputString, 0);
            }
        }

        /// <summary>
        /// Удаляет элемент из Хэш Таблицы
        /// </summary>
        /// <param name="deleteString">Елемент, который нужно удалить</param>
        public void DeleteElementFromHashTable (string deleteString)
        {
            if (IsElementInHashTable(deleteString))
            {
                hashTableElements[HashFunction(deleteString)].DeleteElementFromList(deleteString);
            }
        }

    }
}
