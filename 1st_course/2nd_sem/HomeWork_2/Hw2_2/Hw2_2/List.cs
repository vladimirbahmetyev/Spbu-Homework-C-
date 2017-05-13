using System;

namespace Hw22
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
            public int Value { get; set; }

            /// <summary>
            /// Указатель на следующий элемент списка
            /// </summary>
            public ListElement Next { get; set; }

            /// <summary>
            /// Конструктор для класса ListElement
            /// </summary>
            /// <param name="Value">Значение элемента</param>
            /// <param name="Next">указатель на следующий элемент</param>
            public ListElement(int value, ListElement next)
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
        public void AddValueToPosition(int Value, int position)
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
        public int GetValueByPosition(int position)
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
        public void ChangeValueByPosition(int Value, int position)
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
    }
}
