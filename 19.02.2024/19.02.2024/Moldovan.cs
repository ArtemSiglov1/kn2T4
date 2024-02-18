using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2024
{
    internal class Moldovan:Person
    {
        public Moldovan() { }
        public Moldovan(string name)
        {
            this.Name = name;
        }
        public override string Privetstvie(string p)
        {
            p=$"Буна Зиуа {Name}";
            return p;
        }
        public static Moldovan Vvod()
        {
            try
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                return new Moldovan(name);
            }
            catch { Console.WriteLine("No correct data"); return Vvod(); }
        }
    }
}
