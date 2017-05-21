using System;

namespace Hw32
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
            public string value{ get; set; }
            /// <summary>
            /// Указатель на следующий элемент списка
            /// </summary>
            public ListElement next {get; set;}
            /// <summary>
            /// Конструктор для класса ListElement
            /// </summary>
            /// <param name="value">Значение элемента</param>
            /// <param name="next">указатель на следующий элемент</param>
            public ListElement (string value, ListElement next)
           {
                this.value = value;
                this.next = next;
           }
        }

        /// <summary>
        /// Указатель на первый элемент списка
        /// </summary>
        private ListElement head;

        /// <summary>
        /// Длина списка
        /// </summary>
        public int length;

        /// <summary>
        /// Добавление элемента на n-ую корректную позицию\
        /// n >= 0
        /// position не может быть больше length
        /// </summary>
        /// <param name="value">Значение нового элемента</param>
        /// <param name="position">Позиция нового элемента</param>
        public void AddValueToPosition(string value, int position)
        {
            if (position < 0 || position > length)
            {
                throw new InvalidOperationException("Некорректная позиция!");
            }
            if (position == 0)
            {
                head = new ListElement(value, head);
                length++;
                return;
            }
            ListElement cursor = head;
            for (var i = 0; i < position - 1; i++)
            {
                cursor = cursor.next;
                var newElement = new ListElement(value, cursor.next);
                cursor.next = newElement;
                length++;
            }
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
                throw new InvalidOperationException("Некорректная позиция");
            }

            var cursor = head;
            for (var i = 0; i < position; ++i)
            {
                cursor = cursor.next;
            }

            return cursor.value;
        }

        /// <summary>
        /// Смена значения элемента на n-ой позиции на новое
        /// n >= 0
        /// position не может быть больше length
        /// </summary>
        /// <param name="value">Новое значение</param>
        /// <param name="position">Позиция заменяемого элемента</param>
        public void ChangeValueByPosition (string value, int position)
        {
            if (position < 0 || position >= length)
            {
                throw new InvalidOperationException("Некорректная позиция!");
            }
            ListElement cursor = head;
            for (int i = 0; i< position; i++)
            {
                cursor = cursor.next;
            }
            cursor.value = value;
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
                throw new InvalidOperationException("Некорректная позиция");
            }
            if (position == 0)
            {
                head = head.next;
                length--;
                return;
            }
            ListElement cursor = head;
            for (int i = 0; i < position - 1; i++)
            {
                cursor = cursor.next;
                cursor.next = cursor.next.next;
                length--;
            }
        }

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

        /// <summary>
        /// Выдает кол-во элементов в Списке
        /// </summary>
        /// <returns></returns>
        public int GetLength() => length;
    }
}
