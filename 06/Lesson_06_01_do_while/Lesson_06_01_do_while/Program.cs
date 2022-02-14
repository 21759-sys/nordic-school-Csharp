using System;

namespace Lesson_06_01_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit = "exit";
            string s = string.Empty;
            Console.WriteLine("Enter string value");
            do
            {
                s = Console.ReadLine();
                if (s != "exit")
                {
                    Console.WriteLine("Не выход");
                }
            } while (s != "exit");
            Console.WriteLine("ВЫХОД");
        }



        /*
        {
            int sum = 0;
            Console.WriteLine("Enter integer value");
            do
            {
                int i = int.Parse(Console.ReadLine());
                sum += i; // sum = sum + 1
            } while (sum < 100);
            Console.WriteLine($"Sum is: {sum}");
        */
        }
    }
}


    