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
            Operation('+');
        }

        /// <summary>
        /// Выполняет умножение
        /// </summary>
        public void Multiplication()
        {
            Operation('*');
        }

        /// <summary>
        /// Выполнияет вычитание
        /// </summary>
        public void Subtraction()
        {
            Operation('-');
        }

        /// <summary>
        /// Выполняет деление
        /// </summary>
        public void Division()
        {
            Operation('/');
        }

        /// <summary>
        /// Проводит операции по выбору
        /// </summary>
        private void Operation(char operationValue)
        {
            if (stack.GetLength() < 2)
            {
                throw new InvalidOperationException("В стеке менее двух чисел!");
            }
            int numberTwo = stack.Pop();
            int numberOne = stack.Pop();
            int finalNumber = 0;
            switch (operationValue)
            {
                case '+':
                    {
                        finalNumber = numberOne + numberTwo;
                        break;
                    }
                case '-':
                    {
                        finalNumber = numberOne - numberTwo;
                        break;
                    }
                case '/':
                    {
                        finalNumber = numberOne / numberTwo;
                        break;
                    }
                case '*':
                    {
                        finalNumber = numberOne * numberTwo;
                        break;
                    }
                default: break;
            }
            stack.Push(finalNumber);
        }

        /// <summary>
        /// Выдает ответ
        /// </summary>
        public int GetAnswer()
        {
            if (stack.IsEmpty())
            {
                throw new InvalidOperationException("Стек пустой!");
            }
            return stack.Peek();
        }
    }
}
