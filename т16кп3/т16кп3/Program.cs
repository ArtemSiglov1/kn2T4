using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine()), month = int.Parse(Console.ReadLine()), day = int.Parse(Console.ReadLine());
            DateClass date = new DateClass(year, month, day);
            Console.WriteLine(date.ToString());
            Console.WriteLine($"Предыдущий день: {date.Yesterday().ToShortDateString()}");
            Console.WriteLine($"Последующий день: {date.Tomorrow().ToShortDateString()}");
            Console.WriteLine($"Количество дней до конца месяца: {date.EndMonth()}");
            //DateTime date =DateTime.Parse(Console.ReadLine());
            //DateTime date1 = DateTime.Parse(Console.ReadLine());
            //int count=int.Parse(Console.ReadLine());
            //MedProc medProc = new MedProc(date, date1);
            //Console.WriteLine(medProc.Allproc());
            //MedProc[] medProc = new MedProc[4];
            //for (int i = 0; i < medProc.Length; i++) 
            //{ medProc[i] = new MedProc(date, date1, count); }

            Console.Read();
        }
    }
}
