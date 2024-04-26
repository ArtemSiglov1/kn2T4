using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т20кп2
{
    class Segment:Point<dynamic,dynamic>
    {
        Point<dynamic, dynamic> point1;
        Point<dynamic, dynamic> point2;

        internal Point<dynamic, dynamic> Point1 { get => point1; set => point1 = value; }
        internal Point<dynamic, dynamic> Point2 { get => point2; set => point2 = value; }

        public Segment(Point<dynamic,dynamic> point1, Point<dynamic, dynamic> point2)
        {
            Point1 = point1;
            Point2 = point2;
        }
        public override string ToString()
        {
            return $"A({Point1.X};{Point1.Y}),B({Point2.X};{Point2.Y})";
        }
        public double GetLenghtOtr()
        {
            return Math.Sqrt(Math.Pow((Point2.X - Point1.X),2)+Math.Pow(Point2.Y - Point1.Y, 2));
        }
        public static Point<dynamic, dynamic> Init() 
        {
            dynamic x =(dynamic)Console.ReadLine();
            dynamic y =(dynamic)Console.ReadLine();
            return new Point<dynamic, dynamic>(x, y);
        }
    }
}
