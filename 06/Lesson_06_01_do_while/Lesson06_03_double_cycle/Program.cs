using System;

namespace Lesson06_03_double_cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOk = true;
            int a;
            do
            {
                Console.WriteLine("Enter number: ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    isOk = false;
                }
            } while (!isOk);

            int b = 0;
            do
            {
                Console.WriteLine("Enter number: ");
                try
                {
                    b = int.Parse(Console.ReadLine());
                }
                catch
                {
                    isOk = false;
                }
            } while (!isOk);

            Console.WriteLine($"{a} * {b} = {a * b}");

        }
    }
}
