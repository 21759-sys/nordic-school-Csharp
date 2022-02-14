using System;
using System.Collections.Generic;

namespace Lesson_08_list
{
    class Program
    {
        static void Main(string[] args)
        {

            var intArray = new[] { 1, 2, 3 };
            var intList = new List<int> { 1, 2, 3 };

            intList.Add(4);
            intList.AddRange(intArray);
            intList.Insert(10, 3);
            intList.Sort();
  
            foreach(int item in intList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(string.Join(',', intList));// 1,2,3,4,1,2,3


            }
        }
    }
}
