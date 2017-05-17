using System;
using System.Collections.Generic;

namespace Hw51
{
    /// <summary>
    /// Публичный класс функции
    /// </summary>
    public static class Functions
    {
        /// <summary>
        /// Функция которая принимает функцию, которая преобразует список
        /// </summary>
        /// <param name="oldList">Список, который был изначально</param>
        /// <param name="function">Функция, которая преобразовывает список</param>
        /// <returns>Преобразованный список</returns>
        public static List<int> Map(List<int> oldList, Func<int, int> function)
        {
            var newList = new List<int>();

            foreach (int element in oldList)
            {
                newList.Add(function(element));
            }
            return newList;
        }

        /// <summary>
        /// Функция которая, при помощи другой функции фильтрует список
        /// </summary>
        /// <param name="oldList">Список</param>
        /// <param name="function">Функция, фильтрующая список</param>
        /// <returns>Отфильтрованный список</returns>
        public static List<int> Filter(List<int> oldList, Func<int, bool> function)
        {
            var newList = new List<int>();

            foreach (int element in oldList)
            {
                if (function(element))
                {
                    newList.Add(element);
                }
            }
            return newList;
        }

        /// <summary>
        /// Функция, которая накапливает значение, при помощи другой функции и списка
        /// </summary>
        /// <param name="oldList">Список</param>
        /// <param name="acc">Начальное значение</param>
        /// <param name="function">Функция</param>
        /// <returns>Накопленное значение</returns>
        public static int Fold(List<int> oldList, int acc, Func<int, int, int> function)
        {
            foreach (int element in oldList)
            {
                acc = function(acc, element);
            }
            return acc;
        }
    }
}
