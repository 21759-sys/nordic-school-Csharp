using System;

namespace _05_Lesson_ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check key, press it, mafak:");
            char c = Console.ReadKey(true).KeyChar;

            if (char.IsLetterOrDigit(c))
            {
                Console.WriteLine("You enter Letter Or Digit");
            }
            else if (char.IsLetter(c))
            {
                Console.WriteLine("You enter a Letter");
            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine("You enter a Digit");
            }
            else if (char.IsPunctuation(c))
            {
                Console.WriteLine("You enter a Punctuation");
            }
            else
            {
                Console.WriteLine("You enter bull shit cocksucker");
            }

        }
    }
}
