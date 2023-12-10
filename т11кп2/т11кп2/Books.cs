using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т11кп2
{
    /// <summary>
    /// класс описывающий книгу 
    /// </summary>
    internal class Books
    {
        /// <summary>
        /// поля описывающие название и автора
        /// </summary>
        public string name, avtor;
        /// <summary>
        /// поля описывающие год выпуска и объем в листах
        /// </summary>
        public int age, V;
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Books() { }
        /// <summary>
        /// конструктор с парметрами 
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="avtor">автор</param>
        /// <param name="age">год выпуска</param>
        /// <param name="V">объем в листах</param>
        public Books(string name, string avtor, int age, int V)
        {
            this.name = name;
            this.avtor = avtor;
            this.age = age;
            this.V = V;
        }
        /// <summary>
        /// метод для вывода информации о книге 
        /// </summary>
        /// <returns>название, автор, год выпуска, объем в листах</returns>
        public override string ToString()
        {
            return $"Название-{name}\tАвтор-{avtor}\tГод выпуска-{age}\tОбъем в листах-{V}";
        }
    }
}
