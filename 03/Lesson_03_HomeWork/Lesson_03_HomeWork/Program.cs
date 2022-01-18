using System;

namespace Lesson_03_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkArray();
        }
        private static void WorkArray()
        {
            const int lineLenght = 10;


            string[] vertLine = new string[lineLenght];
            for (int i = 1; i < lineLenght; i++)
            {
                vertLine[i] = Convert.ToString(i);
                Console.WriteLine();
                Console.Write($"{vertLine[i]}  ");


                string[] gorLine = new string[lineLenght];
                for (int l = 2; l < lineLenght; l++)
                {
                    gorLine[l] = Convert.ToString(l);
                    int calc_result = Convert.ToInt32(gorLine[l]) * Convert.ToInt32(vertLine[i]);
                    if (calc_result > 9)
                    {
                        Console.Write($"{calc_result} ");
                    }
                    else
                    {
                        Console.Write($"{calc_result}  ");
                    }
                }
            }
        }
    }
}
