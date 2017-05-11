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
        /// Вычисляет выражение
        /// </summary>
        public int Calculation(string expression)
        {
            int expressionLength = expression.Length;
            int currentNumber = 0;
            bool isLastNumber = true;

            if (expressionLength == 0)
            {
                return 0;
            }

            for (var i = 0; i < expressionLength; i++)
            {
                if (expression[i] >= '0' && expression[i] <= '9')
                {
                    currentNumber = currentNumber * 10 + (int)Char.GetNumericValue(expression[i]);
                    isLastNumber = true;
                }
                else
                {
                    if (isLastNumber)
                    {
                        stack.Push(currentNumber);
                        currentNumber = 0;
                        isLastNumber = false;
                    }

                    if (expression[i] != ' ')
                    {
                        Operating(expression[i]);
                    }
                }
            }
            return stack.Pop();
        }

        /// <summary>
        /// Проводит вычисления исходя из оператора
        /// </summary>
        /// <param name="operation">Operator</param>
        private void Operating(char operation)
        {
            int num1 = stack.Pop();
            int num2 = stack.Pop();

            switch (operation)
            {
                case '+':
                    stack.Push(num1 + num2);
                    break;
                case '-':
                    stack.Push(num2 - num1);
                    break;
                case '*':
                    stack.Push(num1 * num2);
                    break;
                case '/':
                    stack.Push(num2 / num1);
                    break;
                default:
                    break;
            }
        }
    }
}
