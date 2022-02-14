using System;

namespace Lesson_06_01_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string main = string.Empty;
            int i = 0;
            do
            {
                Console.WriteLine("__________________");
                Console.WriteLine("Enter main string");
                main = Console.ReadLine();
                i = 0;
                try
                {
                    i = main.Length;
                    if (i <= 15)
                    {
                        Console.WriteLine($"Заебок, длинна {i}");
                    }
                    else
                    {
                        Console.WriteLine($"Entered string lenght is {i}");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception шлюха бля");
                }
            } while (i > 15);
        }
    }
}
