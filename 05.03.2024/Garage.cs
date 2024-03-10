using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    /// <summary>
    /// класс гараж 
    /// </summary>
    internal class Garage
    {
      /// <summary>
      /// статичесткий метод ввода информации 
      /// </summary>
      /// <returns>консруктор с параметрами</returns>
        public static Car Init()
        {
            try
            {
                Console.Write("Введите цену:");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Введите максимальную скорость:");
                int maxSpeed = int.Parse(Console.ReadLine());
                Console.Write("Год выпуска:");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Мощность:");
                int power = int.Parse(Console.ReadLine());
                return new Car(price, maxSpeed, year, power);
            }
            catch { return Init(); }
        }
        /// <summary>
        /// статичесткий метод ввода информации 
        /// </summary>
        /// <returns>консруктор с параметрами</returns>
        public static Bicycle Init1()
        {
            try
            {
                Console.Write("Введите цену:");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Введите максимальную скорость:");
                int maxSpeed = int.Parse(Console.ReadLine());
                Console.Write("Год выпуска:");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Количество мест:");
                int kvoMest = int.Parse(Console.ReadLine());
                return new Bicycle(price, maxSpeed, year, kvoMest);
            }
            catch { return Init1(); }
        }
        /// <summary>
        /// статичесткий метод ввода информации 
        /// </summary>
        /// <returns>консруктор с параметрами</returns>
        public static Lorry Init2() 
        {
            try
            {
                Console.Write("Введите цену:");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Введите максимальную скорость:");
                int maxSpeed = int.Parse(Console.ReadLine());
                Console.Write("Год выпуска:");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Максимальная емкость:");
                int maxCapacity = int.Parse(Console.ReadLine());
                return new Lorry(price, maxSpeed, year, maxCapacity);
            }
            catch { return Init2(); }
        }
    }
}
