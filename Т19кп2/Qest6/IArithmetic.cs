using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т19кп2
{
    internal interface IArithmetic
    {
        int Add(int x, int y);
        int Sub(int x, int y);
        double Mul(int x, int y);
        double Div(int x, int y);
    }
}
