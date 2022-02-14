using System;

namespace Lesson06_06_for_excersise
{
    class Program
    {
        static void Main(string[] args)
        {
            var marks = new[]
            {
            new [] {2, 3, 3, 2, 3},
            new [] { 2, 4, 5, 3 },
            null,
            new [] {5, 5, 5, 5},
            new [] {4}
            };

            for (int i = 0; i < marks.lenght; i++)
            {
                float sum = 0;
                double avg = 0;
                if (marks[i] != null)
                {
                    for (int j = 0; j <marks[i].Length; j++)
                    {
                        sum += marks[i][j];
                        avg = Math.Round(sum / marks[i].Length, 1);
                    }

                    Console.WriteLine($"The average mark for day #{i} is {avg}");
                }
                else
                {
                    Console.WriteLine($"The average mark for day #{i} is N/A");
                }
            }


            // MY_VAR
            /*
            double middle_mark = 0;

            for (int day_count = 0; day_count < marks.Length; day_count++)
            {
                var day_list = marks[day_count];
                if (day_list != null)
                {
                    double value_mark = 0;
                    for (int day = 0; day < day_list.Length; day++)
                    {
                        value_mark += day_list[day];
                        if (day == (day_list.Length - 1))
                        {
                            middle_mark = value_mark / day_list.Length;
                            Console.WriteLine(middle_mark);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ТУТ ХУЕТА");
                    continue;
                }
            }
            //
            */
        }
    }
}
