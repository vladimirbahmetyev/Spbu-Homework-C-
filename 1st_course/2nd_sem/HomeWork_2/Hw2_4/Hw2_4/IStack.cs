namespace Hw24
{
    /// <summary>
    /// Интерфейс стека
    /// </summary>
    public interface IStack
    {
        /// <summary>
        ///Добавляет значение в стек
        /// </summary>
        void Push(int value);

        /// <summary>
        /// Достает значение из стека
        /// </summary>
        int Pop();

        /// <summary>
        /// Копирует значение с головы стека
        /// </summary>
        int Peek();

        /// <summary>
        /// Выдает кол-во элементов в стеке
        /// </summary>
        int GetLength();

        /// <summary>
        /// Проверяет пустой ли стек true/false
        /// </summary>
        bool IsEmpty();
    }
}
