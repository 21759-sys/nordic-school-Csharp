using System;

namespace _08_enum_flags
{
    /*
    [Flags] enum Days
    {
        None = 0,
        Mo = 1,
        Tu = 2,
        We = 4,
        Th = 8,
        Fr = 16,
        Sa = 32,
        Su = 64
    }
    */

    [Flags]
    enum Days : byte
    {
        None = 0,
        Mo = 0x1,
        Tu = 0x2,
        We = 0x4,
        Th = 0x8,
        Fr = 0x10,
        Sa = 0x20,
        Su = 0x40
    }

    class Program
    {
        static void Main(string[] args)
        {
            Days workingDays = (Days)31;
            Console.WriteLine(workingDays);

            // add separate bit
            workingDays = workingDays | Days.Sa;

            // delete monday
            workingDays = workingDays ^ Days.Mo;

            // Проверить установлен ли бит, workingDays & Days.Th метод просева см. видео
            bool thursdayIsWorking =
                (workingDays & Days.Th) == Days.Th; //сравниваем просеянный элемент с Days.Th








        }
    }
}
