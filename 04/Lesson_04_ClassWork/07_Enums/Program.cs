using System;

namespace _07_Enums
{
    class Program
    {
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su};
        enum DayTime : byte
        {
            Morning = 100,
            Midday = 150,
            Evening = 200,
            Night = 250
        }
        enum Season 
        {
            Winter = 3,
            Spring = 6,
            Summer = 9,
            Automn = 12
        }

        static void Main(string[] args)
        {
            /*
            var today = Day.We;
            Console.WriteLine(today); // We

            Console.WriteLine("Enter current day time: ");
            var Daytime = Enum.Parse(typeof(DayTime), Console.ReadLine());
            Console.WriteLine(Daytime);


            Console.WriteLine("Enter current season: ");
            var Season = Enum.Parse(typeof(Season), Console.ReadLine());
            Console.WriteLine(Season);
            */

            Season now = Season.Spring;
            Console.WriteLine(now);
            Console.WriteLine((int)now);
            int next_season_number = ((int)now) + 3;
            Console.WriteLine((Season)next_season_number);

        }
    }
}
