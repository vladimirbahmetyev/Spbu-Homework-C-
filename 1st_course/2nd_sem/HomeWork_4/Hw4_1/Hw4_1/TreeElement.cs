namespace Hw41
{
    /// <summary>
    /// Класс элемент дерева
    /// </summary>
    internal abstract class TreeElement
    {
        /// <summary>
        /// Конструктор, создающий элемент дерева
        /// </summary>
        public TreeElement() { }

        /// <summary>
        /// Распечатать элемент в строку результата
        /// </summary>
        public abstract string Print();

        /// <summary>
        /// Вычислить значение
        /// </summary>
        public abstract int Count();
    }
}
