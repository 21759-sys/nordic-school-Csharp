using System;
using System.Collections.Generic;

namespace Lesson_10_class_SW_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Marine marine_1 = new Marine();
            marine_1.Name = "John";
            marine_1.Sex = "M";
            marine_1.Age = 30;
            marine_1.Special = Marine.marineSpecial.rifleman;
            marine_1.Wearpon = Marine.marineWearpon.m41a;

            Marine marine_2 = new Marine();
            marine_2.Name = "Frank";
            marine_2.Sex = "M";
            marine_2.Age = 27;
            marine_2.Special = Marine.marineSpecial.medic;
            marine_2.Wearpon = Marine.marineWearpon.m41a;

            var squadList = new List<Marine>
            {
                marine_1,
                marine_2,
            };

            foreach (var unit in squadList)
            {
                Console.WriteLine($"Name - {unit.Name}, Sex - {unit.Sex}, Age - {unit.Age}, Special - {unit.Special}, Wearpon - {unit.Wearpon}");
            }
        }
    }
}
