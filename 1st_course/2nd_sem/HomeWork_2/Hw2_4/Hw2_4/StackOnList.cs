using System;

namespace Hw24
{
    /// <summary>
    /// Класс Стек
    /// </summary>
    public class StackOnList : IStack
    {
        /// <summary>
        /// Класс Элемент стека
        /// </summary>
        private class StackElement
        {
            public StackElement Next { get; private set; }
            public int Value { get; private set; }
            public StackElement(StackElement next, int value)
            {
                Next = next;
                Value = value;
            }
        }

        /// <summary>
        /// Кол-во элементов в стеке
        /// </summary>
        private int lentgh;

        /// <summary>
        /// Указатель на первый элемент стека
        /// </summary>
        private StackElement head = null;

        /// <summary>
        /// Метод, добавляющий один элемент в стек
        /// </summary>
        public void Push(int value)
        {
            head = new StackElement(head, value);
            lentgh++;
        }

        /// <summary>
        /// Метод, возвращающий значение с головы стека
        /// </summary>
        public int Pop()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Стек пустой!");
            }
            int element = head.Value;
            head = head.Next;
            lentgh--;
            return element;
        }

        /// <summary>
        /// Метод возвращает true, если стек пустой
        /// </summary>
        public bool IsEmpty() => null == head;

        /// <summary>
        /// Возвращает кол-во элементов в стеке
        /// </summary>
        public int GetLength() => lentgh;

        /// <summary>
        /// Возвращает значение с головы стека
        /// </summary>
        public int Peek()
        {
            if(head == null)
            {
                throw new InvalidOperationException("Стек пустой!");
            }
            return head.Value;
        }
    }
}