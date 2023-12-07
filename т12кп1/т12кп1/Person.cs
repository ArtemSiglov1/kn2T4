using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т12кп1
{
    internal class Person
    {
        /// <summary>
        /// поле описывающее имя
        /// </summary>
        public string name;
        /// <summary>
        /// Поле описывающее фамилию
        /// </summary>
        public string surname;
        /// <summary>
        /// поле описывающее возраст
        /// </summary>
        public int age;
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Person() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        /// <summary>
        /// метод описывающий человека
        /// </summary>
        /// <returns>имя фамилию возраст</returns>
        public override string ToString()
        {
            return $"Name-{name}\t Surname-{surname}\t Age-{age}";
        }
    }
}
    

