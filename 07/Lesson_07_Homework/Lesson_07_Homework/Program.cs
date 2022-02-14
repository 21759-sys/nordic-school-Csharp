using System;

namespace Lesson_07_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            string incom_text = "dfdad Adafdsf adsad fdsf adas tghr";
            //string incom_text = Console.ReadLine();
            int words_count = 0;
            string[] words = incom_text.Split(' ');
            foreach (string word in words)
            {
                var symb = word.IndexOf("a", 0, 1, StringComparison.InvariantCultureIgnoreCase);
                Console.WriteLine(symb);
                if (symb != -1)
                {
                    words_count++;
                }
            }
            Console.WriteLine($"Слов на букву а: {words_count}");
        }
    }
}
