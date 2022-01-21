using System;
using System.Collections.Generic;

namespace OtherOperations
{
	class Program
	{
		static void Main(string[] args)
		{
			var list_name = new List<int>();
			list_name.Add(100);
			list_name.Add(17);
			/*
			var symbols_list = new List<string> { "+", "-", "*", "/" };
			foreach (var item in symbols_list)
			{
				Console.WriteLine("________________");
				Console.WriteLine(Convert.ToChar(item));
				Console.WriteLine(item);
				Console.WriteLine("________________");
			}
			*/

			Console.WriteLine(list_name);
			foreach (int item in list_name)
			{
				Console.WriteLine(list_name[0] + list_name[1]);
				Console.WriteLine(list_name[0] - list_name[1]);
				Console.WriteLine(list_name[0] * list_name[1]);
				Console.WriteLine(list_name[0] / list_name[1]);
				Console.WriteLine(list_name[0] % list_name[1]);
			}
			var list_name_1 = new List<float>();
			list_name_1.Add(48.13F);
			list_name_1.Add(2.5F);
			Console.WriteLine(list_name_1);
			foreach (int item1 in list_name_1)
            {

				Console.WriteLine(list_name[0] + list_name[1]);
				Console.WriteLine(list_name[0] - list_name[1]);
				Console.WriteLine(list_name[0] * list_name[1]);
				Console.WriteLine(list_name[0] / list_name[1]);
				Console.WriteLine(list_name[0] % list_name[1]);


			}
			Console.WriteLine(11 * 3);

			Console.WriteLine();
			//////////////////
			Console.WriteLine(11 / 3); //вывод 3
			Console.WriteLine(11F / 3); //вывод 3.667
			Console.WriteLine(11.0 / 3); //вывод 3.666666
			Console.WriteLine(11.0 % 3); //вывод 2 - остаток от деления на цело

		}
	}
}
