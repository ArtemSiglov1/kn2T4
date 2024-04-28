using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т20кп2
{
    /// <summary>
    /// класс треугольник
    /// </summary>
    internal class Triangle
    {
        /// <summary>
        /// стороны треугольника
        /// </summary>
        public Segment A { get; set; }
        public Segment B {  get;set; }
        public Segment C {  get;set; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="segment">отрезок а</param>
        /// <param name="segment1">отрезок в</param>
        /// <param name="segment2">отрезок с</param>
        public Triangle(Segment segment,Segment segment1,Segment segment2)
        {
           A = segment;
           B = segment1;
           C = segment2;
        }
        /// <summary>
        /// метод для вывода информации о треугольнике
        /// </summary>
        /// <returns>длина сторон</returns>
        public override string ToString()
        {
            return $"segment a-{A.GetLenghtOtr()} segment b-{B.GetLenghtOtr()} segment c-{C.GetLenghtOtr()}";
        }
        /// <summary>
        /// метод для рассчета площади треугольника
        /// </summary>
        /// <returns>площадь по формуле герона</returns>
        public double Square()
        {
            if (SushTriangle() == true)
            {
                double p = (A.GetLenghtOtr() + B.GetLenghtOtr() + C.GetLenghtOtr()) / 2;
                return Math.Round(Math.Sqrt(p * (p - A.GetLenghtOtr()) * (p - B.GetLenghtOtr()) * (p - C.GetLenghtOtr())),2);
            }
            return 0;
        }
        /// <summary>
        /// Метод для определения существует ли треугольник
        /// </summary>
        /// <returns>лог истина или ложь</returns>
        public bool SushTriangle()
        {
            if(A.GetLenghtOtr()<B.GetLenghtOtr()+C.GetLenghtOtr()||
               B.GetLenghtOtr() < A.GetLenghtOtr() + C.GetLenghtOtr()||
               C.GetLenghtOtr() < A.GetLenghtOtr() + B.GetLenghtOtr())
            {
                return true ;
            }
            return false;
        }

    }
}
