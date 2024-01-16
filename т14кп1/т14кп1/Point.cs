using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т14кп1
{
    
    
        /// <summary>
        /// не статический класс описывающий точку 
        /// </summary>
        internal class Point
        {
            /// <summary>
            /// внутренние поля описывающие координаты точек 
            /// </summary>
            private double x, y;
            /// <summary>
            ///Внешнее поле для подсчета количества созданных экземпляров 
            /// </summary>
            public static int count;
            /// <summary>
            ///  статический конструктор Point(), который инициализирует статическую переменную count нулевым значением;
            /// </summary>
            static Point()
            {
                count = 0;
            }
            /// <summary>
            ///    нестатический конструктор Point(double, double) с двумя параметрами, которые инициализируют одноименные внутренние поля класса;
            /// </summary>
            /// <param name="x">описывающий поле х</param>
            /// <param name="y">описывающий поле у</param>
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
                //   count++;
                Point.count++;
            }
            /// <summary>
            /// нестатический конструктор Point() без параметров, который инициализирует внутренние поля класса значением 1.0;
            /// </summary>
            public Point()
            {
                this.x = 1.0;
                this.y = 1.0;
                count++;
            }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
            public double getX()
            {
                return x;
            }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
            public double getY()
            {
                return y;
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
            public void setX(double x)
            {
                this.x = x;
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="y"></param>
            public void setY(double y)
            {
                this.y = y;
            }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
         public override string ToString()
         {
            return $"Координаты точки:{getX():f1}\t{getY():f1}";
         }
        static void LengthPoints(Point[] points)
        {
            
        }


    }
}
