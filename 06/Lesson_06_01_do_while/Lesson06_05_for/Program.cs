using System;

namespace Lesson06_05_for
{
    class Program
    {
        static void Main(string[] args)
        {
            const int startX = 0;
            const int endX = 10;

            const int startY = 0;
            const int endY = 10;

            for (int i = startX; i <= endX; i++)
            {
                for (int j = startY; j <= endY; j++)
                {
                    Console.Write($"{i * j}".PadRight(6));
                }
                Console.WriteLine();
            }

            /*
            for (int z = 0; z < 3; z++)
            {
                Console.WriteLine(z);
            }
            */

        }



    }
}

