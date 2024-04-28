using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т20кп2
{
    /// <summary>
    /// класс отрезок
    /// </summary>
    class Segment//:Point<dynamic,dynamic>
    {
        /// <summary>
        /// точки отрезка
        /// </summary>
        Point<dynamic, dynamic> point1;
        Point<dynamic, dynamic> point2;
        /// <summary>
        /// свойства точек отрезка
        /// </summary>
        public Point<dynamic, dynamic> Point1 { get => point1; set => point1 = value; }
        public Point<dynamic, dynamic> Point2 { get => point2; set => point2 = value; }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="point1">точка а</param>
        /// <param name="point2">точка в</param>
        public Segment(Point<dynamic,dynamic> point1, Point<dynamic, dynamic> point2)
        {
            Point1 = point1;
            Point2 = point2;
        }
        /// <summary>
        /// метод для вывода информации об отрезке
        /// </summary>
        /// <returns>координаты точек отрезка</returns>
        public override string ToString()
        {
            return $"A{point1.ToString()},B{point2.ToString()}";
        }
        /// <summary>
        /// метод для рассчета длины отрезка
        /// </summary>
        /// <returns></returns>
        public double GetLenghtOtr()
        {
            return Math.Round(Math.Sqrt(Math.Pow((Point2.X - Point1.X),2)+Math.Pow(Point2.Y - Point1.Y, 2)),2);
        }
        /// <summary>
        /// метод для ввода информации о точке
        /// </summary>
        /// <returns>объект класса точка</returns>
        public static Point<dynamic, dynamic> Init() 
        {
            Console.WriteLine("Input X");
            dynamic x = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Y");
            dynamic y = double.Parse(Console.ReadLine());
            return new Point<dynamic, dynamic>(x, y);
        }
    }
}
