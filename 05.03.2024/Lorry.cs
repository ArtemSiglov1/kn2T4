using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    /// <summary>
    /// Класс грузовик 
    /// </summary>
    internal class Lorry:Vehicle
    {
        /// <summary>
        /// Максимальная емкость свойство
        /// </summary>
        public int MaxCapacity {  get; set; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Lorry() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="price">цена</param>
        /// <param name="maxSpeed">максимальная скорость</param>
        /// <param name="year">год выпуска</param>
        /// <param name="maxCapacity">максимальная емкость</param>
        public Lorry(int price,int maxSpeed,int year,int maxCapacity):base(price,maxSpeed,year) 
        {
         MaxCapacity = maxCapacity;
        }
        /// <summary>
        /// метод вывода информации
        /// </summary>
        /// <returns>поля базового и поля данного класса</returns>
        public override string Print()
        {
            return $"Price:{Price}\tMax Speed:{MaxSpeed}\tYear:{Year}\tMax capacity:{MaxCapacity}";
        }
    }
}
