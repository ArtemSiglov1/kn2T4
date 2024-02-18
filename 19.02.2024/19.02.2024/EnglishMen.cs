using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2024
{
    /// <summary>
    /// класс описывающий англичанина
    /// </summary>
    internal class EnglishMen : Person
    {
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public EnglishMen() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">имя человека</param>
        public EnglishMen(string name) { this.Name= name; }
        /// <summary>
        /// Метод для приветствия человека на его языке 
        /// </summary>
        /// <param name="p">приветствие </param>
        /// <returns>приветствие </returns>
        public override string Privetstvie(string p)
        {
            p=$"Hello {Name}";
            return p;
        }
        /// <summary>
        /// метод для ввода данных о человеке
        /// </summary>
        /// <returns>конструктор с параметрами</returns>
        public static EnglishMen Vvod()
        {
            try
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                return new EnglishMen(name);
            }
            catch { Console.WriteLine("No correct data");return Vvod(); }
        }
    }
}
