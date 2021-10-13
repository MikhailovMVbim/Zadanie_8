using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            if (File.Exists(path))
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    var allText = sr.ReadToEnd();
                    Console.WriteLine("Текст в файле:\n" + allText);
                    Console.WriteLine();
                    Console.WriteLine("В данном тексте:");
                    Console.WriteLine("Символов: {0}",allText.Length);
                    string[] allWords = allText.Split(' ');
                    Console.WriteLine("Слов: {0}", allWords.Length);
                }
                using (StreamReader sr = new StreamReader(path))
                {
                    int i = 0;
                    while (sr.ReadLine() != null)
                    {
                        i++;
                    }
                    Console.WriteLine("Строк: {0}", i);
                }    
            }
            Console.ReadKey();
        }
    }
}
