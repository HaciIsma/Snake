using System;
using System.Threading;

namespace ConsoleApp39.Model
{
    class Snake
    {
        public int X { get; set; } = 3;
        public int Y { get; set; } = 3;
        public void Move()
        {
            var key = Console.ReadKey().Key;

            do
            {
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (blockUp)
                            {
                                goto case ConsoleKey.DownArrow;
                            }
                            blockDown = true;
                            blockUp = false;
                            blockLeft = false;
                            blockRigth = false;


                            Console.SetCursorPosition(X, --Y);
                            direction = 1;
                            CheckMove();
                            Direction();
                            Console.SetCursorPosition(X, ++Y);
                            Console.WriteLine(" ");
                            --Y;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            if (blockDown)
                            {
                                goto case ConsoleKey.UpArrow;
                            }
                            blockDown = false;
                            blockUp = true;
                            blockLeft = false;
                            blockRigth = false;

                            Console.SetCursorPosition(X, ++Y);
                            direction = 2;
                            CheckMove();
                            Direction();
                            Console.SetCursorPosition(X, --Y);
                            Console.WriteLine(" ");
                            ++Y;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        {
                            if (blockLeft)
                            {
                                goto case ConsoleKey.RightArrow;
                            }
                            blockLeft = false;
                            blockRigth = true;
                            blockUp = false;
                            blockDown = false;

                            Console.SetCursorPosition(--X, Y);
                            direction = 3;
                            CheckMove();
                            Direction();
                            Console.SetCursorPosition(++X, Y);
                            Console.WriteLine(" ");
                            --X;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        {
                            if (blockRigth)
                            {
                                goto case ConsoleKey.LeftArrow;
                            }
                            blockLeft = true;
                            blockRigth = false;
                            blockUp = false;
                            blockDown = false;

                            Console.SetCursorPosition(++X, Y);
                            direction = 4;
                            CheckMove();
                            Direction();
                            Console.SetCursorPosition(--X, Y);
                            Console.WriteLine(" ");
                            ++X;
                        }
                        break;
                }
                if (Console.KeyAvailable) key = Console.ReadKey().Key;
                Thread.Sleep(100);
                Console.SetCursorPosition(8, 25);
                Console.Write(eatingFoodSize);
                Eat();
            } while (true);
        }
        public void Eat()
        {
            if (X == Fruit.X && Y == Fruit.Y)
            {
                Fruit.FruitSize--;
                eatingFoodSize++;
                Console.Beep(2000, 400);
            }
        }

        bool blockUp = default;
        bool blockDown = default;
        bool blockLeft = default;
        bool blockRigth = default;
        int direction = default;

        private void Direction()
        {
            switch (direction)
            {
                case 1:
                    Console.WriteLine("^");
                    break;
                case 2:
                    Console.WriteLine("V");
                    break;
                case 3:
                    Console.WriteLine("<");
                    break;
                case 4:
                    Console.WriteLine(">");
                    break;
                default:
                    break;
            }
        }

        private void CheckMove()
        {
            if (!(Y > 0 && Y < 24))
            {
                Console.Clear();
                Console.WriteLine("You Lose");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (!(X > 1 && X < 59))
            {
                Console.Clear();
                Console.WriteLine("You Lose");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        private int eatingFoodSize = 0;
        public int EatingFoodSize
        {
            get { return eatingFoodSize; }
        }
    }
}
