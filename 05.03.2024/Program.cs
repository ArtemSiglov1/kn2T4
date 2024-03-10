using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    internal class Program
    {
        static void Main()
        {
            List<Car> Car = new List<Car>();
         List<Lorry> Lorry =new List<Lorry>();
        List<Bicycle> Bicycles =new List<Bicycle>();
       
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Выбери нужное Вам действие:\n\t\t1.Добавить в список велосипед;\n\t\t2.Добавить в список машину;\n\t\t3.Добавить в список грузовик;\n\t\t4.Вывести все велосипеды из списка;\n\t\t5.Вывести все машины из списка;\n\t\t6.Вывести все грузовики из списка;\n\t\t7.Выход.");
                    int name = int.Parse(Console.ReadLine());
                    switch (name)
                    {
                        case 1: Bicycle bicycle = new Bicycle(); Bicycles.Add(Garage.Init1());Console.Clear(); break;
                        case 2: Car car = new Car(); Car.Add(Garage.Init());Console.Clear(); break;
                        case 3: Lorry lorry = new Lorry(); Lorry.Add(Garage.Init2());Console.Clear(); break;
                        case 4: Console.WriteLine("Bicycles:"); foreach (var b in Bicycles) { Console.Write(b.Print()); } break;
                        case 5: Console.WriteLine("Car:"); foreach (var b in Car) {  Console.Write(b.Print()); } break;
                        case 6: Console.WriteLine("Lorry:"); foreach (var b in Lorry) {  Console.Write(b.Print()); } break;
                        case 7: flag = false; break;
                        default: Console.WriteLine("Действия не существует"); break;

                    }
                }
                catch { Main(); }
            }
        }
    }
}
