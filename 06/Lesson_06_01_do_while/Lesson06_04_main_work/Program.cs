using System;

namespace Lesson06_04_main_work
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = { -1.5F, 2.5F, 5.5F, -7.5F, 12F };
            float summ = 0;
            int a = 0;
            while (a < numbers.Length)
            {

                summ += numbers[a];
                Console.WriteLine(summ);
                a += 1;
            }

            Console.WriteLine("TTTTT");

        }
    }
}
