using System;

namespace Lesson06_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            int incom_value = int.Parse(Console.ReadLine());
            int quantity_even_numbers = (incom_value.ToString()).Length;
            if (incom_value > 0 && incom_value < 2000000000)
            {
                foreach (var item in incom_value.ToString()) // основное число
                {
                    double check_number = (Convert.ToDouble(int.Parse(item.ToString()))) / 2; //Проверка на четность
                    foreach (var item_1 in check_number.ToString())
                    {
                        string what_value = "Четное";
                        if (item_1 == '.')
                        {
                            quantity_even_numbers--;
                            what_value = "Нечетное";
                            break;
                        }
                    }
                }
                Console.WriteLine($"Число четных чисел: {quantity_even_numbers}");
            }
        }
    }
}
