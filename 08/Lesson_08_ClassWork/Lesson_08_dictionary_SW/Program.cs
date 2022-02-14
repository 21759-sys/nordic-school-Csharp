using System;
using System.Collections.Generic;

namespace Lesson_08_dictionary_SW
{
    class Program
    {
        static void Main(string[] args)
        {
            var nation_dict = new Dictionary<string, string>()
            {
                {"Кавказец", "хач" },
                {"Азиат", "чурка" },
                {"Негр", "нигер" },
                {"Европеец", "чухня" },
                {"Американец", "пиндос" },
            };

        foreach(KeyValuePair <string,string> pair in nation_dict)
            {
                string answer = String.Empty;
                Console.WriteLine($"{pair.Key} это:");
                do
                {
                    answer = Console.ReadLine();
                    if (answer == pair.Value)
                    {
                        Console.WriteLine("правильно сука");
                    }
                    else
                    {
                        Console.WriteLine("неправильно гандон");
                    }

                } while (answer != pair.Value);
                Console.WriteLine();

            }
        }
    }
}
