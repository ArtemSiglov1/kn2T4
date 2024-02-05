using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1_3_
{
   /// <summary>
   /// класс потомок от класса описывающего тетрадь  описывающий общую тетрадь 
   /// </summary>
    internal class AllNotebook:Notebook
    {
        /// <summary>
        /// поле материала обложки
        /// </summary>
        string material;
        /// <summary>
        /// свойство поля материала обложки
        /// </summary>
        public string Material {  get { return material; } set {  material = value; } }
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="k">кол-во страниц</param>
        /// <param name="material">материал обложки</param>
        public AllNotebook(string name,int k,string material):base(name,k)
        {
            this.material = material;
        }
        /// <summary>
        /// метод для вывода информации о общей тетради
        /// </summary>
        new public void Print()
        {
            base.Print();
            Console.Write($"{material}\n");
        }
        /// <summary>
        /// метод для рассчета цены с учетом обложки
        /// </summary>
        /// <returns>базовая цена тетради + цена за обложку</returns>
        new public int Price()
        {
            return base.Price()+50;
        }
    }
}
