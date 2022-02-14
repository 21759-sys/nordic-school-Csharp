using System;

namespace Lesson06_08_foreach_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to crypt: ");
            string source = Console.ReadLine();

            Console.WriteLine("Enter numeric shift crypto key: ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Encrypted strin: ");
            foreach(char letter in source)
            {
                Console.WriteLine((char)(letter + key));
            }
            Console.WriteLine();
        }
    }
}
