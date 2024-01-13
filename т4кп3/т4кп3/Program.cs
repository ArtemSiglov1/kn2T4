using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace т4кп3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Программа № 3 Сиглов";
            Console.WriteLine("Запрашиваю у пользователя n слов");
            int n = int.Parse(Console.ReadLine());
            List<string> str = new List<string>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i+1} слово:");
                str.Add(Console.ReadLine());
            }
            Show(str);
            Console.ReadKey();
        }
        static void Show(List<string> str)
        {
            Console.WriteLine("\t");
            foreach (string i in str)
            {
                Console.WriteLine(i);
            }
        }
    }
}
