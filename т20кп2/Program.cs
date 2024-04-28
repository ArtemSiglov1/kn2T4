using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т20кп2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Segment segment = new Segment(Segment.Init(),Segment.Init());
            Console.WriteLine( segment.ToString());
            Segment segment1 = new Segment(Segment.Init(),  Segment.Init());
            Console.WriteLine(segment1.ToString());
            Segment segment2 = new Segment(Segment.Init(), Segment.Init());
            Console.WriteLine(segment2.ToString());
            Console.Clear();
            Triangle triangle = new Triangle(segment,segment1,segment2);
            Console.WriteLine(triangle.ToString());
            Console.WriteLine(triangle.Square());
            Console.ReadLine();
        }
    }
}
