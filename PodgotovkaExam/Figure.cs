using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodgotovkaExam
{
    internal class Figure//:Point
    {
        string name;
        public Point Point { get; set; }
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public Point Point4 { get; set; }
        // public Figure(string name,int x, int y):base(name,x,y) { }
        public Figure(Point point,Point point1,Point point2)
        {
            name = "Triangle";
            Point = point;
            Point1 = point1;
            Point2= point2;
        }
        public Figure(Point point, Point point1, Point point2,Point point3):this(point,point1,point2)
        {
            name = "Квадрат";
            Point3 = point3;
        }
        public Figure(Point point, Point point1, Point point2, Point point3,Point point4) : this(point, point1, point2,point3)
        {
            name = "Пятиугольник";
            Point4 = point4;
        }
        public override string ToString()
        {
            return $"{name} {Point} {Point1} {Point2} {Point3} {Point4}";
        }
        public double LenghtSide(Point point,Point point1)
        {
            return Math.Sqrt(Math.Pow(point1.X - point.X, 2) + Math.Pow(point1.Y - point.Y, 2));
        }
        public void PerimeterCalc()
        {
            Console.WriteLine(LenghtSide(Point,Point1)+LenghtSide(Point1,Point2)+LenghtSide(Point2,Point3)+LenghtSide(Point3,Point4)+LenghtSide(Point4,Point));
        }
    }
}
