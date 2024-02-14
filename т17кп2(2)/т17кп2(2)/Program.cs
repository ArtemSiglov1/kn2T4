using System;
using System.Collections;
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
            //buses.Add(new Bus("BMW",20,10));
            //buses.Add(new TurBus("mersedes",22,5,10));
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Status:");
                string status = Console.ReadLine();
                switch (status)
                {
                    case "b": case "B": { Bus bus = new Bus(); buses.Add(Bus.Enter()); } break;
                    case "T": case "t": { TurBus turBus = new TurBus(); buses.Add(TurBus.Enter()); } break;
                    default: Console.Clear(); flag = false; break;
                }
            }
            foreach (var bus in buses) 
            {
                Console.WriteLine($"{bus.Output()}Цена за все места автобуса-{bus.AllPrice()}");
            }
            Console.ReadLine();
        }
    }
}
