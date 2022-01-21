using System;

namespace _06_complex_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
         /*
            double a = 3;
            double b = 4;
            double c = Math.Sqrt(a * a + Math.Pow(b, 2));
            Console.WriteLine(c);


            double s = Math.PI;
            double a = 1;
            double h = 2.5;
            double n = 6;

            double result = Math.Pow(h, 2) + Math.Pow(a / (2 * Math.Tan(((180 * Math.PI)/180) / n)), 2);
            Console.WriteLine(result);
            //
            double result_V = (h * n * Math.Pow(a, 2)) / (12 * Math.Tan(Math.PI/ n));
            Console.WriteLine(result_V);
         */
            Console.Write("Enter a: ");
            var a = double.Parse(Console.ReadLine());

            Console.Write("Enter h: ");
            var h = double.Parse(Console.ReadLine());

            Console.Write("Enter n: ");
            var n = double.Parse(Console.ReadLine());

            var x = Math.Tan(Math.PI / n);
            var y = a / (2 * x);
            var s_bok = (n * a / 2) * Math.Sqrt((h * h) + (y * y));
            Console.WriteLine(s_bok);

            





        }
    }
}
