using System;
using System.Collections.Generic;

namespace Lesson_08_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var my_dict = new Dictionary<string, int>()
            {
                { "Ключ 1", 1},
                { "Ключ 2", 5 },
                { "Ключ 3", 10 }
            };

            my_dict.Add("Ключ 4", 1);
            my_dict.Add("Ключ 5", 8);

            Console.WriteLine(my_dict["Ключ 1"]); // 1

            // нахождение ключа по значению
            foreach(KeyValuePair <string, int> pair in my_dict)
            {
                if (pair.Value == 5)
                    Console.WriteLine(pair.Key); // Ключ 2
            }

            // проверка есть ли ключ
            Console.WriteLine(my_dict.ContainsKey("Ключ 4")); //True

            // проверка есть ли значение
            Console.WriteLine(my_dict.ContainsValue(1000)); //False

            //замена значения для ключа
            my_dict["Ключ 1"] = 15;
        }
    }
}
