namespace Hw52
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var game = new CursorManipulator();

            eventLoop.LeftHandler += game.ToLeft;
            eventLoop.RightHandler += game.ToRight;
            eventLoop.UpHandler += game.ToUp;
            eventLoop.DownHandler += game.ToDown;

            eventLoop.Run();
        }
    }
}
