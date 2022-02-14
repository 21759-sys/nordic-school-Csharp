using System;
using System.Collections.Generic;

namespace Lesson_08_list_SW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Самостоятельная работа
            var valList = new List<double>();
            bool stop = false;
            double sum = 0;

            while (stop == false)
            {
                var input = Console.ReadLine();
                try
                {
                    valList.Add(double.Parse(input));
                }
                catch (FormatException)
                {
                    if (input == "stop")
                    {
                        stop = true;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            foreach (var item in valList)
            {
                sum += item;
            }
            double answer = sum / valList.Count;
            Console.WriteLine($"Сумма введеных чисел = {answer}");

            
        }
    }
}
