using System;
using System.Collections.Generic;

namespace Lesson_10_C02_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Marine marine_1 = new Marine();  // Можно задавать поля так
            marine_1.Name = "John";
            marine_1.Sex = "M";
            marine_1.Age = 30;
            marine_1.Special = Marine.marineSpecial.rifleman;
            marine_1.Wearpon = Marine.marineWearpon.m41a;
            marine_1.SetNation("Ireland");

            string marine_1_Nation = marine_1.GetNation();


            Marine marine_2 = new Marine   // Можно задавать поля так
            {
                Name = "Frank",
                Sex = "M",
                Age = 27,
                Special = Marine.marineSpecial.medic,
                Wearpon = Marine.marineWearpon.m41a
            };
            marine_2.SetNation("American");

            string marine_2_Nation = marine_2.GetNation();

            var squadList = new List<Marine>
            {
                marine_1,
                marine_2,
            };

            foreach (var unit in squadList)
            {
                //Console.WriteLine($"Name - {unit.Name}, Sex - {unit.Sex}, Age - {unit.Age}, Special - {unit.Special}, Wearpon - {unit.Wearpon}");
                Console.WriteLine(unit.Report);
            }
        }
    }
}