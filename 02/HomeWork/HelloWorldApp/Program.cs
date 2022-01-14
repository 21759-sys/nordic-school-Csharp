using System;
using System.Text;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Введите Имя: ");

            Console.WriteLine($"Привет, {Console.ReadLine()}");

            /*
             * объявление перемнных
             

            int a;
            int b = 10;
            string s1;
            s1 = "значение переменной";

            char symbol = '@';
            double i = 128.4788888888888;
            float pi = 3.18888;
            bool someValue = true;
            bool anotherValue = false;
            

            char letter = 'A';
            Console.WriteLine(letter);
            Console.WriteLine((int)letter);

            System.Char name = 'B';
            Console.WriteLine(name);
            System.String name2 = "Хуй";
            Console.WriteLine(name2);

            byte age = 36; // 0..255
            System.Byte age2 = age;
            Console.WriteLine(age2);

            sbyte temp = -12; // -128  127
            System.SByte temp2 = temp;
            Console.WriteLine(temp2);

            short pressure = -21200; // -32768..32767
            Int16 pressure2 = pressure;
            Console.WriteLine(pressure2);

            int minutesInYear = 365 * 24 * 60;
            Int32 minutesInYear2 = minutesInYear;
            Console.WriteLine(minutesInYear2);


            
            //----------------
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Введите число: ");
            string inputFromConsole = Console.ReadLine();
            int myNumber = int.Parse(inputFromConsole);
            int doubleNumber = myNumber * 2;
            Console.WriteLine(doubleNumber);
            //----------------
            */

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Введите число 1: ");
            string Value_1_from_console = Console.ReadLine();
            Console.Write("Введите число 2: ");
            string Value_2_from_console = Console.ReadLine();

            int value_1 = int.Parse(Value_1_from_console);
            int value_2 = int.Parse(Value_2_from_console);

            string check_value_1 = Convert.ToString(value_1);
            string check_value_2 = Convert.ToString(value_2);

            Console.WriteLine(check_value_1, check_value_2);

            int addition = value_1 - value_2;
            int subtraction = value_1 + value_2;
            int composition = value_1 * value_2;
            double division = value_1 / value_2;

            Console.WriteLine($"Сумма: {addition}");
            Console.WriteLine($"Вычетание: {subtraction}");
            Console.WriteLine($"Произведение: {composition}");
            Console.WriteLine($"Деление: {division}");





        }
    }
}
