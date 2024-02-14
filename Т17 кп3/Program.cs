using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т17_кп3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                List<Staff> staffs = new List<Staff>();
                
                double z = 0;
                Console.WriteLine("Koef=");
                int k = int.Parse(Console.ReadLine());
                Console.WriteLine("Norma");
                int n = int.Parse(Console.ReadLine());

                //staffs.Add(new Meneger("artem", "Siglov", new DateTime(2007, 3, 23), 2000, 5));
                //staffs.Add(new Meneger("artem", "S", new DateTime(2007, 3, 23), 2000, 4));
                //staffs.Add(new Ingener("artem", "SIGLOV", new DateTime(2007, 3, 23), 2000, 4));
                //staffs.Add(new Ingener("Artem", "SIGLOV", new DateTime(2007, 3, 23), 2000, 6));
                //staffs.Add(new Staff("Artem", "Siglov", new DateTime(2007, 3, 23), 3000));
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Status:");
                    string status = Console.ReadLine();
                    switch (status)
                    {
                        case "s": case "S": { Staff staff = new Staff(); staffs.Add(Staff.Enter()); } break;
                        case "i": case "I": { Ingener ingener = new Ingener(); staffs.Add(Ingener.Enter()); } break;
                        case "m": case "M": { Meneger meneger = new Meneger(); staffs.Add(Meneger.Enter()); } break;
                        default: Console.Clear(); flag = false; break;
                    }
                }
                foreach (var staff in staffs)
                {
                    Console.WriteLine(staff.Output());
                    Console.WriteLine($"doxod-{staff.Doxod(k, n)}");
                    z += staff.Doxod(k, n);
                }
                Console.WriteLine($"All Zp-{z}");
                Console.ReadLine();
            }
            catch { Console.WriteLine("not corect data"); Console.ReadLine(); }

        }
    }
}
