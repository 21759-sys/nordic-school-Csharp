using System;

namespace Lesson_10_C02_class
{
    class Marine
    {
        //enums
        public enum marineSpecial { rifleman, medic, officer }
        public enum marineWearpon { m41a, smartgun, flamethrower }

        //fileds

        private string _nation;
        private DateTimeOffset _dateOfBirth;
        private string _birthPlace;
        private string _sex; // это поле
        private int _age;

        public string Name;
        public marineSpecial Special;
        public marineWearpon Wearpon;

        //properties
        public string Sex // это свойство
        {
            get
            {
                return _sex;
            }
            set
            {
                if (value == "M")
                {
                    _sex = "Мужской";
                }
                else if (value == "F")
                {
                    _sex = "Женский";
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
        public string Report
        {
            get
            {
                return $"Sir, Name - {Name} from {GetNation()}, Sex - {Sex}, Age - {Age}, Special - {Special}, Wearpon - {Wearpon}";
            }
        }

        public void SetNation(string nation)
        {
            _nation = nation;
        }

        public string GetNation()
        {
            return _nation;
        }
    }
}
