using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т14кп2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[5];
            for (int i = 0; i < points.Length; i++)
            {
                Console.Write("x=");
                double x = double.Parse(Console.ReadLine());
                Console.Write("y=");
                double y = double.Parse(Console.ReadLine());
                points[i] = new Point(x, y);
            }
            Console.WriteLine(points.ToString());
            Point.Count();

            Console.ReadKey();
        }
    }
}
