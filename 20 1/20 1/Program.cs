using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Culcul<int, int> culculator = new Culcul<int, int>(10, 2);
            Console.WriteLine("int/int");
            culculator.Add();
            culculator.Sub();
            culculator.Mul();
            culculator.Div();
            Culcul<int, double> culculator1 = new Culcul<int, double>(4, 2.2);
            Console.WriteLine("int/double");
            culculator1.Add();
            culculator1.Sub();
            culculator1.Mul();
            culculator1.Div();
            Culcul<int, string> culculator2 = new Culcul<int, string>(10, "5");
            Console.WriteLine("int/string");
            culculator2.Add();
            culculator2.Sub();
            culculator2.Mul();
            culculator2.Div();
            Console.ReadLine();
        }
    }
}
