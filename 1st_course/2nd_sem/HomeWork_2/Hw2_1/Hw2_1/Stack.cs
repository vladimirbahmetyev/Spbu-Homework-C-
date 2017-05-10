using System;

namespace Hw21
{
    /// <summary>
    /// Класс Стек
    /// </summary>
    public class Stack
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
        /// Указатель на первый элемент стека
        /// </summary>
        private StackElement head = null;

        /// <summary>
        /// Метод, добавляющий один элемент в стек
        /// </summary>
        public void Push(int value) => head = new StackElement(head, value);

        /// <summary>
        /// Метод, возвращающий значение с головы стека
        /// </summary>
        public int Pop()
        {
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            int element = head.Value;
            head = head.Next;
            return element;
        }

        /// <summary>
        /// Метод возвращает true, если стек пустой
        /// </summary>
        public bool IsStackEmpty() => null == head;        
    }
}
