using System;

namespace _04_implicid_explicid_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Явные и неявные приведения типов данных

            // Неявные приведения inplicit casting
            int a = 10;
            double b = a;
            var c = a + 0.1F;

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());

            double g = 9.81;
            //int g2 = g; // Выдает ошибку т.к. потеря точности в округлении до int

            // Явные приведения explicit casting
            double i = 9.49;
            double j = 9.5;
            double k = 10.49;
            double l = 10.5;
            double m = 10.51;

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


            Console.WriteLine("04_implicid_explicid_casting");
        }
    }
}
