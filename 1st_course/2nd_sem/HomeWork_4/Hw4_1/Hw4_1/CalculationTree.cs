using System;

namespace Hw41
{
    /// <summary>
    /// Класс дерево разбора
    /// </summary>
    public class CalculationTree
    {
        /// <summary>
        /// Указатель на корень дерева
        /// </summary>
        private Operator root;

        /// <summary>
        /// Конструктор дерева
        /// </summary>
        public CalculationTree() { }
                
        /// <summary>
        /// Метод, который считает результат арифметического выражения
        /// </summary>
        /// <returns>Результат</returns>
        public int CountTree()
        {
            return root.Count();
        }

        /// <summary>
        /// Построение дерева разбора
        /// </summary>
        /// <param name="inputinputStringing">Арифметическое выражение</param>
        /// <returns>Готовое дерево разбора</returns>
        private     Operator BuildTree(string inputString)
        {
            TreeElement LeftSon = null;
            TreeElement RightSon = null;

            int position = 0;

            if (inputString[position] == '(')
            {
                string newString = inputString.Substring(1, inputString.Length - 2);
                inputString = newString;
            }

            if (inputString[position] == ' ')
            {
                position++;
            }

            char operate = inputString[position];

            position++;

            if (inputString[position] == ' ')
            {
                position++;
            }

            if (inputString[position] == '(')
            {
                String newString = GetExpression(inputString, ref position);

                LeftSon = BuildTree(newString);

                position++;

                if (inputString[position] == ' ')
                {
                    position++;
                }
            }
            else
            {
                if (inputString[position] == ' ')
                {
                    position++;
                }

                if ((inputString[position] >= '0') && (inputString[position] <= '9'))
                {
                    LeftSon = new Operand(Convert.ToInt32(inputString[position]) - Convert.ToInt32('0'));
                }

                position++;

                if (inputString[position] == ' ')
                {
                    position++;
                }
            }

            if (inputString[position] == ' ')
            {
                position++;
            }

            if (inputString[position] == '(')
            {
                String newString = GetExpression(inputString, ref position);

                RightSon = BuildTree(newString);

                if (inputString[position] == ' ')
                {
                    position++;
                }
            }
            else
            {
                if (inputString[position] == ' ')
                {
                    position++;
                }

                if ((inputString[position] >= '0') && (inputString[position] <= '9'))
                {
                    RightSon = new Operand(Convert.ToInt32(inputString[position]) - Convert.ToInt32('0'));
                }

                position++;

                if ((position < inputString.Length - 1) && (inputString[position] == ' '))
                {
                    position++;
                }
            }

            var newOperator = new Operator(operate);
            newOperator.LeftSon = LeftSon;
            newOperator.RightSon = RightSon;
            return newOperator;
        }
        
        /// <summary>
        /// Построить выражение
        /// </summary>
        private string GetExpression(string inputString, ref int oldPosition)
        {
            int position = 1;
            string newString = "(";
            while (position != 0)
            {
                oldPosition++;

                if (inputString[oldPosition] == '(')
                {
                    position++;
                }
                if (inputString[oldPosition] == ')')
                {
                    position--;
                }

                newString = newString + inputString[oldPosition];
            }
            return newString;
        }

        /// <summary>
        /// Построить дерево разбора
        /// </summary>
        /// <param name="expression"></param>
        public void Build(string expression) => root = BuildTree(expression);

        /// <summary>
        /// Посчитать выражение
        /// </summary>
        /// <param name="expression">Выражение</param>
        /// <returns>результат выражения</returns>
        public int Calculate(string expression)
        {
            Build(expression);
            return root.Count();
        }

        /// <summary>
        /// Распечатать дерево
        /// </summary>
        /// <returns></returns>
        public string PrintTree() => root.Print();
    }
}
