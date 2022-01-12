using System;
using System.Threading;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine($"Здарова, {name}!");
            Thread.Sleep(5000);
            Console.WriteLine($"Пошел ты нахуй {name}!");
            Console.ReadKey();

        }
    }
}
