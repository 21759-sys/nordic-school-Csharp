using System;
using System.Collections.Generic;

namespace Lesson_10_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Появляются морпехи
            Marine marine_1 = new Marine
            {
                Name = "Apone",
                Sex = "M",
                Age = 33,
                Special = Marine.marineSpecial.officer,
                Wearpon = Marine.marineWearpon.m41a,
            };
            marine_1.SetStatus(Marine.marineStatus.active);

            Marine marine_2 = new Marine
            {
                Name = "Hudson",
                Sex = "M",
                Age = 27,
                Special = Marine.marineSpecial.rifleman,
                Wearpon = Marine.marineWearpon.m41a,
            };
            marine_2.SetStatus(Marine.marineStatus.active);

            Marine marine_3 = new Marine
            {
                Name = "Vasquez",
                Sex = "F",
                Age = 28,
                Special = Marine.marineSpecial.rifleman,
                Wearpon = Marine.marineWearpon.smartgun,
            };
            marine_3.SetStatus(Marine.marineStatus.active);

            var squadList = new List<Marine>
            {
                marine_1,
                marine_2,
                marine_3
            };

            // Убить всех морпехов
            //foreach (var unit in squadList)
            //{
            //    unit.SetStatus(Marine.marineStatus.MIA);
            //    Console.WriteLine(unit.Report);
            //}

            // появляются чужие
            Creature alien_1 = new Creature
            {
                СreatureType = Creature.creatureType.alien,
                Status = Creature.creatureStatus.alive,
            };
            Creature alien_2 = new Creature
            {
                СreatureType = Creature.creatureType.alien,
                Status = Creature.creatureStatus.alive,
            };

            // Бой
            marine_3.Attack(alien_1);
            alien_2.Attack(marine_3);
            marine_2.Attack(alien_2);

            // Отчет по потерям
            foreach (var unit in squadList)
            {
                Console.WriteLine(unit.Report);
                Console.WriteLine(unit.Wearpon);
            }
        }
    }
}
