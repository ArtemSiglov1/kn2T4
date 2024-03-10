using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    /// <summary>
    /// класс велосипед 
    /// </summary>
    internal class Bicycle:Vehicle
    {
        /// <summary>
        /// количество мест 
        /// </summary>
        public int KvoMest {  get; set; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Bicycle() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="price">цена</param>
        /// <param name="maxSpeed">максимальная скорость</param>
        /// <param name="year">год производства</param>
        /// <param name="kvoMest">количество мест </param>
        public Bicycle(int price,int maxSpeed,int year,int kvoMest):base(price,maxSpeed,year) 
        {
            KvoMest=kvoMest;
        }
        /// <summary>
        /// метод вывода информации
        /// </summary>
        /// <returns>поля базового и поля данного класса</returns>
        public override string Print()
        {
            return $"Price:{Price}\tMax Speed:{MaxSpeed}\tYear:{Year}\tPlaces:{KvoMest}";
        }
    }
}
