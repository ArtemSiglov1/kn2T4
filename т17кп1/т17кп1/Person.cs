using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1
{
    /// <summary>
    /// Базовый класс описывающий персону
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// поле описывающее возраст
        /// </summary>
        int age;
        /// <summary>
        /// поле описывающее имя
        /// </summary>
        string name;
        /// <summary>
        /// поле описывающее фамилию
        /// </summary>
        string surname;
        /// <summary>
        /// свойство для поля возраста
        /// </summary>
        public int Age { get => age; set => age = value; }
        /// <summary>
        /// свойство для поля имени
        /// </summary>
        public string Name { get => name; set => name = value; }
        /// <summary>
        /// свойство для поля фамилии
        /// </summary>
        public string Surname { get => surname; set => surname = value; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Person() { }
        /// <summary>
        /// конструктор с одним параметром 
        /// </summary>
        /// <param name="age">возраст</param>
        public Person(int age)
        {
            this.age = age;
        }
        /// <summary>
        /// конструктор с двумя параметрами 
        /// </summary>
        /// <param name="age">возраст</param>
        /// <param name="name">имя</param>
        public Person(int age,string name):this(age)
        {
            this.name = name;
        }
        /// <summary>
        /// конструктор с тремя параметрами
        /// </summary>
        /// <param name="age">возраст</param>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        public Person(int age, string name, string surname):this(age,name)
        {
            this.surname = surname; 
        }
        /// <summary>
        /// метод для вывода информации об объекте
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"{age} {name} {surname} ");
        }
    }
}
