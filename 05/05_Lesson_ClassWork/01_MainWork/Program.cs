using System;

namespace _01_Main_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Скока аренды сука лет, пидор бля:");
            int input_rent_age = Int32.Parse(Console.ReadLine());
            string year_suffix = "пусто";
            if (input_rent_age >= 1 && input_rent_age < 30)
            {
                Console.WriteLine("Правильно ввел щенок");
                if (input_rent_age == 1 && input_rent_age == 21)
                {
                    year_suffix = "год";
                }
                else if (input_rent_age > 1 && input_rent_age < 5)
                {
                    year_suffix = "года";
                }
                else if (input_rent_age >= 2 && input_rent_age < 25)
                {
                    year_suffix = "года";
                }
                else
                {
                    year_suffix = "лет";
                }
                Console.WriteLine($"Договор аренды выдан на {input_rent_age} {year_suffix}");
            }
            else
            {
                Console.WriteLine("Ну куда ты сука тычешь пидормот");
            }
        }
    }
}