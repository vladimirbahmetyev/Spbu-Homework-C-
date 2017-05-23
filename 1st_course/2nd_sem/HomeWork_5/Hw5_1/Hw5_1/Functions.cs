using System;
using System.Collections.Generic;
using System.Collections;

namespace Hw51
{
    /// <summary>
    /// Публичный класс функции
    /// </summary>
    public static class Functions<T>
    {
        /// <summary>
        /// Функция которая принимает функцию, которая преобразует список
        /// </summary>
        /// <param name="oldList">Список, который был изначально</param>
        /// <param name="function">Функция, которая преобразовывает список</param>
        /// <returns>Преобразованный список</returns>
        public static List<T> Map(List<T> oldList, Func<T, T> function)
        {
            if (oldList == null)
            {
                throw new InvalidOperationException("Список пустой!");
            }
            var newList = new List<T>();

            foreach (T element in oldList)
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
        public static List<T> Filter(List<T> oldList, Func<T, bool> function)
        {
            if (oldList == null)
            {
                throw new InvalidOperationException("Список пустой!");
            }

            var newList = new List<T>();

            foreach (T element in oldList)
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
        public static T Fold(List<T> oldList, T acc, Func<T, T, T> function)
        {
            if (oldList == null)
            {
                throw new InvalidOperationException("Список пустой!");
            }
            foreach (T element in oldList)
            {
                acc = function(acc, element);
            }
            return acc;
        }
    }
}
