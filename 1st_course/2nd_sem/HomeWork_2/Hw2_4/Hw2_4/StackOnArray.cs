using System;

//Коментарии писал сам, переписал сами фукции

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
        private int head = -1;

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
            if(head + 1 == length)
            {
                throw new InvalidOperationException("Стек переполнен!");
            }
            head++;
            array[head] = value;
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
            int value = array[head];
            head--;
            return value;
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
            return array[head];
        }

        /// <summary>
        /// Возвращает кол-во элементов в стеке
        /// </summary>
        public int GetLength() => head + 1;

        /// <summary>
        /// Проверяет, пустой ли стек или нет
        /// </summary>
        public bool IsEmpty() => head == -1;
    }
}
