using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание файла
            string path = "numbers.txt";
            int sum = 0;
            int num = 0;
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            Random random = new Random();
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    num = random.Next(-100, 100);
                    streamWriter.WriteLine(num);
                }
            }
            //чтение из файла
            Console.WriteLine("Чтение из файла " + path);
            using (StreamReader streamReader = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    num = Convert.ToInt32(streamReader.ReadLine());
                    Console.WriteLine(num);
                    sum += num;
                }
                Console.WriteLine();
                Console.WriteLine("Сумма сгенерированных чисел: {0}",sum);
            }
            Console.ReadKey();
        }
    }
}
