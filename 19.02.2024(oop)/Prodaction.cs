using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2024_oop_
{
    abstract class Prodaction
    {
        public string Name { get; set; }
        public abstract int AllPrice();
        public override string ToString()
        {
            return Name;
        }
    }
}
