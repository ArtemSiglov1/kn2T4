using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace т12кп1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person("Арина", "Крижановская", 16);
            Console.WriteLine(person1.ToString());
            Point point = new Point();
            Point point1 = new Point(10, 15);
            Console.WriteLine(point1.ToString());
            Console.WriteLine($"{point1.Rast():f0}");
            Address address = new Address();
            Address address1 = new Address(3300, "Moldova", "Tiraspol", "Karla Lip", 207, 35);
            Console.WriteLine(address1.ToString());
            Console.Read();
        }
    }
}
