using System;

namespace Hw52
{
    /// <summary>
    /// Класс игры, в которой можно манипулировать курсором
    /// </summary>
    public class CursorManipulator
    {
        /// <summary>
        /// Сместить курсор влево
        /// </summary>
        public void ToLeft(object sender, EventArgs args)
        {
            if (Console.CursorLeft > 0)
            {
                Console.CursorLeft--;
            }
        }

        /// <summary>
        /// Сместить курсор вправо
        /// </summary>
        public void ToRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft < Console.BufferWidth - 1)
            {
                Console.CursorLeft++;
            }
        }

        /// <summary>
        /// Сместить курсор вверх
        /// </summary>
        public void ToUp(object sender, EventArgs args)
        {
            if (Console.CursorTop > 0)
            {
                Console.CursorTop--;
            }
        }

        /// <summary>
        /// Сместить курсор вниз
        /// </summary>
        public void ToDown(object sender, EventArgs args)
        {
            if (Console.CursorTop < Console.BufferHeight - 1)
            {
                Console.CursorTop++;
            }
        }
    }
}
