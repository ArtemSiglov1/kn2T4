using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1_3_
{
    /// <summary>
    /// базовый метод описывающий тетрадь 
    /// </summary>
    internal class Notebook
    {
        /// <summary>
        /// поле имени
        /// </summary>
        string name;
        /// <summary>
        /// поле количества страниц
        /// </summary>
        int k;
        /// <summary>
        /// свойтсво имени 
        /// </summary>
        public string Name {  get { return name; } set { name = value; } }
        /// <summary>
        /// свойтсво количества страниц
        /// </summary>
        public int K { get { return k; } set { k = value; } }   
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Notebook() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="k">кол-во страниц</param>
        public Notebook(string name, int k) 
        {
         this.name=name;
            this.k = k;
        }
        /// <summary>
        /// метод для расчета стоимости тетради 
        /// </summary>
        /// <returns>кол-во листов умноженное на стоимость 1 листа</returns>
        public int Price()
        {
            return 15 * k;
        }
        /// <summary>
        /// метод для вывода инфы о тетради
        /// </summary>
        public void Print()
        {
            Console.Write($"имя-{name}\nкол-во страниц-{k}\n");
        }
       
    }
}
