using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived();
            derived.Method1();
            derived.Method2();
            derived.Method3();
            derived.Method4();
            Aclass aclass = new Derived();
            aclass.Method1();
            aclass.Method2();
            aclass.Method3();
            aclass.Method4();
            Console.ReadLine();
        }
    }
}
