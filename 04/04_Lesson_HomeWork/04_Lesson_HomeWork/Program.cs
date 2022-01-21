using System;
using System.Collections.Generic;

namespace _04_Lesson_HomeWork
{
    [Flags]
    enum Pack : Int32

    {
        pack_1_litre = 1,
        pack_5_litre = 2,
        pack_20_litre = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            var use_packs = new List<string>();
            var use_packs_enum = (Pack)0;

            int pack_1_litre_count = 0;
            int pack_5_litre_count = 0;
            int pack_20_litre_count = 0;

            List<string> pack_list = new List<string>();


            Console.WriteLine("Колличество упаковываемого сока:");
            var pack_volume = Double.Parse(Console.ReadLine());
            Pack pack_1 = (Pack)pack_volume;
            Console.WriteLine(pack_1);
            Console.WriteLine(use_packs_enum);
            Console.WriteLine();
            Console.WriteLine("--------------");

            counter();

            void counter()
            {
                for (int i = 10; i > 0; i++)
                {
                    if (pack_volume > 0)
                    {
                        if (pack_volume > 20)
                        {
                            use_packs_enum = use_packs_enum | (Pack)4;
                            pack_volume = pack_volume - 20;
                            pack_list.Add("пакет 20л");
                            pack_20_litre_count++;
                        }


                        if (pack_volume > 5 && pack_volume < 20)
                        {
                            use_packs_enum = use_packs_enum | (Pack)2;
                            pack_volume = pack_volume - 5;
                            pack_list.Add("пакет 5л");
                            pack_5_litre_count++;
                        }


                        if (pack_volume > -2 && pack_volume < 5)
                        {
                            use_packs_enum = use_packs_enum | (Pack)1;
                            pack_volume = pack_volume - 1;
                            pack_list.Add("пакет 1л");
                            pack_1_litre_count++;
                        }
                        counter();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            //            void counter()


            bool ask = (use_packs_enum & Pack.pack_20_litre) == Pack.pack_20_litre;
            if (ask == true)
            {
                Console.WriteLine($"{(Pack)4} : {pack_20_litre_count}");
            }

            bool ask_1 = (use_packs_enum & Pack.pack_5_litre) == Pack.pack_20_litre;
            if (ask_1 == true)
            {
                Console.WriteLine($"{(Pack)2} : {pack_5_litre_count}");
            }

            bool ask_2 = (use_packs_enum & Pack.pack_1_litre) == Pack.pack_20_litre;
            if (ask_2 == true)
            {
                Console.WriteLine($"{(Pack)1} : {pack_1_litre_count}");
            }


            Console.WriteLine($"{(Pack)4} : {pack_20_litre_count}");
            Console.WriteLine($"{(Pack)2} : {pack_5_litre_count}");
            Console.WriteLine($"{(Pack)1} : {pack_1_litre_count}");

        }
    }
}
