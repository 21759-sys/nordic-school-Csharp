using System;

namespace Lesson_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //BooleanLessonPart();
            //ConstantsLessonPart();
            //ObjectLessonPart();
            //VarLessonPart();
            //ReferenceAndValueTypes();
            //NullableLessonPart();
            //ArraysLessonPart();
            //SelfWorkNullable();
            WorkArray();

        }

        private static void WorkArray()
        {
            string[] trees = new string[3];
            trees[0] = "Ясень";
            trees[1] = "Клен";
            trees[2] = "Липа";

            int[] ages = new int[3];
            ages[0] = 21;
            ages[1] = 6;
            ages[2] = 15;

            for (int i = 0; i < trees.Length; i++)
            {
                Console.WriteLine($"{trees[i]} - возраст в годах {(ages[i])}");
            }
        }
        private static void SelfWorkNullable()
        {
            int? a = null;
            a = 5;

            float? b= null;

            Console.WriteLine(a.HasValue);
            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }

            Console.WriteLine(b.HasValue);
            if (b.HasValue)
            {
                Console.WriteLine(b.Value);
            }

        }
        private static void ArraysLessonPart()
        {
            string[] cities = new string[3];
            cities[0] = "Ebalovo";
            cities[1] = "Huikino";
            cities[2] = "Pidorovo";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(cities[i]);
            }

        }
        private static void NullableLessonPart()
        {
            int? a = null;
//            a = 12;
            if (a.HasValue && a.Value > 0)
            {
                Console.WriteLine(a * a);
            }
        }
        private static void ReferenceAndValueTypes()
        {
            int A = 255;
            object O = new object();

            Console.WriteLine(default(string));
            var sss = default(string);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void VarLessonPart()
        {
            var name = "RAZEBA";
            Console.WriteLine(name.GetType().Name);

            var age = 35;
            Console.WriteLine(age.GetType().Name);
        }
        static void ObjectLessonPart()
        {
            object name = "EBATEL";
            Console.WriteLine($"{name}, букв в имени: {((string)name).Length}");
            string name2 = "HUILO";
            Console.WriteLine($"{name2}, букв в имени: {name2.Length}");
        }
        static void ConstantsLessonPart()
        {
            const string name = "EBATEL";
            const int age = 20;

            const int numberOfItems = 7;

            int[] array = { 10, -22, 3, 0, 7, -2, -1 };

            int[] array2 = new int[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                array2[i] = array[i] * array[i];
            }

            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine($"{array[i]} * {array[i]} = {array2[i]}");
            }

            string welcomeText = "Hello" + name + Convert.ToString(age);
            Console.WriteLine(welcomeText);


        }
        static void BooleanLessonPart()
        {
            System.Boolean b1 = true;
            bool b2 = !b1;

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine();

            Console.WriteLine(3 > 7);
            Console.WriteLine("asdf" == "ASDF");
            Console.WriteLine(3.14F == 3.14);

            Console.WriteLine(3.14F == 3.14);

            Console.WriteLine(!b1);
            Console.WriteLine(!b2);
            Console.WriteLine(b1);
            Console.WriteLine(b2);

            // Boolean operator
            Console.WriteLine(true || false || false || false);
            Console.WriteLine(true && false && false && false);
        }
    }
}
