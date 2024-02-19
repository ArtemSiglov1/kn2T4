using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2024_oop_
{
    internal class Gazeta:Prodaction
    {
        public Gazeta() { }
        public Gazeta(string name) { Name = name; }
        public override int AllPrice()
        {
            int kolvo=int.Parse(Console.ReadLine());
            int cena=int.Parse(Console.ReadLine());
            int tirag=int.Parse(Console.ReadLine());
            return kolvo*cena*tirag;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{AllPrice()}";
            
        }
    }
}
