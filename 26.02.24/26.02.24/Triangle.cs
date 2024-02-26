using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._24
{
    /// <summary>
    /// класс описывающий треугольник
    /// </summary>
    internal class Triangle:Figure
    {
        /// <summary>
        /// стороны треугольника
        /// </summary>
        int side1, side2, side3;
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="side1">сторона а</param>
        /// <param name="side2">сторона б</param>
        /// <param name="side3">сторона с</param>
        public Triangle(string name,int side1, int side2, int side3):base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        /// <summary>
        /// свойство стороны а
        /// </summary>
        public int Side1 { get => side1; set => side1 = value; }
        /// <summary>
        /// свойство стороны б
        /// </summary>
        public int Side2 { get => side2; set => side2 = value; }
        /// <summary>
        /// свойство стороны с
        /// </summary>
        public int Side3 { get => side3; set => side3 = value; }
        /// <summary>
        /// метод для нахождения площади
        /// </summary>
        /// <returns>площадь треугольника</returns>
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
        }
        /// <summary>
        /// метод для нахождения периметра 
        /// </summary>
        /// <returns>периметр треугольника</returns>
        public override double Perimeter()
        {
            return side1+side2+side3;
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString()
        {
            return $"Название фигуры-{base.ToString()} а={side1} б={side2} с={side3}";
        }
        /// <summary>
        /// метод для ввода информации об объекте
        /// </summary>
        /// <returns>конструктор с параметрами </returns>
        public static Triangle Input()
        {
            string name = "Треугольник";
            Console.WriteLine("а=");
            int side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("б=");
            int side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("с=");
            int side3=int.Parse(Console.ReadLine());
            return new Triangle(name, side1, side2,side3);
        }
    }
}
