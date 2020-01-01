using ConsoleApp39.Model;
using System.Threading;

namespace ConsoleApp39
{
    class Controller
    {
        public void Control()
        {
            Window window = new Window();
            Snake snake = new Snake();
            Fruit fruit = new Fruit();
            window.VideoMode();
            Thread t = new Thread(new ThreadStart(fruit.FruitPut));
            t.Start();
            snake.Move();
        }
    }
}
