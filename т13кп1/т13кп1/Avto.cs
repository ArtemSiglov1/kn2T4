using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т13кп1
{
    
    
        /// <summary>
        /// Класс описывающий авто
        /// </summary>
        internal class Avto
        {/// <summary>
         /// поля
         /// </summary>
            string brand, color;
            int skor;
            /// <summary>
            /// конструктор по умолчанию
            /// </summary>
            public Avto() { }
            /// <summary>
            /// конструктор с 3мя параметрами
            /// </summary>
            /// <param name="brand">поле описывающее марку машины</param>
            /// <param name="color">поле описывающее цвет машины</param>
            /// <param name="skor">поле описывающее скорость машины</param>
            public Avto(string brand, string color, int skor)
            {
                this.Brand = brand;
                this.Color = color;
                this.Skor = skor;
            }
            /// <summary>
            /// свойства поля описывающего марку машины
            /// </summary>
            public string Brand
            { get { return brand; } set { brand = value; } }
            /// <summary>
            /// свойства поля описывабщего цвет машины
            /// </summary>
            public string Color
            {
                get { return color; }
                set { color = value; }
            }
            /// <summary>
            /// свойства поля описывающего скорость машины
            /// </summary>
            public int Skor { get { return skor; } set { skor = (value < 20 || value > 120) ? 0 : value; } }
            /// <summary>
            /// Метод вывода полей
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return $"Brand-{brand}\tColor-{color}\tSkor-{skor}";
            }
        }
}
