using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    internal class Garage
    {
       public List<Vehicle> Vehicles {  get; set; }
        public static Car Init()
        {
            Console.WriteLine();
            int price=int.Parse(Console.ReadLine());
            Console.WriteLine();
            int maxSpeed=int.Parse(Console.ReadLine());
            Console.WriteLine();
            int year=int.Parse(Console.ReadLine());
            Console.WriteLine();
            int power=int.Parse(Console.ReadLine());
            return new Car(price, maxSpeed, year, power);
        }
        public static Bicycle Init1()
        {
            Console.WriteLine();
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int maxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int kvoMest=int.Parse(Console.ReadLine());
            return new Bicycle(price, maxSpeed, year, kvoMest);
        }
        public static Lorry Init2() 
        {
            Console.WriteLine();
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int maxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int maxCapacity=int.Parse(Console.ReadLine());
            return new Lorry(price, maxSpeed, year, maxCapacity);
        }
        public void Input()
        {
            Console.WriteLine();
            int name=int.Parse(Console.ReadLine());
            switch(name)
            {
                case 1:Car car = new Car();Vehicles.Add(Init()); break;
                case 2:Bicycle bicycle = new Bicycle(); Vehicles.Add(Init1());break;
                case 3:Lorry lorry = new Lorry();Vehicles.Add(Init2());break;
                    case 4:
                    foreach(var b in Vehicles)
                    {
                        
                    }
                    break; 
            }
        }
    }
}
