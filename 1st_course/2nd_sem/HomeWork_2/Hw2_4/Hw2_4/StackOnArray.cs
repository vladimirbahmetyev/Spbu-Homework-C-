using System;

namespace Hw24
{
    /// <summary>
    /// Стек на массиве
    /// </summary>
    public class StackOnArray : IStack
    {
        /// <summary>
        /// Максимальная длина стека
        /// </summary>
        private const int length = 100;

        /// <summary>
        /// Номер "головы" стека в массиве
        /// </summary>
        private int head;

        /// <summary>
        /// Стек на массиве
        /// </summary>
        /// 
        private int[] array;

        /// <summary>
        /// Конструктор стека
        /// </summary>
        public StackOnArray()
        {
            array = new int[length];
        }

        /// <summary>
        /// Метод добавляет новое значение в стек
        /// </summary>
        public void Push(int value)
        {
            if (head > length)
            {
                throw new InvalidOperationException("Стек переполнен!");
            }
            array[head] = value;
            head++;
        }

        /// <summary>
        /// Достает значение из стека
        /// </summary>
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стек пустой!");
            }
            var temp = array[head - 1];
            head--;
            return temp;
        }

        /// <summary>
        /// Возвращает значение с головы стека
        /// </summary>
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Стек пустой!");
            }
            return array[head - 1];
        }

        /// <summary>
        /// Возвращает кол-во элементов в стеке
        /// </summary>
        public int GetLength() => head;

        /// <summary>
        /// Проверяет, пустой ли стек или нет
        /// </summary>
        public bool IsEmpty() => head == 0;
    }
}
