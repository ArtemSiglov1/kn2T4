using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т19кп2
{
    internal class Ab:A,ISqare
    {
        public double Sqrt(int x)
        {
            return Math.Sqrt(x);
           
        }

        public double Pow(int x)
        {
            return Math.Pow(x,2);
        }
    }
}
