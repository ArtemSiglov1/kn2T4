using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т17_кп3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Staff> staffs = new List<Staff>();
            double z=0;
            Console.WriteLine("Koef=");
            int k = int.Parse(Console.ReadLine());
            
            staffs.Add(new Meneger("artem", "Siglov", new DateTime(2007, 3, 23), 2000, 5));
            staffs.Add(new Meneger("artem", "S", new DateTime(2007, 3, 23), 2000, 4));
            //staffs.Add(new Ingener("artem", "SIGLOV", new DateTime(2007, 3, 23), 2000, 4));
            //staffs.Add(new Ingener("Artem", "SIGLOV", new DateTime(2007, 3, 23), 2000, 6));
            //staffs.Add(new Staff("Artem", "Siglov", new DateTime(2007, 3, 23), 3000));
            foreach (Staff staff in staffs) 
            {
             Console.WriteLine(staff.Output());
                Console.WriteLine($"doxod-{staff.Doxod(k)}");
                z += staff.Doxod(k);
            }
            Console.WriteLine(k);
            Console.ReadLine();

        }
    }
}
