using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    /// <summary>
    /// класс машина
    /// </summary>
    internal class Car:Vehicle
    {
        /// <summary>
        /// Мощность
        /// </summary>
        public int Power {  get; set; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Car() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="price">цена</param>
        /// <param name="maxSpeed">максимальная цена</param>
        /// <param name="year">год производства</param>
        /// <param name="power">мощность</param>
        public Car(int price,int maxSpeed,int year,int power):base(price,maxSpeed,year) 
        {
         Power = power;
        }
        /// <summary>
        /// метод вывода информации
        /// </summary>
        /// <returns>поля базового и поля данного класса</returns>
        public override string Print()
        {
            return $"Price:{Price}\tMax Speed:{MaxSpeed}\tYear:{Year}\tPower{Power}\n";
        }
    }
}
