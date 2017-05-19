using System;

namespace Hw52
{
    /// <summary>
    /// Класс для обработки событий
    /// </summary>
    public class EventLoop
    {
        /// <summary>
        /// Событие при нажатии стрелки влево
        /// </summary>
        public event EventHandler<EventArgs> LeftHandler = (sender, args) => { };

        /// <summary>
        /// Событие при нажатии стрелки вправо
        /// </summary>
        public event EventHandler<EventArgs> RightHandler = (sender, args) => { };

        /// <summary>
        /// Событие при нажатии стрелки вверх
        /// </summary>
        public event EventHandler<EventArgs> UpHandler = (sender, args) => { };

        /// <summary>
        /// Событие при нажатии стрелки вниз
        /// </summary>
        public event EventHandler<EventArgs> DownHandler = (sender, args) => { };

        /// <summary>
        /// Метод запускает цикл обработки событий
        /// </summary>
        public void Run()
        {
            while(true)
            {
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        LeftHandler(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.RightArrow:
                        RightHandler(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.UpArrow:
                        UpHandler(this, EventArgs.Empty);
                        break;
                    case ConsoleKey.DownArrow:
                        DownHandler(this, EventArgs.Empty); 
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
