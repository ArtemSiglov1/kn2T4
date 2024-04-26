using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т20кп2
{
    class Point<tt,tr>
    {
        tt x;
        tr y;
        public Point() { }
        public Point(tt x, tr y)
        {
            X = x;
            Y = y;
        }

        public tt X { get => x; set => x = value; }
        public tr Y { get => y; set => y = value; }
        public override string ToString()
        {
            return $"({X};{Y}),";
        }
    }
}
