using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Temp";
            if (Directory.Exists(path))
            {
                Console.WriteLine(path); //корневая папка
                string[] allDir1 = Directory.GetDirectories(path); //вложенные папки
                foreach (var dir1 in allDir1)
                {
                    string[] allDir2 = Directory.GetDirectories(dir1);  // папки подкаталогов
                    string[] allFiles = Directory.GetFiles(dir1); // файлы подкаталогов
                    Console.WriteLine("\t"+dir1);
                    foreach (var dir2 in allDir2)
                    {
                        Console.WriteLine("\t\t" + dir2);
                    }
                    foreach (var f in allFiles)
                    {
                        Console.WriteLine("\t\t" + f);
                    }
                }
                {
                    string[] allFiles = Directory.GetFiles(path); //файлы в корневой
                    foreach (var f in allFiles)
                    {
                        Console.WriteLine("\t"+f);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
