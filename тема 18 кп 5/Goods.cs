using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_5
{/// <summary>
/// абстрактный класс
/// </summary>
      abstract class Goods
    {/// <summary>
    /// поле описывающее имя
    /// </summary>
        public string Name{  get; set; }
        /// <summary>
        /// поле описывающее цену
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// поле описывающее дату производства
        /// </summary>
        /// <returns>просрочился товар или нет</returns>
        public abstract string DeadlineExpirationDate();
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        /// <returns>свойства класса</returns>
        public override string ToString()
        {
            return $"Название:{Name}\nЦена:{Price}";
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Goods() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Goods(string name,int price) {
        Name= name ;
            Price = price ;
        }



        }
}
