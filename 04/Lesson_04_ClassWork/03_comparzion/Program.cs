using System;

namespace _03_comparison_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(10 > 15);
            Console.WriteLine(10 <= 15);
            Console.WriteLine(10 != 15);
            Console.WriteLine("10" == "10");
            */

            int a = 18;
            int b = a++;

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
        }
    }
}
