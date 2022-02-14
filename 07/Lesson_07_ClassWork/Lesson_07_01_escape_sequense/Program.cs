using System;

namespace Lesson_07_01_escape_sequense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello    World!");//"Hello    World!"
            Console.WriteLine("Hello\tWorld!");//"Hello    World!"
            Console.WriteLine("Hello\nWorld!");//"Hello (перенос на другую строку) World!"
        }
    }
}
