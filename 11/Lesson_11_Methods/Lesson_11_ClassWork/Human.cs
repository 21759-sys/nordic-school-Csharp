using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_11_Methods
{
    public class Human
    {
        // Конструктор класса
        public Human( string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Перегрузка конструктора
        public Human()
        {

        }



        public string Name;
        public string Nation;

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

        // пример перегрузки метода UpdateProperties
        public void UpdateProperties(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void UpdateProperties(string name, string nation, int age)
        {
            Name = name;
            Age = age;
            Nation = nation;
        }



    }
}
