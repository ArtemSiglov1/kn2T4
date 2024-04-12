using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т19кп2
{
    class MyClass:IInterface2
    {
        public double GetPi()
        {
            return Math.PI;
        }
        public int GetInt()
        {
            return 52;
        }
        public double GetPowX()
        {
            Console.WriteLine("x?");
            int x = int.Parse(Console.ReadLine());
            return Math.Pow(x, 2);
        }
        public double GetSqrtX()
        {
            Console.WriteLine("x?");
            int x = int.Parse(Console.ReadLine());
            return Math.Sqrt(x);
        }
    }
}
