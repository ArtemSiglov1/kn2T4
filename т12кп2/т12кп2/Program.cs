using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Build dom1 = new Build();
            //dom1.name = "VG1";
            //dom1.area = 4000;
            //dom1.kvo = 100;
            //Console.WriteLine($"Площадь на одного жильца:{dom1.Showinfo()}");

            //Build dom2 = new Build("Vg1", 4000, 200);
            //Console.WriteLine($"Площадь на одного жильца:{dom2.Showinfo()}");
            Console.WriteLine("Введите название объекта");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите площадь объекта");
            int area =int.Parse( Console.ReadLine());
            Console.WriteLine("Введите количество жильцов объекта");
            int kvo = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество этажей");
            int floor = int.Parse(Console.ReadLine());
            Build dom3 = new Build(Name,area,kvo,floor);

            Console.WriteLine(dom3.Showinfo());
            //Computer computer = new Computer(16, 512, "asus");
            //Console.WriteLine(computer.ToString());
            //Transport transport = new Transport("авто", "зеленый", 220, 20);
            //Console.WriteLine(transport.ToString());
            Console.WriteLine("Введите название фигуры");
            string name=Console.ReadLine();
            Figura figura= new Figura(name,3,10);
            Console.WriteLine(figura.ToString());
            Console.ReadLine();
        }
    }
}
