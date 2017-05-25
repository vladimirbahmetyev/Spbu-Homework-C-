using System;
using System.Collections;
using System.Collections.Generic;

namespace Hw6_1
{
    /// <summary>
    /// Стековый калькулятор
    /// </summary>
    public class StackCalc
    {
        /// <summary>
        /// Стек для значений
        /// </summary>
        private Stack<double> stackValue;

        /// <summary>
        /// Стек для операций
        /// </summary>
        private Stack<char> stackOperation;

        /// <summary>
        /// Конструктор стекового калькулятора
        /// </summary>
        public StackCalc()
        {
        }

        /// <summary>
        /// Добавляет операцию в стек
        /// </summary>
        public void AddOperationToStack(char operation)
        {
            if(stackOperation == null)
            {
                stackOperation = new Stack<char>();
            }
            stackOperation.Push(operation);
        }

        /// <summary>
        /// Выполняет операцию
        /// </summary>
        public void Calculation()
        {
            if (stackOperation.Count == 0)
            {
                throw new InvalidOperationException("Никакой операции не было введено!");
            }
            while (stackOperation.Count != 0)
            {
                switch (stackOperation.Pop())
                {
                    case '+':
                        Sum();
                        break;
                    case '-':
                        Subtraction();
                        break;
                    case '*':
                        Multiplication();
                        break;
                    case '/':
                        Division();
                        break;
                    default: break;
                }
            }
        }

        /// <summary>
        /// Добавляет значение в стек
        /// </summary>
        public void AddValueToStack(double value)
        {
            if(stackValue == null)
            {
                stackValue = new Stack<double>();
            }
            stackValue.Push(value);
        }

        /// <summary>
        /// Выполняет Сложение
        /// </summary>
        public void Sum()
        {
            Operation((x, y) => x + y);
        }

        /// <summary>
        /// Выполняет умножение
        /// </summary>
        public void Multiplication()
        {
            Operation((x, y) => x * y);
        }

        /// <summary>
        /// Выполнияет вычитание
        /// </summary>
        public void Subtraction()
        {
            Operation((x, y) => x - y);
        }

        /// <summary>
        /// Выполняет деление
        /// </summary>
        public void Division()
        {
            Operation((x, y) => x / y);
        }

        /// <summary>
        /// Проводит операции по выбору
        /// </summary>
        private void Operation(Func<double, double, double > function)
        {
            if (stackValue.Count < 2)
            {
                throw new InvalidOperationException("В стеке менее двух чисел!");
            }
            double numberTwo = stackValue.Pop();
            double numberOne = stackValue.Pop();
            stackValue.Push(function(numberOne, numberTwo));
        }

        /// <summary>
        /// Выдает ответ
        /// </summary>
        public double GetAnswer()
        {
            if (stackValue.Count == 0)
            {
                throw new InvalidOperationException("Стек пустой!");
            }
            return stackValue.Peek();
        }

        /// <summary>
        /// Очищает память стекового калькулятора
        /// </summary>
        public void Clean()
        {
            if (stackOperation != null) stackOperation.Clear();
            if (stackValue != null) stackValue.Clear();
        }
    }
}
