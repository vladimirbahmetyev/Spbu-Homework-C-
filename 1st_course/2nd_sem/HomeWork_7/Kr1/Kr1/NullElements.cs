using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kr1
{
    /// <summary>
    /// Класс списка нулевых элементов
    /// </summary>
    public class NullElementList
    {
        /// <summary>
        /// Нулевые элементы по умолчанию
        /// </summary>
        private int Int = 0;
        private double Double = -1;
        private string String = "";
        private bool Bool = false;
        private char Char = '!';

        /// <summary>
        /// Возвращает нулевые элементы для каждого типа
        /// </summary>
        /// <param name="inputObject">Пример обьекта</param>
        /// <returns>Ноль для типа этого обьекта</returns>
        /// Для типов, которые тут не написаны делается аналогично
        public object GetNullForThisType(object inputObject)
        {
            if(inputObject is int)
            {
                return Int;
            }
            if (inputObject is bool)
            {
                return Bool;
            }
            if (inputObject is string)
            {
                return String;
            }
            if (inputObject is double)
            {
                return Double;
            }
            if (inputObject is char)
            {
                return Char;
            }
            return 0;
        }

        /// <summary>
        /// Устанавливает новые нулевые элементы
        /// </summary>
        public void SetNulls(int newInt, double newDouble, string newString, bool newBool, char newChar)
        {
            Int = newInt;
            Double = newDouble;
            String = newString;
            Bool = newBool;
            Char = newChar;
        }
    }
}
