using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп3
{
    internal class Triangle
    {
        /// <summary>
        /// поле описывающее сторону  а
        /// </summary>
        public double a;
        /// <summary>
        /// поле описывающее сторону б
        /// </summary>
        public double b;
        /// <summary>
        /// поле описывающее сторону с
        /// </summary>
        public double c;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Triangle() { }
        /// <summary>
        /// колнструктор с парметрами 
        /// </summary>
        /// <param name="a">сторона а</param>
        /// <param name="b">сторона б</param>
        /// <param name="c">сторона с</param>
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        /// <summary>
        /// конструктор с одним параметром, задающим длину равностороннего треугольника
        /// </summary>
        /// <param name="a">сторона а</param>
        public Triangle(double a)
        {
            this.a = a;
            this.b = a;
            this.c = a;
        }
        /// <summary>
        /// метод вывода длин сторон треугольника 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"a={a}\t b={b}\t c={c}";
        }
        /// <summary>
        /// метод для получения периметра 
        /// </summary>
        /// <returns>Периметр треугольника</returns>
        public double Per()
        {
            return a + b + c;
        }
    }
}
