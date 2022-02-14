using System;

namespace Lesson_09_ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // код без пременного фактора, всегда работает с x
            //одна переменная и константное кол-во операций
            int x = 0; // 2 команды 1-ая выделить место под переменную, 2-ая =
            x = x + 1; // 2 команды 1-ая +, 2-ая =
            // можно посмотреть чрез ILSpy

            // 7 > 1
            // O(N) = 1
            // O(1)

            const int lenght = 5;
            const int maxValue = 100;

            var arr = new int[lenght];
            var rnd = new Random();

            for (int i = 0; i < arr.Length; i++)// N
            {
                arr[i] = rnd.Next(maxValue); //N
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // 1 + 2N
        }
    }
}
