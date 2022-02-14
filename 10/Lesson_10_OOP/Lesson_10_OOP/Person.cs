using System;

namespace Lesson_10_OOP
{
    class Person
    {
        private int _age;
        private int _dateOfBirthday;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 140)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age should be in range [0..140]");
                }
            }
        }
        public string Name { get; set; } //Автосвойство
        //public string Name //можно писать просто так
    }
}
