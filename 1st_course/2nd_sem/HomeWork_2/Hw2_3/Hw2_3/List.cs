using System;

namespace Hw2_3
{
    /// <summary>
    /// Класс связный список
    /// </summary>
    public class List
    {
        /// <summary>
        /// Элемент связного списка
        /// </summary>
        private class ListElement
        {
            /// <summary>
            /// Значение элемента списка
            /// </summary>
            public string Value { get; set; }

            /// <summary>
            /// Указатель на следующий элемент списка
            /// </summary>
            public ListElement Next { get; set; }

            /// <summary>
            /// Конструктор для класса ListElement
            /// </summary>
            /// <param name="Value">Значение элемента</param>
            /// <param name="Next">указатель на следующий элемент</param>
            public ListElement(string value, ListElement next)
            {
                Value = value;
                Next = next;
            }
        }

        /// <summary>
        /// Указатель на первый элемент списка
        /// </summary>
        private ListElement head;

        /// <summary>
        /// Длина списка
        /// </summary>
        private int length;

        /// <summary>
        /// Добавление элемента на n-ую корректную позицию\
        /// n >= 0
        /// position не может быть больше length
        /// </summary>
        /// <param name="Value">Значение нового элемента</param>
        /// <param name="position">Позиция нового элемента</param>
        public void AddValueToPosition(string Value, int position)
        {
            if (position < 0 || position > length)
            {
                throw new InvalidOperationException("Incorrect position!");
            }
            if (position == 0)
            {
                head = new ListElement(Value, head);
                length++;
                return;
            }
            ListElement cursor = head;
            for (var i = 0; i < position - 1; i++)
            {
                cursor = cursor.Next;
            }
            var newElement = new ListElement(Value, cursor.Next);
            cursor.Next = newElement;
            length++;
        }

        /// <summary>
        /// Получение значения n-ого элемента
        /// n >= 0
        /// position не может быть больше length
        /// </summary>
        /// <param name="position">Позиция искомого элемента</param>
        /// <returns></returns>
        public string GetValueByPosition(int position)
        {
            if (position < 0 || position >= length)
            {
                throw new InvalidOperationException("Incorrect position!");
            }

            var cursor = head;
            for (var i = 0; i < position; ++i)
            {
                cursor = cursor.Next;
            }

            return cursor.Value;
        }

        /// <summary>
        /// Смена значения элемента на n-ой позиции на новое
        /// n >= 0
        /// position не может быть больше length
        /// </summary>
        /// <param name="Value">Новое значение</param>
        /// <param name="position">Позиция заменяемого элемента</param>
        public void ChangeValueByPosition(string Value, int position)
        {
            if (position < 0 || position >= length)
            {
                throw new InvalidOperationException("Incorrect position!");
            }
            ListElement cursor = head;
            for (int i = 0; i < position; i++)
            {
                cursor = cursor.Next;
            }
            cursor.Value = Value;
        }

        /// <summary>
        /// Удаление элемента с n-ой позиции
        /// n >= 0
        /// position не может быть больше length
        /// </summary>
        /// <param name="position">Позиция элемента, который нужно удалить</param>
        public void RemoveElementFromPosition(int position)
        {
            if (position < 0 || position >= length)
            {
                throw new InvalidOperationException("Incorrect position!");
            }
            if (position == 0)
            {
                head = head.Next;
                length--;
                return;
            }
            ListElement cursor = head;
            for (int i = 0; i < position - 1; i++)
            {
                cursor = cursor.Next;
            }
            cursor.Next = cursor.Next.Next;
            length--;
        }

        /// <summary>
        /// Вовзращает длину списка
        /// </summary>
        /// <returns></returns>
        public int GetLength() => length;

        /// <summary>
        /// Проверяет, есть ли данный элемент в списке
        /// </summary>
        /// <param name="value">Элемент, который проверяется</param>
        /// <returns>Наличие этого эелемента в списке</returns>
        public bool IsElementInList(string value)
        {
            for (int i = 0; i < length; i++)
            {
                if (GetValueByPosition(i) == value)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Выдает позицию искомого элемента в списке
        /// </summary>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция искомого элемента</returns>
        private int PositionElementInList(string value)
        {
            for (int i = 0; i < length; i++)
            {
                if (GetValueByPosition(i) == value)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Удаляет элемент из списка
        /// </summary>
        /// <param name="deleteString">Элемент, который нужно удалить</param>
        public void DeleteElementFromList(string deleteString)
        {
            if (IsElementInList(deleteString))
            {
                RemoveElementFromPosition(PositionElementInList(deleteString));
            }
        }
    }
}