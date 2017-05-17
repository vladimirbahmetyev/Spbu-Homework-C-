using System;

namespace Hw24
{
    /// <summary>
 /// Стековый калькулятор
 /// </summary>
    public class StackCalc
    {
        /// <summary>
        /// Стэк для вычислений
        /// </summary>
        /// 
        private IStack stack;

        /// <summary>
        /// Конструктор стекового калькулятора
        /// </summary>
        /// <param name="stack"></param>
        public StackCalc(IStack stack)
        {
            this.stack = stack;
        }

        /// <summary>
        /// Добавляет значение в стек
        /// </summary>
        public void AddValueToStack(int value)
        {
            stack.Push(value);
        }

        /// <summary>
        /// Выполняет Сложение
        /// </summary>
        public void Sum()
        {
            if(stack.GetLength() < 2)
            {
                throw new InvalidOperationException("В стеке менее двух чисел!");
            }

            int numberTwo = stack.Pop();
            int numberOne = stack.Pop();

            stack.Push(numberOne + numberTwo);
        }

        /// <summary>
        /// Выполняет умножение
        /// </summary>
        public void Multiplication()
        {
            if (stack.GetLength() < 2)
            {
                throw new InvalidOperationException("В стеке менее двух чисел!");
            }

            int numberTwo = stack.Pop();
            int numberOne = stack.Pop();

            stack.Push(numberOne * numberTwo);
        }

        /// <summary>
        /// Выполнияет вычитание
        /// </summary>
        public void Subtraction()
        {
            if (stack.GetLength() < 2)
            {
                throw new InvalidOperationException("В стеке менее двух чисел!");
            }

            int numberTwo = stack.Pop();
            int numberOne = stack.Pop();

            stack.Push(numberOne - numberTwo);
        }

        /// <summary>
        /// Выполняет деление
        /// </summary>
        public void Division()
        {
            if (stack.GetLength() < 2)
            {
                throw new InvalidOperationException("В стеке менее двух чисел!");
            }

            int numberTwo = stack.Pop();
            int numberOne = stack.Pop();

            stack.Push(numberOne / numberTwo);
        }

        /// <summary>
        /// Выдает ответ
        /// </summary>
        public int GetAnswer()
        {
            if(stack.IsEmpty())
            {
                throw new InvalidOperationException("Стек пустой!");
            }
            return stack.Peek();
        }
    }
}
