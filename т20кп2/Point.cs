using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т20кп2
{
    /// <summary>
    /// класс точка
    /// </summary>
    /// <typeparam name="tt">х</typeparam>
    /// <typeparam name="tr">у</typeparam>
    class Point<tt,tr>
    {
        /// <summary>
        /// координаты точки
        /// </summary>
        tt x;
        tr y;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Point() { }
        /// <summary>
        /// конструктор 
        /// </summary>
        /// <param name="x">координата х</param>
        /// <param name="y">координата у</param>
        public Point(tt x, tr y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// свойства для координат точки
        /// </summary>
        public tt X { get => x; set => x = value; }
        public tr Y { get => y; set => y = value; }
        /// <summary>
        /// метод для вывода координат точки 
        /// </summary>
        /// <returns>координаты точки</returns>
        public override string ToString()
        {
            return $"({X};{Y})";
        }
    }
}
