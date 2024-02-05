using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Press press=new Press(10,"fff",200);
            press.Output();
            Console.WriteLine(press.Cost());
            Magazine magazine=new Magazine(100,"df",10,1);
            magazine.Output();
            Console.WriteLine(magazine.Cost());
            Press press1 = new Magazine(100, "ggg", 10, 1);
            press1.Output();
            Console.WriteLine(press1.Cost());
            Console.Read();
        }
    }
}
