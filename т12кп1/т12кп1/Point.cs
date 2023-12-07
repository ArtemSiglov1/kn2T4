using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп1
{
    internal class Point
    {
        /// <summary>
        /// поле описывающий координату х
        /// </summary>
        public int x;
        /// <summary>
        /// поле описывающий координату у
        /// </summary>
        public int y;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Point() { }
        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// метод описывающий координату точки
        /// </summary>
        /// <returns>координата х координата у</returns>
        public override string ToString()
        {
            return $"X={x}\t Y={y}";
        }
        public double Rast()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
