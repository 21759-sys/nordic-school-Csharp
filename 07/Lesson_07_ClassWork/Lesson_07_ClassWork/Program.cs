using System;

namespace Lesson_07_ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {

            object o1 = new object();
            object o2 = new object();
            Console.WriteLine(o1 == o2);//false т.к. объект лежит в разных областях памяти

            string s1 = "value_1";
            string s2 = "value_1";
            Console.WriteLine(s1 == s2);//true т.к. строки равны да еще и одинаковые значения  впамяти лежат в одном месте
            Console.WriteLine(s1.Equals(s2));//true

            string input = Console.ReadLine();
            if (input == "show message")
            {
                Console.WriteLine("message");
            }

            Console.WriteLine("Test" == "test");//false
            Console.WriteLine("Test".Equals("tesT", StringComparison.InvariantCultureIgnoreCase));//true


        }
    }
}
