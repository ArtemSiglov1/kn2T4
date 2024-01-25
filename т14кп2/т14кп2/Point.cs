using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т14кп2
{
    /// <summary>
    /// Класс описывающий точку
    /// </summary>
    class Point
    {
        double x, y;

        /// <summary>
        /// статический метод для определения значений счетчиков 
        /// </summary>
        static Point()
        {
            count0 = 0;
            count1 = 0;
            count2 = 0;
            count3 = 0;
            count4 = 0;
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Point()
        {
            this.x = 1.0;
            this.y = 1.0;
        }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="x">координата х</param>
        /// <param name="y">координата у</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            if (x > 0 && y > 0)
            {
                count1++;

            }
            else if (x < 0 && y > 0)
            {
                count2++;

            }
            else if (x < 0 && y < 0)
            {
                count3++;

            }
            else if (x > 0 && y < 0)
            {
                count4++;

            }

            count0 = count1 + count2 + count3 + count4;
        }

        /// <summary>
        /// Поля описывающие количество точек в координатной четверти и на всей плоскости 
        /// </summary>
        public static int count1, count2, count3, count4, count0;
        /// <summary>
        /// метод для возвращения значения х
        /// </summary>
        /// <returns>значение х</returns>
        public double GetX()
        {
            return x;
        }
        /// <summary>
        ///  метод для инциализации поля х
        /// </summary>
        /// <param name="x">координата х</param>
        public void SetX(double x)
        {
            this.x = x;
        }
        /// <summary>
        /// метод для возвращения значения у
        /// </summary>
        /// <returns>значение у</returns>
        public double GetY()
        {
            return y;
        }
        /// <summary>
        /// метод для инциализации поля у
        /// </summary>
        /// <param name="y">координата у</param>
        public void SetY(double y)
        {
            this.y = y;

        }
        /// <summary>
        /// метод для вывода координат точек
        /// </summary>
        /// <returns>значение х,у</returns>

        public override string ToString()
        {
            return $"X={GetX()}\tY={GetY()}";
        }
        /// <summary>
        /// метод для вывода количества точек в разных четвертях и общее количество 
        /// </summary>
        public static void Count()
        {
            Console.WriteLine($"1 четверть-{count1}\n2 четверть-{count2}\n3 четверть-{count3}\n4 четверть-{count4}\nобщее колличество точек-{count0}");
        }
    }
}
