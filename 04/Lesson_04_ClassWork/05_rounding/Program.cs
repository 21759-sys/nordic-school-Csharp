using System;

namespace _05_rounding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt32(i)); // 9
            Console.WriteLine(Convert.ToInt32(j)); // 10
            Console.WriteLine(Convert.ToInt32(k)); // 10
            Console.WriteLine(Convert.ToInt32(l)); // it will be 10!
            Console.WriteLine(Convert.ToInt32(m)); // 11

            double f = Math.Round(l, 0, MidpointRounding.AwayFromZero); // 11
            double f1 = Math.Round(l, 1, MidpointRounding.AwayFromZero); // 10.5
            double z = 0.15;
            Console.WriteLine(Math.Floor(z)); // 0
            Console.WriteLine(Math.Ceiling(z)); // 1
        }
    }
}
