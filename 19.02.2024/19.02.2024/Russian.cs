using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2024
{
    /// <summary>
    /// класс описывающий русского
    /// </summary>
    internal class Russian:Person
    {
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Russian() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name">имя </param>
        public Russian(string name) 
        {
        Name = name;
        }
        /// <summary>
        /// Метод для приветствия человека на его языке 
        /// </summary>
        /// <param name="p">приветствие </param>
        /// <returns>приветствие </returns>
        public override string Privetstvie(string p)
        {
            p = $"Здравствуйте {Name}";
            return p;
        }
        /// <summary>
        /// метод для ввода данных о человеке
        /// </summary>
        /// <returns>конструктор с параметрами</returns>
        public static Russian Vvod()
        {
            try
            { 
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            return new Russian(name);
            }
            catch { Console.WriteLine("No correct data"); return Vvod(); }
        }
        
    }
}

