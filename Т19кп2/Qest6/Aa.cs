using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т19кп2
{
    internal class Aa:A
    {
        public new double Sub(int x, int y)
        {
            return Math.Abs(x - y);
        }
    }
}
