using System;

namespace Lesson_07_06_string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Цена";
            s += " | ";
            s += "Количество";
            s += " | ";
            s += "Стоимость";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Цена");
            sb.Append(" | ");
            sb.Append("Количество");
            sb.Append(" | ");
            sb.Append("Стоимость");

            sb.Remove(5, 13);

            sb.Insert(5, DateTimeOffset.Now);

            sb.AppendFormat("Дата: {0:yyyy-MM-dd}", DateTimeOffset.Now);
            if (sb.Length > 0)
            {
                var result = sb.ToString();
                Console.WriteLine(result);
            }


        }
    }
}
