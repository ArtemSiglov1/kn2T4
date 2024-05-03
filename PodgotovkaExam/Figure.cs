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
        public double Perimetr {  get; set; }
       
        // public Figure(string name,int x, int y):base(name,x,y) { }
        public Figure(Point point,Point point1,Point point2)
        {
            name = "Triangle";
           Perimetr=LenghtSide(point,point1)+LenghtSide(point1,point2)+LenghtSide(point2,point);
        }
        public Figure(Point point, Point point1, Point point2,Point point3):this(point,point1,point2)
        {
            name = "Четырехугольник";
            Perimetr = LenghtSide(point, point1) + LenghtSide(point1, point2) + LenghtSide(point2, point3)+LenghtSide(point3,point);
        }
        public Figure(Point point, Point point1, Point point2, Point point3,Point point4) : this(point, point1, point2,point3)
        {
            name = "Пятиугольник";
            Perimetr = LenghtSide(point, point1) + LenghtSide(point1, point2) + LenghtSide(point2, point3) + LenghtSide(point3, point4)+LenghtSide(point4,point);
        }
        public override string ToString()
        {
            return $"{name} ";
        }
        public double LenghtSide(Point point,Point point1)
        {
            return Math.Sqrt(Math.Pow(point1.X - point.X, 2) + Math.Pow(point1.Y - point.Y, 2));
        }
        public void PerimeterCalc()
        {
            Console.WriteLine(Perimetr);
        }
    }
}
