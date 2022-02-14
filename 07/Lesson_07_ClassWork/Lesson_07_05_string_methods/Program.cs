using System;

namespace Lesson_07_05_string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string s = "lorem ipsum test test test";
            Console.WriteLine(s.Contains("ips"));// true
            Console.WriteLine(s.StartsWith("ABC"));// false
            Console.WriteLine(s.EndsWith("test"));// false

            // можно зациклить поиск
            int searchFromIndex = 0;
            int index = s.IndexOf("s", searchFromIndex); // 8
            Console.WriteLine(index);
            */
            //---------------------------------------------
            /*
            //самостоятельная найти индексы всех символов
            string s1 = "lorem ipsum test test test ebastosina";
            var items = new System.Collections.Generic.List<int>();
            int searchFromIndex = 0;
            int index1 = 0;
            while (index1 != -1)
            {
                index1 = s1.IndexOf("s", searchFromIndex);
                searchFromIndex = index1 + 1;
                if (index1 != -1)
                {
                    items.Add(index1);
                }
            }
            foreach (var f in items)
            {
                Console.WriteLine(f);
            }
            */
            //---------------------------------------------
            // Replace
            string a = "my test string";//my test string
            string b = a.Replace("test", "best");//my test string
            Console.WriteLine(a + "\n" + b);

            // Substring
            string c = a.Substring(3, 4);
            Console.WriteLine(a + "\n" + c);

            // Split
            string[] lines = a.Split(' ');
            foreach (string line in lines)
            {
                Console.WriteLine($"{line}: {line.Length}");
            }

            //Join
            string join_val = string.Join("соеденитель", lines);
            Console.WriteLine(join_val);

        }
    }
}
