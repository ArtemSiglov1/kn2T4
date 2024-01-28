using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т16кп1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = DateTime.Now;
            //Console.WriteLine(date.ToShortDateString());
            //Console.WriteLine(date.ToString("d"));
            //Console.WriteLine(date.ToString("dd MMMM yyy"));
            //Console.WriteLine(date.ToLongDateString());
            //Console.WriteLine(date.ToString("ddd dd MMM yyy"));
            //Console.WriteLine(date.ToString("dddd dd MMMM yyy"));
            //Console.WriteLine(date.ToLongTimeString());
            //Console.WriteLine(date.ToShortTimeString());
            //Console.WriteLine($"{date.ToShortDateString()} {date.ToLongTimeString()}");
            //Console.WriteLine($"{date.ToLongDateString()} {date.ToShortTimeString()}");
            //Console.WriteLine($"{date.ToLongDateString()}{date.ToLongTimeString()}");
            DateTime date = DateTime.Now;
           // Hb[] hbs = new Hb[2];
            //способ для конструктора с 4 параметрами 
            //for(int i = 0; i < hbs.Length; i++) 
            //{
            //    int age = int.Parse(Console.ReadLine());
            //    int month = int.Parse(Console.ReadLine());
            //    int day = int.Parse(Console.ReadLine());
            //    hbs[i]=new Hb(age, month, day,date);
            //}
            //способ для конструктора с 3 параметрами и методом 
            //for (int i = 0; i < hbs.Length; i++)
            //{
            //    int age = int.Parse(Console.ReadLine());
            //    int month = int.Parse(Console.ReadLine());
            //    int day = int.Parse(Console.ReadLine());
            //    hbs[i] = new Hb(age, month, day);
            //}
            //foreach (var f in hbs)
            //{
            //    f.Prov(date);
            //}
            Vozr[] vozrs = new Vozr[2];
            for (int i = 0; i < vozrs.Length; i++)
            {
                int year = int.Parse(Console.ReadLine());
                int month = int.Parse(Console.ReadLine());
                int day = int.Parse(Console.ReadLine());
                vozrs[i] = new Vozr(year, month, day, date);
            }





                Console.Read();
        }
    }
}
