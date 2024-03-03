using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03._2024
{
    /// <summary>
    /// класс описывающий студента 
    /// </summary>
    internal class Student:Person
    {
        /// <summary>
        /// свойство факультета
        /// </summary>
        public string Facult {  get; set; }
        /// <summary>
        /// свойство курса
        /// </summary>
        public int Kurs {  get; set; }
        /// <summary>
        /// конструктор по умолчанию 
        /// </summary>
        public Student() { }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="dateB">дата рождения</param>
        /// <param name="facult">факультет</param>
        /// <param name="kurs">курс</param>
        public Student(string name,string surname, DateTime dateB,string facult, int kurs):base(name,surname,dateB)
        {
            Facult = facult;
            Kurs = kurs;
        }
        /// <summary>
        /// метод для определения возраста человека
        /// </summary>
        /// <returns>возраст человека</returns>
        public override int Age()
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
        /// <summary>
        /// Метод для вывода информации 
        /// </summary>
        /// <returns>поля класса</returns>
        public override string ToString()
        {
            return $"{base.ToString()}Факультет:{Facult}\nКурс:{Kurs}";
        }
        /// <summary>
        /// метод для ввода информации об объекте
        /// </summary>
        /// <returns>конструктор с параметрами</returns>
        public static Student Init()
        {
            try
            {
                Console.Write("Имя:");
                string name = Console.ReadLine();
                Console.Write("Фамилия:");
                string surname = Console.ReadLine();
                Console.Write("Дата рождения:");
                DateTime dateB = DateTime.Parse(Console.ReadLine());
                Console.Write("Факультет:");
                string facult = Console.ReadLine();
                Console.Write("Курс:");
                int kurs = int.Parse(Console.ReadLine());
                return new Student(name, surname, dateB, facult, kurs);
            }
            catch { return Init(); }
        }
    }
}
