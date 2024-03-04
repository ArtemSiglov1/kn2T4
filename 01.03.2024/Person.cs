using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _01._03._2024
{
    /// <summary>
    /// класс описывающий персону
    /// </summary>
    abstract class Person
    {
        /// <summary>
        /// свойство имени
        /// </summary>
        public string Name {  get; set; }
        /// <summary>
        /// свойство фамилии
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// свойство даты рождения
        /// </summary>
        public DateTime DateB {  get; set; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Person() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="dateB">дата рождения</param>
        public Person(string name, string surname, DateTime dateB)
        {
            Name = name;
            Surname = surname;
            DateB = dateB;
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString()
        {
            return $"Name-{Name}\nSurname-{Surname}\nДата рождения-{DateB.ToShortDateString()}\n";
        }
        /// <summary>
        /// метод для определения возраста человека
        /// </summary>
        /// <returns>возраст человека</returns>
        public int Age()
        {
            DateTime dateNow = DateTime.Now;
            if (dateNow.Month < DateB.Month)
            {
                return dateNow.Year - DateB.Year - 1;
            }
            else if (dateNow.Month == DateB.Month)
            {
                if (dateNow.Day < DateB.Day)
                {
                    return dateNow.Year - DateB.Year - 1;
                }
                else
                {
                    return dateNow.Year - DateB.Year;
                }

            }
            else { return dateNow.Year - DateB.Year; }
        }
    }
}
