using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп2
{
    internal class Transport
    {
        /// <summary>
        /// Поле описывающее тип 
        /// </summary>
        public string tupe;
        /// <summary>
        /// Поле описывающее цвет
        /// </summary>
        public string color;
        /// <summary>
        /// Поле описывающее скорость
        /// </summary>
        public int speed;
        /// <summary>
        /// Поле описывающее массу
        /// </summary>
        public double mass;
        /// <summary>
        /// Коструктор по умолчанию
        /// </summary>
        public Transport() { }
        /// <summary>
        /// Конструктор с параметрами 
        /// </summary>
        /// <param name="tupe">тип машины</param>
        /// <param name="color">цвет машины</param>
        /// <param name="speed">максимальная скорость машины</param>
        /// <param name="mass">масса машины</param>
        public Transport(string tupe, string color, int speed, double mass)
        {
            this.tupe = tupe;
            this.color = color;
            this.speed = speed;
            this.mass = mass;
        }
        /// <summary>
        /// метод для вывода информации о машине
        /// </summary>
        /// <returns>тип,цвет,скорость,масса</returns>
        public override string ToString()
        {
            return $"Тип-{tupe}Цвет-{color}Скорость-{speed}Масса-{mass}";
        }
    }
}
