using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т19кп2
{
    internal class A:IArithmetic
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public double Mul(int x, int y)
        {
            return x * y;
        }

        public double Div(int x, int y)
        {
            return x / y;
        }
    }
}
