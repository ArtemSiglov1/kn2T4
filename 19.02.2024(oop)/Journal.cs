using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2024_oop_
{
    internal class Journal:Prodaction
    {
        public Journal() { }
        public Journal(string name) 
        {
         Name = name;
        }
        public override int AllPrice()
        {
            int price=int.Parse(Console.ReadLine());
            int tirag=int.Parse(Console.ReadLine());
            return price*tirag;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{AllPrice()}";

        }
    }
}
