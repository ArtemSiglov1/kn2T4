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
            Segment segment = new Segment(Segment.Init(), new Point<dynamic, dynamic>(- 3,-5));
            Console.WriteLine(segment.ToString());
            Console.WriteLine(segment.GetLenghtOtr());
            //Segment<long> segment1 = new Segment<long>(3, 5, -3, -5);
            //Console.WriteLine(segment1.ToString());
            //Console.WriteLine(segment1.GetLenghtOtr());
            //Segment<uint> segment2 = new Segment<uint>(3, 5, 6, 10);
            //Console.WriteLine(segment2.ToString());
            //Console.WriteLine(segment2.GetLenghtOtr());
            Console.Read();
        }
    }
}
