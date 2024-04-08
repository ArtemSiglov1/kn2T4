using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._1._3
{
    internal class MyClass:IMyInterfaceA,IMyInterfaceB
    {
        public void ShowA()
        {
            Console.WriteLine("cwl showA");
        }
        public void ShowB() { Console.WriteLine("cwl showB"); }
    }
}
