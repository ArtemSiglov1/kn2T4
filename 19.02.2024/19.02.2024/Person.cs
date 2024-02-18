using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2024
{
    /// <summary>
    /// абстрактный класс описывающий человека
    /// </summary>
    abstract class Person
    {
        /// <summary>
        /// свойство для имени человека
        /// </summary>
        protected string Name { get; set; }
        /// <summary>
        /// Метод для приветствия человека на его языке 
        /// </summary>
        /// <param name="p">приветствие </param>
        /// <returns>приветствие </returns>
        public abstract string Privetstvie(string p);
        
    }
}
