namespace Hw72
{
    /// <summary>
    /// Класс множество обьектов типа T
    /// </summary>
    public class Set<T>
    {
        /// <summary>
        /// Класс операции над множествами
        /// </summary>
        public class SetOperations
        {
            /// <summary>
            /// Объединение множеств
            /// </summary>
            public static Set<T> UnionSet(Set<T> setOne, Set<T> setTwo)
            {
                Set<T> newSet = new Set<T>();
                foreach (T element in setOne.List)
                {
                    newSet.List.AddValueToPosition(element, 0);
                }
                foreach (T element in setTwo.List)
                {
                    if (!newSet.List.IsContained(element))
                    {
                        newSet.List.AddValueToPosition(element, 0);
                    }
                }
                return newSet;
            }

            /// <summary>
            /// Пересечение множеств
            /// </summary>
            public static  Set<T> Intersection(Set<T> setOne, Set<T> setTwo)
            {
                Set<T> newSet = new Set<T>();
                foreach (T element in setOne.List)
                {
                    if (setTwo.List.IsContained(element))
                    {
                        newSet.List.AddValueToPosition(element, 0);
                    }
                }
                return newSet;
            }

            /// <summary>
            /// Эквивалентность множеств
            /// </summary>
            public static bool AreEqual(Set<T> setOne, Set<T> setTwo)
            {
                foreach (T element in setOne.List)
                {
                    if (!setTwo.List.IsContained(element))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// Операция по добавлению нового элемента в множество
        /// </summary>
        /// <param name="value"></param>
        public void AddValueToSet(T value)
        {
            if (!List.IsContained(value))
            {
               List. AddValueToPosition(value, 0);
            }
        }

        /// <summary>
        /// проверяет, содержится ли элемент в множестве
        /// </summary>
        public bool IsElementInSet(T value) => List.IsContained(value);

        /// <summary>
        /// Удаляет элемент из множества
        /// </summary>
        public void RemoveElementFromSet(T value) => List.DeleteElementFromList(value);

        /// <summary>
        /// Голова множества
        /// </summary>
        private List<T> List { get; set; }

        /// <summary>
        /// конструктор множества
        /// </summary>
        public Set()
        {
            List = new List<T>();
        }
    }
}
