using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп3
{
    internal class Param
    {
        /// <summary>
        /// поле описывающее первое число
        /// </summary>
        public double num1;
        /// <summary>
        /// поле описывающее второе число
        /// </summary>
        public double num2;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Param()
        {
        }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="num1">первое число </param>
        /// <param name="num2">второе число</param>
        public Param(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        /// <summary>
        /// функция формирования строки с информацией об объекте
        /// </summary>
        public void Func()
        {
            Console.WriteLine($"num1={num1}\t num2={num2}");
        }
        /// <summary>
        ///  функция обработки значений полей
        /// </summary>
        /// <returns>корень квадратный из произведения чисел</returns>
        public double Func1()
        {

            return Math.Sqrt(num1 * num2);
        }
    }
}
