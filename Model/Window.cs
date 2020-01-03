using System;

namespace ConsoleApp39.Model
{
    class Window
    {
        public void VideoMode()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(61, 30);
            Draw();
        }

        private void Draw()
        {
            int h = 25;
            int w = 30;
            for (int i = 0; i < h; i++)
            {
                Console.Write(" ");
                for (int k = 0; k < w; k++)
                {
                    if (i == 0 || k == 0 || i == h - 1 || k == w - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($" Score: ");
        }

        public static void Lose()
        {
            Console.Clear();
            Console.WriteLine("You Lose");
            Environment.Exit(0);
        }

    }
}
