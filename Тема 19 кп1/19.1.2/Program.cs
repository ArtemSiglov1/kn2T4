using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myOb=new ChildClass();
            myOb.Show();
            myOb.Show2();
            Console.Read();
        }
    }
}
