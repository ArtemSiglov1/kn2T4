using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Figures figure1 = new Figures();
            //figure1.Name = "kvadr";
            //figure1.Side1 = 1;
            //figure1.Side2 = 2;
            //Console.WriteLine(figure1.ToString());
            //figure1.PS();
            //Figures figure2 = new Figures("kv", 12, 10);
            //Console.WriteLine(figure2.ToString());
            //figure2.PS();
            //Console.WriteLine("Введите название фигуры");
            //string name = Console.ReadLine();
            //Console.WriteLine("Введите сторону 1");
            //int s1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите сторону 2");
            //int s2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Введите сторону 3");
            //int s3 = int.Parse(Console.ReadLine());
            //Figures figures3 = new Figures(name, s1, s2, s3);
            //Console.WriteLine(figures3.ToString());
            //figures3.PS1();
            Staff staff = new Staff();
            staff.Input();
            Staff staff1 = new Staff();
            staff1.Input();
            Console.WriteLine($"{staff.ToString()}\n{staff1.ToString()}");


            Console.ReadKey();
        }
    }
}
