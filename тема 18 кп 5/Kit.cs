using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема_18_кп_5
{/// <summary>
/// наследуемый класс
/// </summary>
    internal class Kit: Goods
    {/// <summary>
    /// лсит продукт
    /// </summary>
        public List<string> Products { get; set; }
        /// <summary>
        /// метод для проверки годности товара
        /// </summary>
        /// <returns></returns>
        public override string DeadlineExpirationDate()
        {
            return null;
        }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Kit() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="price">price</param>
        /// <param name="products">products</param>
        public Kit(string name,int price,List<string>products):base(name,price) 
        {
            Products = products;
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        /// <returns>базовый метод для вывода информации и содержимое листа </returns>
        public override string ToString()
        {
           
            foreach (string s in Products) { return $"{base.ToString()}\n{s}\n" ; } 
            return $"\n";
        }

    }
}
