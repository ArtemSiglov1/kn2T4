using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2024
{
    internal class Russian:Person
    {
        public Russian() { }
        public Russian(string name) 
        {
        Name = name;
        }
        public override string Privetstvie(string p)
        {
            p = $"Здравствуйте {Name}";
            return p;
        }
        public static Russian Vvod()
        {
            try
            { 
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
                int i = int.Parse(Console.ReadLine());
            return new Russian(name);
            }
            catch { Console.WriteLine("No correct data"); return Vvod(); }
        }
        
    }
}

