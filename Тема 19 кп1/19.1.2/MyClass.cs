using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._1._2
{
    abstract class MyClass : IMyInterface
    {
        public void Show()
        {
            Console.WriteLine("MyClass.Show() is emplemented.");
        }

        public abstract void Show2();

    }
}
