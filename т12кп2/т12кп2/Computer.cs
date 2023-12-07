using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп2
{
    internal class Computer
    {
        /// <summary>
        /// Поле описывающее объем ОЗУ
        /// </summary>
        public double OZY;
        /// <summary>
        /// Поле описывающее объем ПЗУ
        /// </summary>
        public double PZY;
        /// <summary>
        /// поле описывающее модель пк
        /// </summary>
        public string Model;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Computer() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="OZY">объем ОЗУ</param>
        /// <param name="PZY">обЪем ПЗУ</param>
        /// <param name="model">модель пк</param>
        public Computer(double OZY, double PZY, string model)
        {
            this.OZY = OZY;
            this.PZY = PZY;
            this.Model = model;
        }
        /// <summary>
        /// метод для вывода информации о пк
        /// </summary>
        /// <returns>информацию пк модель, пзу, озу</returns>
        public override string ToString()
        {
            return $"Model={Model}\t OZY={OZY}\t PZY={PZY}";
        }
    }
}
