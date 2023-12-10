using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Param param = new Param();
           // param.num1 = 1.5;
           // param.num2 = 3.4;

           // param.Func();
           // Console.WriteLine(param.Func1());
           // Param param2 = new Param(1.5, 1.5);
           // param2.Func();
           // Console.WriteLine(param2.Func1());
           // double num1 = double.Parse(Console.ReadLine());
           // double num2 = double.Parse(Console.ReadLine());
           // Param param1 = new Param(num1, num2);
           // param1.Func();
           // Console.WriteLine(param1.Func1());
           // //z2 
           // Time time = new Time(3, 10);
           // Console.WriteLine(time.ToString());
           // Console.WriteLine(time.Minute());
           // Time time2 = new Time(3, 10, 30);
           // Console.WriteLine(time2.Second());
           // int hour = int.Parse(Console.ReadLine());
           // int minute = int.Parse(Console.ReadLine());
           // int second = int.Parse(Console.ReadLine());
           // Time time1 = new Time(hour, minute, second);
           // Console.WriteLine(time1.ToString());
           // Console.WriteLine(time1.Second());
           //// z3
           // Triangle triangle = new Triangle(1, 2, 3);
           // Console.WriteLine(triangle.ToString());
           // Console.WriteLine(triangle.Per());
           // Triangle triangle1 = new Triangle(5);
           // Console.WriteLine(triangle1.ToString());
           // Console.WriteLine(triangle1.Per());

            //Car car= new Car("ferrari","a652","A457AA");
            //Car car1= new Car();
            //car1.Marka = "Volga";
            //car1.Model = "v32";
            //car1.Nom = "B333BB";
            //Console.WriteLine($"{car.ToString()}\n{car1.ToString()}");
            
            //Console.WriteLine($"{car.Start()}\n{car1.Start()}");
            //Console.WriteLine($"{car1.Stop()}\n{car.Stop()}");
            Gazeta gazeta = new Gazeta();
            gazeta.Name = "Test";
            gazeta.Tir = 10;
            gazeta.Polosa = 10;
            Gazeta gazeta1 = new Gazeta();
            gazeta1.Init();
            Console.WriteLine($"{gazeta.ToString()}\n{gazeta1.ToString()}");
            gazeta1.ChangeName();
            gazeta1.ChangeNumber();
            Console.WriteLine(gazeta1.ToString());
            Console.ReadKey();
        }
    }
}
