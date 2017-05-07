using System;

namespace Hw42
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
            public int value { get; set; }
            /// <summary>
            /// Указатель на следующий элемент списка
            /// </summary>
            public ListElement next {get; set;}
            /// <summary>
            /// Конструктор для класса ListElement
            /// </summary>
            /// <param name="value">Значение элемента</param>
            /// <param name="next">указатель на следующий элемент</param>
            public ListElement (int value, ListElement next)
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
        public virtual void AddValueToPosition(int value, int position)
        {
            if (position < 0 || position > length)
            {
                throw new InvalidOperationException("Incorrect position!");
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
        public int GetValueByPosition(int position)
        {
            if (position < 0 || position >= length)
            {
                throw new InvalidOperationException("Incorrect position!");
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
        public void ChangeValueByPosition (int value, int position)
        {
            if (position < 0 || position >= length)
            {
                throw new InvalidOperationException("Incorrect position!");
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
        public void RemoveElementFromPosition (int position)
        {
            if (position < 0 || position >= length)
            {
                throw new InvalidOperationException("Incorrect position!");
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
        /// Провеяет, есть ли данный элемент в списке
        /// </summary>
        /// <param name="checkValue">Элемент, который нужно проверить</param>
        /// <returns></returns>
        public bool IsContainedElementInList(int checkValue)
        {
            ListElement cursor = head;
            for (int i = 0; i < length; i++)
            {
                if(cursor.value == checkValue)
                {
                    return true;
                }
                cursor = cursor.next;
            }
            return false;
        }

        /// <summary>
        /// Выдает позицию искомого элемента в списке
        /// </summary>
        /// <param name="value">Искомый элемент</param>
        /// <returns>Позиция искомого элемента</returns>
        private int PositionElementInList(int value)
        {
            ListElement cursor = head;
            for (int i = 0; i < length; i++)
            {
                if (cursor.value == value)
                {
                    return i;
                }
                cursor = cursor.next;
            }
            return -1;
        }

        /// <summary>
        /// Удаляет элемент из списка
        /// </summary>
        /// <param name="value">Элемент который нужно удалить</param>
        public void DeleteElementFromList(int value)
        {
            if(IsContainedElementInList(value))
            {
                RemoveElementFromPosition(PositionElementInList(value));
            }
        }
    }
}
