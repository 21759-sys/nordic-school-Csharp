using System;

namespace _05L_03_Exception
{
    enum Unit
    {
        Quad = 1,
        Triangle = 2,
        Round = 3
    }




    class Program 
            {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирай фигуру ебач");
            var f = Enum.GetNames(typeof(Unit));

            for (int i = 1; i <= f.Length; i++)
            {
                var element = (Unit)i;
                var element_value = (int)element;

                Console.WriteLine($"{element} - {element_value}");

                //Enum.GetName(typeof(Unit), i);
                //Console.WriteLine(Enum.GetName(typeof(Unit), i));
            }

            var Chosen_unit = (Unit)Enum.Parse(typeof(Unit), Console.ReadLine());
            Console.WriteLine(Chosen_unit);
            double s = 0;
            double p = 0;

            if (Chosen_unit == Unit.Quad)
            {
                Console.WriteLine("Введите длинну прямоугольника");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите высоту прямоугольника");
                double b = double.Parse(Console.ReadLine());
                s = a * b;
                p = 2 * (a + b);
            }

            if (Chosen_unit == Unit.Triangle)
            {
                Console.WriteLine("Введите длинну треугольника");
                double a = Int32.Parse(Console.ReadLine());
                s = (a * a) / 2;
                p = 3 * a;
            }

            if (Chosen_unit == Unit.Round)
            {
                Console.WriteLine("Введите радиус круга");
                double a = double.Parse(Console.ReadLine());
                s = (a * a) * Math.PI;
                p = (2 * a) * Math.PI;
            }

            Console.WriteLine($"Фигура - {Chosen_unit}");
            Console.WriteLine($"Периметр - {p}");
            Console.WriteLine($"Площадь - {s}");

        }
    }
}
