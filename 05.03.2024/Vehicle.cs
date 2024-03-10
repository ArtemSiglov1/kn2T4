using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03._2024
{
    /// <summary>
    /// абстрактный класс транспорт
    /// </summary>
    abstract class Vehicle
    {
        /// <summary>
        /// Цена
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed {  get; set; }
        /// <summary>
        /// год выпуска
        /// </summary>
        public int Year {  get; set; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Vehicle() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="price">цена</param>
        /// <param name="maxSpeed">макс скорость</param>
        /// <param name="year">год производства</param>
        public Vehicle(int price, int maxSpeed,int year) 
        {
            Price = price;
            MaxSpeed = maxSpeed;
            Year = year;
        }
        /// <summary>
        /// метод вывода информации
        /// </summary>
        /// <returns>поля базового класса</returns>
        public abstract string Print();
    }
}
