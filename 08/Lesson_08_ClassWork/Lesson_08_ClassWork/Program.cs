using System;
using System.IO;
using System.Text;

namespace Lesson_08_ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // запись фаила
            const string file_name = @"test.txt";
            const string test_message = "hello world";
            byte[] messageAnsiBytes = Encoding.ASCII.GetBytes(test_message);
            File.WriteAllBytes(file_name, messageAnsiBytes);

            // чтение фаила
            const string file_name_to_read = @".\..\..\..\..\read.txt";
            string file_content = File.ReadAllText(file_name_to_read);
            Console.WriteLine(file_content);

            // Работа с дирректорией
            Directory.CreateDirectory(@"c:\test");

        }
    }
}
