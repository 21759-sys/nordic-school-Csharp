using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_10_Homework
{
    class Marine
    {
        public Marine (string name, int health)
        {
            Name = name;
            Health = health;
        }

        public Wearpon.M41a m41a = new Wearpon.M41a();
        public Wearpon.SmartGun smartgun = new Wearpon.SmartGun();
        public Wearpon.Pistol pistol = new Wearpon.Pistol();

        public enum marineSpecial { rifleman, medic, officer }
        public enum marineWearpon { m41a, smartgun, pistol }
        public enum marineStatus { active, KIA, MIA, WIA, POW }


        public string Name;
        public marineSpecial Special;
        public marineWearpon Wearpon;
        private marineStatus _status;
        public int Health = 100;

        private string _sex;
        private int _age;

        public string Sex
        {
            get
            {
                return Sex;
            }

            set
            {
                if (value == "М" || value == "m")
                {
                    _sex = "Male";
                }
                else if (value == "F" || value == "f")
                {
                    _sex = "Female";
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 18 && value < 50)
                {
                    _age = value;
                }
            }
        }
        public void SetStatus (marineStatus Status)
        {
            _status = Status;
        }
        public marineStatus GetStatus()
        {
            return _status;
        }
        public string Report
        {
            get
            {
                return $"Name - {Name}, Special - {Special}, Status - {GetStatus()}";
            }
        }

        public Creature Attack(Creature creature)
        {
            int a = Wearpon.damage;
 //           creature.health; - Wearpon.damage;
            creature.Status = Creature.creatureStatus.dead;
            return creature;
        }
    }
}
