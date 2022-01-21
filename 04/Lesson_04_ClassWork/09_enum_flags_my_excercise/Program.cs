using System;
namespace _09_enum_flags_my_excercise
{
    [Flags]
    enum Color : Int32
    {
        Black = 1,
        Blue = 2,
        Cyan = 4,
        Grey = 8,
        Green = 16,
        Magenta = 32,
        Red = 64,
        White = 128,
        Yellow = 256
    }
    class Program
    {
        static void Main(string[] args)
        {
            var col1 = Int32.Parse(Console.ReadLine());
            var col2 = Int32.Parse(Console.ReadLine());
            var col3 = Int32.Parse(Console.ReadLine());

            Color col1_val = (Color)col1;
            Color col2_val = (Color)col2;
            Color col3_val = (Color)col3;

            Color allColors = (Color)511;
            Color favColor = (Color)col1 | (Color)col2 | (Color)col3;
            Color unFavColor = allColors ^ favColor;

            Console.WriteLine(favColor);
            Console.WriteLine(unFavColor);













            //workingDays = workingDays ^ Days.Mo;

            //Color favColor = (Color)col1 | (Color)col2 | (Color)col3;

            //Console.WriteLine((Color)col1);

            //Color notFavColors = 



            /*
            var col2 = Int32.Parse(Console.ReadLine());
            var col3 = Int32.Parse(Console.ReadLine());

            Color favColor = (Color)col1 | (Color)col2 | (Color)col3;


            Color allColors = (Color)511;
            Color unfavoriteColors = allColors ^ favColor;
            Console.WriteLine(unfavoriteColors);
            */
        }

        /* МОЕ РЕШЕНИЕ ПЕРВОНАЧАЛЬНОЕ
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Цвет - {(Collors)i}, номер цвета - {i}");
            }
            Console.WriteLine($"введите номер цвета 1");
            int number_good_collors_1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"введите номер цвета 2");
            int number_good_collors_2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"введите номер цвета 3");
            int number_good_collors_3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{ (Collors)number_good_collors_1}, {(Collors)number_good_collors_2}, {(Collors)number_good_collors_3}");
        */
        
    }
}

