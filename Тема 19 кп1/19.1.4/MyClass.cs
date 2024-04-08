using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._1._4
{
    internal class MyClass:IMyInterfaceA,IMyInterfaceB
    {
        public void Show()
        {
            Console.WriteLine("completed show");
        }
         void IMyInterfaceA.Show()
        {
            Console.WriteLine("Completed AShow");
        }
        void IMyInterfaceB.Show()
        {
            Console.WriteLine("Completed BShow");
        }
    }
}
