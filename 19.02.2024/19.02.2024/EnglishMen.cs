using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2024
{
    internal class EnglishMen : Person
    {
        public EnglishMen() { }
        public EnglishMen(string name) { this.Name= name; }
        public override string Privetstvie(string p)
        {
            p=$"Hello {Name}";
            return p;
        }
        public static EnglishMen Vvod()
        {
            try
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                return new EnglishMen(name);
            }
            catch { Console.WriteLine("No correct data");return Vvod(); }
        }
    }
}
