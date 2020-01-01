using System;

namespace ConsoleApp39.Model
{
    class Fruit
    {
        static public int FruitSize { get; set; } = 0;
        static public int X { get; set; } = 0;
        static public int Y { get; set; } = 0;

        public void FruitPut()
        {
            while (true)
            {
                if (FruitSize == 0)
                {
                    Random random = new Random();
                    X = random.Next(2, 59);
                    Y = random.Next(1, 24);
                    Console.SetCursorPosition(X, Y);
                    Console.WriteLine("@");
                    FruitSize++;
                }
            }
        }
    }
}
