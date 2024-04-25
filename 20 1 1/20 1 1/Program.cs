using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<int, int> point = new Point<int, int>(5,10);
            Console.WriteLine(point.ToString());
            Console.ReadLine();
        }
    }
}
