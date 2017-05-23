using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw41
{
    /// <summary>
    /// Класс Оператор
    /// </summary>
    internal class Operator : TreeElement
    {
        /// <summary>
        /// Значение оператора
        /// </summary>
        private char OperatorType;

        /// <summary>
        /// Левый сын
        /// </summary>
        public TreeElement LeftSon { get; set; }

        /// <summary>
        /// Правый сын
        /// </summary>
        public TreeElement RightSon { get; set; }

        /// <summary>
        /// Конструктор оператора
        /// </summary>
        /// <param name="symbol">оператор</param>
        public Operator(char symbol)
        {
            OperatorType = symbol;
        }

        /// <summary>
        /// распечатать оператор в строчку
        /// </summary>
        /// <returns></returns>
        public override string Print() => "(" + OperatorType + " " + LeftSon.Print() + " " + RightSon.Print() + " )";

        /// <summary>
        /// Вычислить значение
        /// </summary>
        /// <param name="value1">Значение левого сына</param>
        /// <param name="value2">Значение правого сына</param>
        /// <returns>Результат вычисления</returns>
        public override int Count()
        {
            int value1 = LeftSon.Count();
            int value2 = RightSon.Count();

            switch (OperatorType)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '*':
                    return value1 * value2;
                case '/':
                    if (value2 == 0)
                    {
                        throw new DivideByZeroException("деление на ноль");
                    }
                    return value1 / value2;
                default:
                    throw new ArgumentException("Некорректное выражение");
            }
        }
    }
}
