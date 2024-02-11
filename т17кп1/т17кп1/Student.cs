using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace т17кп1
{
    /// <summary>
    /// наследуемый класс описывающий студента
    /// </summary>
    internal class Student:Person
    {
        /// <summary>
        /// Поле описывающее дату рождения
        /// </summary>
        DateTime dateB;
        /// <summary>
        /// поле описывающее курс 
        /// </summary>
        int kurs;
        /// <summary>
        /// свойство для поля даты рождения
        /// </summary>
        public DateTime DateB { get => dateB; set => dateB = value; }
        /// <summary>
        /// свойство для поля курс
        /// </summary>
        public int Kurs { get => kurs; set => kurs = value; }
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="age">возраст</param>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="dateB">дата рождения</param>
        /// <param name="kurs">курс</param>
        public Student(int age,string name,string surname,DateTime dateB,int kurs):base(age,name,surname)
        {
            this.dateB = dateB;
            this.kurs = kurs;
        }
        /// <summary>
        /// метод вывода инфы об объекте
        /// </summary>
        new public void Print()
        {
            base.Print();
            Console.WriteLine($"{dateB.ToLongDateString()} {kurs}");
        }
    }
}
