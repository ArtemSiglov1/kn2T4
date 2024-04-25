using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1_1
{
    internal class Point<Ttype,Ptype>
    {
        private Ttype x;
        private Ptype y;

        public Point() { }
        public Point(Ttype x, Ptype y)
        {
            X = x;
            Y = y;
        }

        public Ttype X { get => x; set => x = value; }
        public Ptype Y { get => y; set => y = value; }
        public override string ToString()
        {
            return $"{x} {y}";
        }
    }
}
