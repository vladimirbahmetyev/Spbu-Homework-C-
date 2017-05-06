using System;

namespace Hw24
{
    /// <summary>
 /// Stack calculator.
 /// Works only with expression which can be unsigned integer.
 /// </summary>
    public class StackCalc
    {
        /// <summary>
        /// Stack for calculation
        /// </summary>
        /// 
        private IStack stack;

        public StackCalc(IStack stack)
        {
            this.stack = stack;
        }

        /// <summary>
        /// Calculating an expression
        /// </summary>
        /// <param name="expression">The expression for calculating</param>
        /// <returns>The result of calculating</returns>
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
        /// Executing an operating by an operator
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
