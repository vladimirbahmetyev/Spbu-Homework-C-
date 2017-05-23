using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw41
{

    /// <summary>
    /// Класс Операнд
    /// </summary>
    internal class Operand : TreeElement
    {
        /// <summary>
        /// Численное значение операнда
        /// </summary>
        private int Value;

        /// <summary>
        /// Конструктор операнда
        /// </summary>
        public Operand(int value)
        {
           Value = value;
        }

        /// <summary>
        /// Распечатать операнд в строку результата
        /// </summary>
        public override string Print() => Value.ToString();

        /// <summary>
        /// Вычислить значение
        /// </summary>
        /// <returns></returns>
        public override int Count() => Value;

    }

}
