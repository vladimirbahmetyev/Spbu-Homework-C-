using System;

namespace Hw41
{
    /// <summary>
    /// Класс дерево разбора
    /// </summary>
    public class CalculationTree
    {
        public TreeElement root;

        public CalculationTree()
        {
            root = null;
        }

        /// <summary>
        /// Класс элемент деревf
        /// </summary>
        public abstract class TreeElement
        {
            public char OperatorType;

            public int Value;

            /// <summary>
            /// Левый сын
            /// </summary>
            public TreeElement leftSon;
            /// <summary>
            /// Правый сын
            /// </summary>
            public TreeElement rigthSon;

            /// <summary>
            /// Конструктор, создающий элемент дерева
            /// </summary>
            public TreeElement()
            {
                leftSon = null;
                rigthSon = null;
            }

            /// <summary>
            /// Распечатать элемент в строку результата
            /// </summary>
            public abstract void Print(ref string result);

            /// <summary>
            /// Вычислить значение
            /// </summary>
            public abstract int Count();
        }

        /// <summary>
        /// Класс Операнд
        /// </summary>
        public class Operand : TreeElement
        {
            /// <summary>
            /// Значение
            /// </summary>

            public Operand(int value)
            {
                Value = value;
            }

            /// <summary>
            /// Распечатать операнд в строку результата
            /// </summary>
            /// <param name="result"></param>
            public override void Print(ref string result)
            {
                result = result + Value.ToString();
            }

            /// <summary>
            /// Вычислить значение
            /// </summary>
            /// <returns></returns>
            public override int Count()
            {
                return Value;
            }
        }

        /// <summary>
        /// Класс Оператор
        /// </summary>
        public class Operator : TreeElement
        {
            /// <summary>
            /// Тип оператора
            /// </summary>

            public Operator(char type, TreeElement leftSon, TreeElement rigthSon)
            {
                OperatorType = type;
                this.leftSon = leftSon;
                this.rigthSon = rigthSon;

            }

            /// <summary>
            /// Распечатать оператор в строку результата
            /// </summary>
            /// <param name="result"></param>
            public override void Print(ref string result)
            {
                result = result + "(" + OperatorType + " ";
                leftSon.Print(ref result);
                result = result + " ";
                rigthSon.Print(ref result);
                result = result + " )";
            }

            /// <summary>
            /// Вычислить значение
            /// </summary>
            /// <param name="value1">Значение левого сына</param>
            /// <param name="value2">Значение правого сына</param>
            /// <returns>Результат вычисления</returns>
            public override int Count()
            {
                int value1 = leftSon.Count();
                int value2 = rigthSon.Count();

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

        public int CountTree()
        {
            return root.Count();
        }

        /// <summary>
        /// Построение дерева разбора
        /// </summary>
        /// <param name="str">Арифметическое выражение</param>
        /// <returns>Готовое дерево разбора</returns>
        public TreeElement BuildTree(string str)
        {
            TreeElement leftSonChild = null;
            TreeElement rigthSonChild = null;

            int position = 0;

            if ((str[position] >= '0') && (str[position] <= '9'))
            {
                return new Operand(Convert.ToInt32(str[position]) - Convert.ToInt32('0'));
            }

            if (str[position] == '(')
            {
                string newStr = str.Substring(1, str.Length - 2);
                str = newStr;
            }

            if (str[position] == ' ')
            {
                position++;
            }

            char operate = str[position];

            position++;
            if (str[position] == ' ')
            {
                position++;
            }

            if (str[position] == '(')
            {
                int ind = 1;
                string newstr = "(";
                while (ind != 0)
                {
                    position++;

                    if (str[position] == '(')
                    {
                        ind++;
                    }
                    if (str[position] == ')')
                    {
                        ind--;
                    }

                    newstr = newstr + str[position];
                }

                leftSonChild = BuildTree(newstr);

                position++;
                if (str[position] == ' ')
                {
                    position++;
                }
            }
            else
            {
                if (str[position] == ' ')
                {
                    position++;
                }

                if ((str[position] >= '0') && (str[position] <= '9'))
                {
                    leftSonChild = new Operand(Convert.ToInt32(str[position]) - Convert.ToInt32('0'));
                }

                position++;

                if (str[position] == ' ')
                {
                    position++;
                }
            }

            if (str[position] == ' ')
            {
                position++;
            }

            if (str[position] == '(')
            {
                int ind = 1;
                string newstr = "(";
                while (ind != 0)
                {
                    position++;

                    if (str[position] == '(')
                    {
                        ind++;
                    }
                    if (str[position] == ')')
                    {
                        ind--;
                    }

                    newstr = newstr + str[position];
                }

                rigthSonChild = BuildTree(newstr);

                if (str[position] == ' ')
                {
                    position++;
                }
            }
            else
            {
                if (str[position] == ' ')
                {
                    position++;
                }

                if ((str[position] >= '0') && (str[position] <= '9'))
                {
                    rigthSonChild = new Operand(Convert.ToInt32(str[position]) - Convert.ToInt32('0'));
                }

                position++;

                if (str[position] == ' ')
                {
                    position++;
                }
            }

            return new Operator(operate, leftSonChild, rigthSonChild);
        }

        /// <summary>
        /// Распечатать дерево
        /// </summary>
        /// <returns></returns>
        public string PrintTree()
        {
            string res = "";
            root.Print(ref res);
            return res;
        }
    }
}
