using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп2_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bus> buses = new List<Bus>();
            buses.Add(new Bus("BMW",20,10));
            buses.Add(new TurBus("mersedes",22,5,10));
            foreach(var bus in buses) 
            {
                Console.WriteLine($"{bus.Output()}{bus.AllPrice()}");
            }
            Console.ReadLine();
        }
    }
}
