using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1_2_
{
    /// <summary>
    /// класс описывающий прессу
    /// </summary>
    internal class Press
    {
        /// <summary>
        /// поле описывающее кол-во копий
        /// </summary>
        int copies;
        /// <summary>
        /// поле описывающее название газеты
        /// </summary>
        string name;
        /// <summary>
        /// поле описывающее цену за 1 газету
        /// </summary>
        int price;
       
        /// <summary>
        /// свойство дл яполя копий
        /// </summary>
        public int Copies { get => copies; set => copies = value; }
        /// <summary>
        /// свойство для поля имени
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// свойство для поля цены
        /// </summary>
        public int Price { get => price; set => price = value; }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Press() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="copies">копии</param>
        /// <param name="name">название</param>
        /// <param name="price">цена</param>
        public Press(int copies, string name, int price)
        {
            this.copies = copies;
            this.name = name;
            this.price = price;
        }
        /// <summary>
        /// метод для подсчета общей стоимости тиража
        /// </summary>
        /// <returns>копии*цену</returns>
        public int Cost()
        {
            return copies*price;
        }
        /// <summary>
        /// метод для вывода информации о объекте
        /// </summary>
        public void Output()
        {
            Console.Write($"кол-во копий-{copies}\nназвание-{name}\nцена-{price}\n");
        }
    }
}
