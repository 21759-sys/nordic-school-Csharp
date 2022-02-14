using System;
using System.Collections.Generic;

namespace Lesson_08_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            var s1 = "()"; // True
            var s2 = "[]()"; // True
            var s3 = "[[]()]"; // True
            var s4 = "([([])])()[]"; // True
            var s5 = "("; // False
            var s6 = "[][)"; // False
            var s7 = "[(])"; // False
            var s8 = "(()[]]"; // False

            var strList = new List<string> { s1, s2, s3, s4, s5, s6, s7, s8 };

            foreach (var list in strList)
            {
                string lastOpenType = String.Empty;

                bool openQuad = false;
                int numberOpenQuad = 0;

                bool openRound = false;
                int numberOpenRound = 0;

                foreach (var symbol in list)
                {

                    if ('(' == symbol)
                    {
                        openRound = true;
                        numberOpenRound++;
                        lastOpenType = "Round";
                    }
                    if (')' == symbol && 
                        numberOpenRound > 0 && 
                        lastOpenType != "Quad")
                    {
                        openRound = false;
                        numberOpenRound--;
                        lastOpenType = String.Empty;
                    }
                    if ('[' == symbol)
                    {
                        openQuad = true;
                        numberOpenQuad++;
                        lastOpenType = "Quad";
                    }
                    if (']' == symbol && 
                        numberOpenQuad > 0 
                        && lastOpenType != "Round")
                    {
                        openQuad = false;
                        numberOpenQuad--;
                        lastOpenType = String.Empty;
                    }
                }
                if (openQuad == false && 
                    openRound == false && 
                    numberOpenQuad == 0 && 
                    numberOpenRound == 0)
                {
                    Console.WriteLine("Заебок");
                }
                else
                {
                    Console.WriteLine("Хуета");
                }
            }
        }
    }
}
